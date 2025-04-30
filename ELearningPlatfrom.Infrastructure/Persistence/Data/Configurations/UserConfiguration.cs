

using ELearningPlatfrom.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearningPlatfrom.Infrastructure.Persistence.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Configures a one-to-many relationship between User and Course
            builder.HasMany(u => u.Courses) // A User can have many Courses
                   .WithOne(c => c.Teacher) // Each Course has one Teacher
                   .HasForeignKey(c => c.TeacherId) // Foreign key in Course referencing User
                   .OnDelete(DeleteBehavior.Restrict); // Prevents deletion of User if there are related Courses

            // Configures a one-to-many relationship between User and Enrollment
            builder.HasMany(u => u.Enrollments) // A User can have many Enrollments
                   .WithOne(en => en.Student) // Each Enrollment has one Student
                   .HasForeignKey(en => en.StudentId) // Foreign key in Enrollment referencing User
                   .OnDelete(DeleteBehavior.Cascade); // Deletes related Enrollments if User is deleted

            // Configures a one-to-many relationship between User and VideoProgress
            builder.HasMany(u => u.VideoProgresses) // A User can have many VideoProgress records
                   .WithOne(vp => vp.Student) // Each VideoProgress has one Student
                   .HasForeignKey(vp => vp.StudentId) // Foreign key in VideoProgress referencing User
                   .OnDelete(DeleteBehavior.Cascade); // Deletes related VideoProgress records if User is deleted

            // Configures a one-to-many relationship between User and MonthlyReport
            builder.HasMany(u => u.MonthlyReports) // A User can have many MonthlyReports
                   .WithOne(mr => mr.Teacher) // Each MonthlyReport has one Teacher
                   .HasForeignKey(mr => mr.TeacherId) // Foreign key in MonthlyReport referencing User
                   .OnDelete(DeleteBehavior.Cascade); // Deletes related MonthlyReports if User is deleted
        }
    }
}
