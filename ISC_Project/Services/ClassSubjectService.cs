using ISC_Project.Interface;
using ISC_Project.Models;
using Npgsql;

namespace ISC_Project.Services
{
    public class ClassSubjectService : IClassSubjectService
    {
        private readonly NpgsqlConnection _conn;

        public ClassSubjectService(IConfiguration config)
        {
            _conn = new NpgsqlConnection(config.GetConnectionString("DefaultConnection"));
        }

        public async Task<IEnumerable<Class>> GetAllClassesAsync()
        {
            var classes = new List<Class>();
            var cmd = new NpgsqlCommand("SELECT * FROM \"Class\"", _conn);
            _conn.Open();
            var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                classes.Add(new Class
                {
                    ClassId = reader.GetInt32(0),
                    ClassName = reader.GetString(1),
                    ClassCode = reader.GetString(2),
                    ClassPassword = reader.IsDBNull(3) ? null : reader.GetString(3),
                    StudentNumber = reader.IsDBNull(4) ? null : reader.GetInt32(4),
                    Classification = reader.IsDBNull(5) ? null : reader.GetString(5),
                    FileClassUrl = reader.IsDBNull(6) ? null : reader.GetString(6),
                    Description = reader.IsDBNull(7) ? null : reader.GetString(7),
                    NumberOfSessions = reader.IsDBNull(8) ? null : reader.GetInt32(8),
                    Status = reader.IsDBNull(9) ? null : reader.GetString(9),
                    StarTime = reader.IsDBNull(10) ? null : reader.GetDateTime(10),
                    EndTime = reader.IsDBNull(11) ? null : reader.GetDateTime(11),
                    ClassUrl = reader.IsDBNull(12) ? null : reader.GetString(12),
                    JoinCode = reader.IsDBNull(13) ? null : reader.GetString(13),
                    JoinPassword = reader.IsDBNull(14) ? null : reader.GetString(14),
                    UserId = reader.GetInt32(15),
                    DepartmentId = reader.GetInt32(16),
                    ClassTypeId = reader.GetInt32(17),
                    SchoolYearId = reader.GetInt32(18),
                });
            }
            _conn.Close();
            return classes;
        }

        public async Task<IEnumerable<Subject>> GetAllSubjectsAsync()
        {
            var subjects = new List<Subject>();
            var cmd = new NpgsqlCommand("SELECT * FROM \"Subjects\"", _conn);
            _conn.Open();
            var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                subjects.Add(new Subject
                {
                    SubjectsId = reader.GetInt32(0),
                    SubjectCode = reader.GetString(1),
                    SubjectsName = reader.GetString(2),
                    StarTime = reader.IsDBNull(3) ? null : reader.GetDateTime(3),
                    EndTime = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                    SubjectTypeId = reader.GetInt32(5),
                    DepartmentId = reader.GetInt32(6),
                    UserId = reader.GetInt32(7),
                    SchoolYearId = reader.GetInt32(8),
                });
            }
            _conn.Close();
            return subjects;
        }

        public async Task<IEnumerable<Subject>> GetSubjectsByClassIdAsync(int classId)
        {
            var subjects = new List<Subject>();
            var cmd = new NpgsqlCommand("SELECT s.* FROM \"Subjects\" s JOIN \"Subjects_Class\" sc ON s.\"Subjects_ID\" = sc.\"Subjects_ID\" WHERE sc.\"Class_ID\" = @classId", _conn);
            cmd.Parameters.AddWithValue("@classId", classId);
            _conn.Open();
            var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                subjects.Add(new Subject
                {
                    SubjectsId = reader.GetInt32(0),
                    SubjectCode = reader.GetString(1),
                    SubjectsName = reader.GetString(2)
                });
            }
            _conn.Close();
            return subjects;
        }

        public async Task AssignSubjectToClassAsync(int? subjectId, int? classId)
        {
            var cmd = new NpgsqlCommand("INSERT INTO \"Subjects_Class\" (\"Subjects_ID\", \"Class_ID\") VALUES (@subjectId, @classId)", _conn);
            cmd.Parameters.AddWithValue("@subjectId", subjectId);
            cmd.Parameters.AddWithValue("@classId", classId);
            _conn.Open();
            await cmd.ExecuteNonQueryAsync();
            _conn.Close();
        }
    }
}
