using ISC_Project.Data;
using ISC_Project.DTOs.RewardDiscipline;
using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ISC_Project.Services
{
    public class RewardDisciplineService : IRewardDisciplineService
    {
        private readonly ISC_ProjectDbContext _context;

        public RewardDisciplineService(ISC_ProjectDbContext context)
        {
            _context = context;
        }

        // --- CREATE ---
        public async Task<Reward> CreateRewardAsync(CreateRewardOrDisciplineDto dto)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var newReward = new Reward
                {
                    UserId = dto.UserId,
                    ClassId = dto.ClassId,
                    Content = dto.Content,
                    RewardDate = dto.DecisionDate ?? DateTime.UtcNow
                };
                _context.Rewards.Add(newReward);

                var studentProfile = await _context.StudentsProfiles.FirstOrDefaultAsync(p => p.UserId == dto.UserId);
                if (studentProfile != null)
                {
                    studentProfile.NumberRewards = (studentProfile.NumberRewards ?? 0) + 1;
                    _context.Entry(studentProfile).State = EntityState.Modified;
                }

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
                return newReward;
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task<Discipline> CreateDisciplineAsync(CreateRewardOrDisciplineDto dto)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var newDiscipline = new Discipline
                {
                    UserId = dto.UserId,
                    ClassId = dto.ClassId,
                    Content = dto.Content,
                    DisciplineDate = dto.DecisionDate ?? DateTime.UtcNow
                };
                _context.Disciplines.Add(newDiscipline);

                var studentProfile = await _context.StudentsProfiles.FirstOrDefaultAsync(p => p.UserId == dto.UserId);
                if (studentProfile != null)
                {
                    studentProfile.NumberDisciplinaryActions = (studentProfile.NumberDisciplinaryActions ?? 0) + 1;
                }

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
                return newDiscipline;
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        // --- READ ---
        public async Task<Reward?> GetRewardByIdAsync(int rewardId)
        {
            return await _context.Rewards.AsNoTracking().FirstOrDefaultAsync(r => r.RewardId == rewardId);
        }

        public async Task<IEnumerable<Reward>> GetAllRewardsAsync()
        {
            return await _context.Rewards.AsNoTracking().ToListAsync();
        }

        public async Task<Discipline?> GetDisciplineByIdAsync(int disciplineId)
        {
            return await _context.Disciplines.AsNoTracking().FirstOrDefaultAsync(d => d.DisciplineId == disciplineId);
        }

        public async Task<IEnumerable<Discipline>> GetAllDisciplinesAsync()
        {
            return await _context.Disciplines.AsNoTracking().ToListAsync();
        }
    }
}