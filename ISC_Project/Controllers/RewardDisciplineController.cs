using ISC_Project.DTOs.RewardDiscipline;
using ISC_Project.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ISC_Project.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/student-conduct")]
    public class RewardDisciplineController : ControllerBase
    {
        private readonly IRewardDisciplineService _service;

        public RewardDisciplineController(IRewardDisciplineService service)
        {
            _service = service;
        }

        //--- Rewards ---
        [Authorize(Roles = "Admin,Teacher")]
        [HttpGet("rewards")]
        public async Task<IActionResult> GetAllRewards() => Ok(await _service.GetAllRewardsAsync());

        [Authorize(Roles = "Admin,Teacher")]
        [HttpGet("rewards/{rewardId}")]
        public async Task<IActionResult> GetReward(int rewardId)
        {
            var reward = await _service.GetRewardByIdAsync(rewardId);
            return reward == null ? NotFound() : Ok(reward);
        }

        [Authorize(Roles = "Admin,Teacher")]
        [HttpPost("rewards")]
        public async Task<IActionResult> CreateReward([FromBody] CreateRewardOrDisciplineDto dto)
        {
            if (!ModelState.IsValid) return BadRequest();
            var reward = await _service.CreateRewardAsync(dto);
            return CreatedAtAction(nameof(GetReward), new { rewardId = reward.RewardId }, reward);
        }

        //--- Disciplines ---
        [HttpGet("disciplines")]
        public async Task<IActionResult> GetAllDisciplines() => Ok(await _service.GetAllDisciplinesAsync());

        [HttpGet("disciplines/{disciplineId}")]
        public async Task<IActionResult> GetDiscipline(int disciplineId)
        {
            var discipline = await _service.GetDisciplineByIdAsync(disciplineId);
            return discipline == null ? NotFound() : Ok(discipline);
        }

        [HttpPost("disciplines")]
        public async Task<IActionResult> CreateDiscipline([FromBody] CreateRewardOrDisciplineDto dto)
        {
            if (!ModelState.IsValid) return BadRequest();
            var discipline = await _service.CreateDisciplineAsync(dto);
            return CreatedAtAction(nameof(GetDiscipline), new { disciplineId = discipline.DisciplineId }, discipline);
        }
    }
}