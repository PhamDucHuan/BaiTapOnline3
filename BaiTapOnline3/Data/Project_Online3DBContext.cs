using BaiTapOnline3.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiTapOnline3.Data
{
    public class Project_Online3DBContext : DbContext
    {
        public Project_Online3DBContext(DbContextOptions<Project_Online3DBContext> options) : base(options) { }

        public DbSet<Intern> Interns { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<AllowAccess> AllowAccesses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Dòng này sẽ chỉ định schema mặc định cho tất cả các bảng
            modelBuilder.HasDefaultSchema("ProjectOnline3");
        }
    }
}
