using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ISC_Project.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationsController : ControllerBase
    {
        private readonly IRegistrationService _registrationService;

        public RegistrationsController(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Registration>>> GetRegistrations()
        {
            var registrations = await _registrationService.GetRegistrationsAsync();
            return Ok(registrations);
        }

        [HttpPost]
        public async Task<ActionResult<Registration>> RegisterStudent(Registration registration)
        {
            var createdRegistration = await _registrationService.RegisterStudentAsync(registration);
            return CreatedAtAction(nameof(GetRegistrations), new { id = createdRegistration.RegistrationsId }, createdRegistration);
        }
    }
}
