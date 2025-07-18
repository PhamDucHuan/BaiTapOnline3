using ISC_Project.Data;
using ISC_Project.DTOs.School_Year;
using ISC_Project.DTOs.SchoolYear;
using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;
namespace ISC_Project.Services
{
    public class SchoolYearService : ISchoolYearService
    {
        private readonly ISC_ProjectDbContext _context;
        public SchoolYearService(ISC_ProjectDbContext context) { _context = context; }

        public async Task<SchoolYearDto> CreateAsync(CreateSchoolYearDto dto)
        {
            // Lưu ý: Tên model có thể cần là `SchoolYear` thay vì `School Year`
            var schoolYear = new SchoolYear
            {
                SchoolYearName = dto.SchoolYearName,
                StarTime = dto.StarTime,
                EndTime = dto.EndTime,
                SchoolId = dto.SchoolId
            };
            _context.SchoolYears.Add(schoolYear);
            await _context.SaveChangesAsync();
            return new SchoolYearDto
            {
                SchoolYearId = schoolYear.SchoolYearId,
                SchoolYearName = schoolYear.SchoolYearName,
                StarTime = (DateTime)schoolYear.StarTime,
                EndTime = (DateTime)schoolYear.EndTime
            };
        }

        public async Task<IEnumerable<SchoolYearDto>> GetAllAsync()
        {
            return await _context.SchoolYears
                .Select(sy => new SchoolYearDto
                {
                    SchoolYearId = sy.SchoolYearId,
                    SchoolYearName = sy.SchoolYearName,
                    StarTime = (DateTime)sy.StarTime,
                    EndTime = (DateTime)sy.EndTime
                })
                .ToListAsync();
        }

        public async Task<SchoolYearDto?> GetByIdAsync(int id)
        {
            return await _context.SchoolYears
                .Where(sy => sy.SchoolYearId == id)
                .Select(sy => new SchoolYearDto
                {
                    SchoolYearId = sy.SchoolYearId,
                    SchoolYearName = sy.SchoolYearName,
                    StarTime = (DateTime)sy.StarTime,
                    EndTime = (DateTime)sy.EndTime
                })
                .FirstOrDefaultAsync();
        }

        public async Task<SchoolYearDto> InheritAsync(InheritSchoolYearDto dto)
        {
            // Bắt đầu một transaction để đảm bảo toàn vẹn dữ liệu
            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                // === BƯỚC 1: TẠO NIÊN KHÓA MỚI ===
                var newSchoolYear = new SchoolYear
                {
                    SchoolYearName = dto.NewSchoolYearName,
                    StarTime = dto.NewStartTime,
                    EndTime = dto.NewEndTime,
                    // Giả sử SchoolId được lấy từ niên khóa cũ hoặc một nguồn khác
                };
                _context.SchoolYears.Add(newSchoolYear);
                await _context.SaveChangesAsync(); // Lưu để lấy được newSchoolYear.SchoolYearId

                // === BƯỚC 2: LẤY DỮ LIỆU TỪ NIÊN KHÓA CŨ ===
                var oldStudents = await _context.StudentsProfiles
                    .Where(s => s.SchoolYearId == dto.SourceSchoolYearId)
                    .AsNoTracking().ToListAsync();

                var oldClasses = await _context.Classes
                    .Where(c => c.SchoolYearId == dto.SourceSchoolYearId)
                    .AsNoTracking().ToListAsync();

                var oldSubjects = await _context.Subjects
                    .Where(s => s.SchoolYearId == dto.SourceSchoolYearId)
                    .AsNoTracking().ToListAsync();

                // === BƯỚC 3: SAO CHÉP LỚP HỌC VÀ MÔN HỌC ===
                // Tạo một map để theo dõi ID cũ -> ID mới
                var oldToNewClassIdMap = new Dictionary<int, int>();
                foreach (var oldClass in oldClasses)
                {
                    var newClass = new Class
                    {
                        ClassName = oldClass.ClassName,
                        ClassCode = oldClass.ClassCode,
                        Description = oldClass.Description,
                        // ... sao chép các thuộc tính khác ...
                        SchoolYearId = newSchoolYear.SchoolYearId // Gán vào niên khóa mới
                    };
                    _context.Classes.Add(newClass);
                    await _context.SaveChangesAsync(); // Lưu để lấy newClass.ClassId
                    oldToNewClassIdMap[oldClass.ClassId] = newClass.ClassId;
                }

                // Tương tự cho môn học...

                // === BƯỚC 4: SAO CHÉP HỌC VIÊN VÀ CẬP NHẬT LỚP MỚI ===
                foreach (var oldStudent in oldStudents)
                {
                    // ✅ Bắt đầu sửa từ đây
                    int? newMappedClassId = null; // Mặc định là không có lớp
                    if (oldStudent.ClassId.HasValue) // Kiểm tra xem học viên cũ có thuộc lớp nào không
                    {
                        // Thử tìm ID lớp mới trong map, nếu có thì gán vào biến newMappedClassId
                        oldToNewClassIdMap.TryGetValue(oldStudent.ClassId.Value, out int foundNewId);
                        newMappedClassId = foundNewId > 0 ? foundNewId : (int?)null;
                    }

                    var newStudent = new StudentsProfile
                    {
                        StudentName = oldStudent.StudentName,
                        StudentCode = oldStudent.StudentCode,
                        DateOfBirth = oldStudent.DateOfBirth,
                        Status = "Đang học",
                        // ... sao chép các thuộc tính khác ...
                        SchoolYearId = newSchoolYear.SchoolYearId,

                        // Gán ID lớp mới đã tìm được
                        ClassId = newMappedClassId
                    };
                    _context.StudentsProfiles.Add(newStudent);
                    // ✅ Kết thúc sửa ở đây
                }

                // === BƯỚC 5: SAO CHÉP PHÂN CÔNG GIẢNG DẠY ===
                // Logic này phụ thuộc vào cách bạn lưu trữ phân công.
                // Ví dụ: cập nhật TeacherProfile hoặc tạo bản ghi trong bảng trung gian.

                // Lưu tất cả các thay đổi còn lại
                await _context.SaveChangesAsync();

                // Nếu mọi thứ thành công, commit transaction
                await transaction.CommitAsync();

                // Trả về thông tin niên khóa mới đã tạo
                return new SchoolYearDto
                {
                    SchoolYearId = newSchoolYear.SchoolYearId,
                    SchoolYearName = newSchoolYear.SchoolYearName,
                    StarTime = (DateTime)newSchoolYear.StarTime,
                    EndTime = (DateTime)newSchoolYear.EndTime
                };
            }
            catch (Exception)
            {
                // Nếu có bất kỳ lỗi nào, rollback tất cả thay đổi
                await transaction.RollbackAsync();
                throw; // Ném lại exception để controller xử lý
            }
        }
    }
}
