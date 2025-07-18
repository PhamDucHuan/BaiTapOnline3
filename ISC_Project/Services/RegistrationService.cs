using ISC_Project.Data;
using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ISC_Project.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly ISC_ProjectDbContext _context;

        public RegistrationService(ISC_ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Registration>> GetRegistrationsAsync()
        {
            return await _context.Registrations.Include(r => r.CourseOfferings).ToListAsync();
        }

        public async Task<Registration> RegisterStudentAsync(Registration registration)
        {
            _context.Registrations.Add(registration);
            await _context.SaveChangesAsync();
            return registration;
        }
    }
}
