

using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    public class VideoProgress : BaseEntity
    {
        [Range(0.0, 100.0, ErrorMessage = "Progress percent must be between 0 and 100.")] // Validates that ProgressPercent is between 0 and 100
        public double ProgressPercent { get; set; } // Percentage of the video watched

        public bool IsCompleted { get; set; } = false; // Indicates if the video has been fully watched

        public DateTime LastWatchedDate { get; set; } = DateTime.UtcNow; // Date and time when the video was last watched

        public int WatchCount { get; set; } // Number of times the video has been watched

        public Guid StudentId { get; set; } // Foreign key referencing the Student (User )

        public Guid VideoId { get; set; } // Foreign key referencing the Video

        // Navigation properties
        public User Student { get; set; } = null!; // The student associated with the video progress
        public Video Video { get; set; } = null!; // The video associated with the progress record
    }
}
