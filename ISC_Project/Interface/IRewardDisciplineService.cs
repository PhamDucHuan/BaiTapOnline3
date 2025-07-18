using ISC_Project.DTOs.RewardDiscipline;
using ISC_Project.Models;

namespace ISC_Project.Interface
{
    public interface IRewardDisciplineService
    {
        // Create
        Task<Reward> CreateRewardAsync(CreateRewardOrDisciplineDto dto);
        Task<Discipline> CreateDisciplineAsync(CreateRewardOrDisciplineDto dto);

        // Read
        Task<Reward?> GetRewardByIdAsync(int rewardId);
        Task<IEnumerable<Reward>> GetAllRewardsAsync();
        Task<Discipline?> GetDisciplineByIdAsync(int disciplineId);
        Task<IEnumerable<Discipline>> GetAllDisciplinesAsync();
    }
}
