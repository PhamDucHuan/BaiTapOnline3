using ISC_Project.Data;
using ISC_Project.DTOs.QuestionBank;
using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ISC_Project.Services 
{
    public class QuestionBankService : IQuestionBankService
    {
        private readonly ISC_ProjectDbContext _context;

        public QuestionBankService(ISC_ProjectDbContext context)
        {
            _context = context;
        }

        // --- PHƯƠNG THỨC LẤY TẤT CẢ (BỊ THIẾU) ---
        public async Task<IEnumerable<QuestionDetailDto>> GetAllQuestionsAsync()
        {
            return await _context.Questions
                .AsNoTracking()
                .Select(q => new QuestionDetailDto
                {
                    QuestionId = q.QuestionsId,
                    QuestionText = q.QuestionsText,
                    QuestionType = q.QuestionsType
                    // Lưu ý: Không tải các options để danh sách nhẹ hơn, chỉ tải chi tiết khi cần
                }).ToListAsync();
        }


        // --- PHƯƠNG THỨC LẤY THEO ID (BẠN ĐÃ CÓ) ---
        public async Task<QuestionDetailDto?> GetQuestionByIdAsync(int questionId)
        {
            return await _context.Questions
                .AsNoTracking()
                .Include(q => q.QuestionOptions) // Eager load các options
                .Where(q => q.QuestionsId == questionId)
                .Select(q => new QuestionDetailDto
                {
                    QuestionId = q.QuestionsId,
                    QuestionText = q.QuestionsText,
                    QuestionType = q.QuestionsType,
                    Options = q.QuestionOptions.Select(o => new QuestionOptionDto
                    {
                        QuestionOptionId = o.QuestionOptionsId,
                        OptionText = o.OptionText,
                        IsCorrect = o.IsCorrect ?? false
                    }).ToList()
                }).FirstOrDefaultAsync();
        }

        // --- PHƯƠNG THỨC TẠO MỚI (BẠN ĐÃ CÓ) ---
        public async Task<QuestionDetailDto> CreateQuestionAsync(CreateQuestionDto dto, int creatorUserId)
        {
            var newQuestion = new Question
            {
                QuestionsText = dto.QuestionText,
                QuestionsType = dto.QuestionType, // Giả định model dùng string
                SubjectId = dto.SubjectId,
                UserId = creatorUserId,
                QuestionOptions = dto.Options.Select(opt => new QuestionOption
                {
                    OptionText = opt.OptionText,
                    IsCorrect = opt.IsCorrect
                }).ToList()
            };

            _context.Questions.Add(newQuestion);
            await _context.SaveChangesAsync();

            return await GetQuestionByIdAsync(newQuestion.QuestionsId) ?? throw new InvalidOperationException("Failed to retrieve created question.");
        }

        // --- PHƯƠNG THỨC CẬP NHẬT (BỊ THIẾU) ---
        public async Task<QuestionDetailDto?> UpdateQuestionAsync(int questionId, UpdateQuestionDto dto)
        {
            var question = await _context.Questions
                .Include(q => q.QuestionOptions)
                .FirstOrDefaultAsync(q => q.QuestionsId == questionId);

            if (question == null) return null;

            await using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                // Cập nhật thông tin chính của câu hỏi
                question.QuestionsText = dto.QuestionText;
                question.QuestionsType = dto.QuestionType;
                question.SubjectId = dto.SubjectId;

                // Logic xử lý các options (xóa, cập nhật, thêm mới)
                var optionsInDtoIds = dto.Options.Where(o => o.Id > 0).Select(o => o.Id).ToList();

                // 1. Xóa các options trong DB mà không có trong DTO gửi lên
                var optionsToDelete = question.QuestionOptions
                    .Where(o => !optionsInDtoIds.Contains(o.QuestionOptionsId)).ToList();
                if (optionsToDelete.Any())
                    _context.QuestionOptions.RemoveRange(optionsToDelete);

                // 2. Cập nhật hoặc Thêm mới
                foreach (var optionDto in dto.Options)
                {
                    if (optionDto.Id > 0) // Cập nhật option đã có
                    {
                        var optionToUpdate = question.QuestionOptions
                            .FirstOrDefault(o => o.QuestionOptionsId == optionDto.Id);
                        if (optionToUpdate != null)
                        {
                            optionToUpdate.OptionText = optionDto.OptionText;
                            optionToUpdate.IsCorrect = optionDto.IsCorrect;
                        }
                    }
                    else // Thêm option mới (Id = 0)
                    {
                        question.QuestionOptions.Add(new QuestionOption
                        {
                            OptionText = optionDto.OptionText,
                            IsCorrect = optionDto.IsCorrect
                        });
                    }
                }

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                return await GetQuestionByIdAsync(questionId);
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        // --- PHƯƠNG THỨC XÓA (BỊ THIẾU) ---
        public async Task<bool> DeleteQuestionAsync(int questionId)
        {
            var question = await _context.Questions.FindAsync(questionId);
            if (question == null) return false;

            // Nhờ cấu hình OnDelete(DeleteBehavior.Cascade) trong DbContext (nếu có), 
            // các QuestionOptions liên quan sẽ bị xóa tự động.
            _context.Questions.Remove(question);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}