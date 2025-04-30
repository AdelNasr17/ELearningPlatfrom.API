

using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    public class Course : BaseEntity
    {
        [Required(ErrorMessage = "Title is required.")] // Indicates that the Title field is required
        public string Title { get; set; } = default!; // Title of the course

        public string Description { get; set; } = default!; // Description of the course

        public decimal Price { get; set; } // Price of the course

        [Url(ErrorMessage = "Invalid URL format.")] // Validates that the ThumbnailUrl field contains a valid URL format
        public string? ThumbnailUrl { get; set; } // URL for the course thumbnail image

        public bool HasCertificate { get; set; } = false; // Indicates if the course provides a certificate upon completion

        public bool IsPublished { get; set; } = false; // Indicates if the course is published and available to students

        public Guid TeacherId { get; set; } = default!; // Foreign key referencing the Teacher (User )

        // Navigation properties
        public User Teacher { get; set; } = null!; // The teacher associated with the course
        public ICollection<Video> Videos { get; set; } = []; // Videos associated with the course
        public ICollection<Enrollment> Enrollments { get; set; } = []; // Enrollments associated with the course
        public ICollection<Exam> Exams { get; set; } = []; // Exams associated with the course
        public ICollection<Coupon> Coupons { get; set; } = []; // Coupons associated with the course
    }
}
