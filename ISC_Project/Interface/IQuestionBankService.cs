using ISC_Project.DTOs.QuestionBank;

namespace ISC_Project.Interface
{
    public interface IQuestionBankService
    {
        Task<QuestionDetailDto?> GetQuestionByIdAsync(int questionId);
        Task<IEnumerable<QuestionDetailDto>> GetAllQuestionsAsync();
        Task<QuestionDetailDto> CreateQuestionAsync(CreateQuestionDto dto, int creatorUserId);
        Task<QuestionDetailDto?> UpdateQuestionAsync(int questionId, UpdateQuestionDto dto);
        Task<bool> DeleteQuestionAsync(int questionId);
    }
}
