using ISC_Project.Models;

namespace ISC_Project.Interface
{
    public interface IRegistrationService
    {
        Task<IEnumerable<Registration>> GetRegistrationsAsync();
        Task<Registration> RegisterStudentAsync(Registration registration);
    }
}
