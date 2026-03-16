using Microsoft.EntityFrameworkCore;
using StudentManagementAPI.Models;

namespace StudentManagementAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; } // New
        public DbSet<Course> Courses { get; set; }       // New
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}