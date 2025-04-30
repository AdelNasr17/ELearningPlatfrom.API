

using ELearningPlatfrom.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearningPlatfrom.Infrastructure.Persistence.Data.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            // Configures a one-to-many relationship between Course and Video
            builder.HasMany(c => c.Videos) // A Course can have many Videos
                   .WithOne(v => v.Course) // Each Video has one Course
                   .HasForeignKey(v => v.CourseId) // Foreign key in Video referencing Course
                   .OnDelete(DeleteBehavior.Cascade); // Deletes related Videos if Course is deleted

            // Configures a one-to-many relationship between Course and Enrollment
            builder.HasMany(c => c.Enrollments) // A Course can have many Enrollments
                   .WithOne(en => en.Course) // Each Enrollment has one Course
                   .HasForeignKey(en => en.CourseId) // Foreign key in Enrollment referencing Course
                   .OnDelete(DeleteBehavior.NoAction); // Deletes related Enrollments if Course is deleted

            // Configures a one-to-many relationship between Course and Exam
            builder.HasMany(c => c.Exams) // A Course can have many Exams
                   .WithOne(e => e.Course) // Each Exam has one Course
                   .HasForeignKey(e => e.CourseId) // Foreign key in Exam referencing Course
                   .OnDelete(DeleteBehavior.Cascade); // Deletes related Exams if Course is deleted

            // Configures a one-to-many relationship between Course and Coupon
            builder.HasMany(c => c.Coupons) // A Course can have many Coupons
                   .WithOne(co => co.Course) // Each Coupon has one Course
                   .HasForeignKey(co => co.CourseId) // Foreign key in Coupon referencing Course
                   .OnDelete(DeleteBehavior.Cascade); // Deletes related Coupons if Course is deleted
        }
    }
}
