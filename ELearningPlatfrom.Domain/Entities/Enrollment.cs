

using ELearningPlatfrom.Domain.Entities.Shared;

namespace ELearningPlatfrom.Domain.Entities
{
    public class Enrollment : BaseEntity
    {
        public DateTime EnrollmentDate { get; set; } = DateTime.UtcNow; // Date when the enrollment was made

        public PaymentStatus PaymentStatus { get; set; } = default!; // Status of the payment (e.g., Pending, Paid, Failed)

        public decimal? PaymentAmount { get; set; } // Amount paid for the enrollment (nullable)

        public string? FeedBack { get; set; } // Feedback provided by the student (nullable)

        public Guid StudentId { get; set; } // Foreign key referencing the Student (User )

        public Guid CourseId { get; set; } // Foreign key referencing the Course

        // Navigation properties
        public Course Course { get; set; } = null!; // The course associated with the enrollment
        public User Student { get; set; } = null!; // The student associated with the enrollment
        public Certificate Certificate { get; set; } = null!; // The certificate associated with the enrollment
        public ICollection<ExamResult> ExamResults { get; set; } = []; // Results of exams taken by the student in this enrollment
    }
}
