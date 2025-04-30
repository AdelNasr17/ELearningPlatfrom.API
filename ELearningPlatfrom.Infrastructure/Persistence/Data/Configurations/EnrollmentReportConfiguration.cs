using ELearningPlatfrom.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearningPlatfrom.Infrastructure.Persistence.Data.Configurations
{
    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            // Configures a one-to-one relationship between Enrollment and Certificate
            builder.HasOne(en => en.Certificate) // An Enrollment has one Certificate
                   .WithOne(ce => ce.Enrollment) // Each Certificate has one Enrollment
                   .HasForeignKey<Certificate>(ce => ce.EnrollmentId); // Foreign key in Certificate referencing Enrollment

            // Configures a one-to-many relationship between Enrollment and ExamResult
            builder.HasMany(en => en.ExamResults) // An Enrollment can have many ExamResults
                   .WithOne(er => er.Enrollment) // Each ExamResult has one Enrollment
                   .HasForeignKey(er => er.EnrollmentId) // Foreign key in ExamResult referencing Enrollment
                   .OnDelete(DeleteBehavior.Cascade); // Deletes related ExamResults if Enrollment is deleted
        }
    }
}
