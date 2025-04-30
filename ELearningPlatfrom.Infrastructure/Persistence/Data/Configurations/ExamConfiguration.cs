using ELearningPlatfrom.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace ELearningPlatfrom.Infrastructure.Persistence.Data.Configurations
{
    public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            // Configures a one-to-many relationship between Exam and Question
            builder.HasMany(e => e.Questions) // An Exam can have many Questions
                   .WithOne(q => q.Exam) // Each Question has one Exam
                   .HasForeignKey(q => q.ExamId) // Foreign key in Question referencing Exam
                   .OnDelete(DeleteBehavior.Cascade); // Deletes related Questions if Exam is deleted

            // Configures a one-to-many relationship between Exam and ExamResult
            builder.HasMany(e => e.ExamResults) // An Exam can have many ExamResults
                   .WithOne(er => er.Exam) // Each ExamResult has one Exam
                   .HasForeignKey(er => er.ExamId) // Foreign key in ExamResult referencing Exam
                   .OnDelete(DeleteBehavior.Cascade); // Deletes related ExamResults if Exam is deleted
        }
    }
}
