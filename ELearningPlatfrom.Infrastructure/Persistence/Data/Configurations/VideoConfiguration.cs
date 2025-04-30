

using ELearningPlatfrom.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearningPlatfrom.Infrastructure.Persistence.Data.Configurations
{
    public class VideoConfiguration : IEntityTypeConfiguration<Video>
    {
        public void Configure(EntityTypeBuilder<Video> builder)
        {
            // Configures a one-to-many relationship between Video and VideoProgress
            builder.HasMany(v => v.VideoProgresses) // A Video can have many VideoProgress records
                   .WithOne(vp => vp.Video) // Each VideoProgress has one Video
                   .HasForeignKey(vp => vp.VideoId) // Foreign key in VideoProgress referencing Video
                   .OnDelete(DeleteBehavior.Cascade); // Deletes related VideoProgress records if Video is deleted
        }
    }
}
