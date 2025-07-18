using ISC_Project.Models;

namespace ISC_Project.Interface
{
    public interface IClassSubjectService
    {
        Task<IEnumerable<Class>> GetAllClassesAsync();
        Task<IEnumerable<Subject>> GetAllSubjectsAsync();
        Task<IEnumerable<Subject>> GetSubjectsByClassIdAsync(int classId);
        Task AssignSubjectToClassAsync(int? subjectsId, int? classId);
    }
}
