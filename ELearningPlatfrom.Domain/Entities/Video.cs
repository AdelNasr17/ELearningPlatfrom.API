

using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    public class Video : BaseEntity
    {
        [Required(ErrorMessage = "Title is required.")] // Indicates that the Title field is required
        public string Title { get; set; } = default!; // Title of the video

        [Required(ErrorMessage = "URL is required.")] // Indicates that the Url field is required
        [Url(ErrorMessage = "Invalid URL format.")] // Validates that the Url field contains a valid URL format
        public string Url { get; set; } = default!; // URL of the video

        public int ViewCount { get; set; } // Number of times the video has been viewed

        [Required(ErrorMessage = "Duration in seconds is required.")] // Indicates that the DurationInSeconds field is required
        public int DurationInSeconds { get; set; } // Duration of the video in seconds

        public int MaxUsageCount { get; set; } = 10; // Maximum number of times the video can be used

        public bool IsPreview { get; set; } = false; // Indicates if the video is a preview

        public bool IsPublished { get; set; } = false; // Indicates if the video is published and available to users

        public Guid CourseId { get; set; } // Foreign key referencing the Course

        // Navigation properties
        public Course Course { get; set; } = null!; // The course associated with the video
        public ICollection<VideoProgress> VideoProgresses { get; set; } = []; // Progress records for users watching the video
    }
}
