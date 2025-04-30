

using ELearningPlatfrom.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ELearningPlatfrom.Infrastructure.Persistence.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        // Constructor that accepts DbContextOptions and passes it to the base class
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Configures the model using the Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Applies configurations from the current assembly
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        // DbSet properties for each entity in the context
        public DbSet<Certificate> Certificates { get; set; } // Represents the Certificates table
        public DbSet<Coupon> Coupons { get; set; } // Represents the Coupons table
        public DbSet<Course> Courses { get; set; } // Represents the Courses table
        public DbSet<Enrollment> Enrollments { get; set; } // Represents the Enrollments table
        public DbSet<Exam> Exams { get; set; } // Represents the Exams table
        public DbSet<ExamResult> ExamResults { get; set; } // Represents the ExamResults table
        public DbSet<MonthlyReport> MonthlyReports { get; set; } // Represents the MonthlyReports table
        public DbSet<Question> Questions { get; set; } // Represents the Questions table
        public DbSet<User> Users { get; set; } // Represents the Users table
        public DbSet<Video> Videos { get; set; } // Represents the Videos table
        public DbSet<VideoProgress> VideoProgresses { get; set; } // Represents the VideoProgresses table
    }
}
