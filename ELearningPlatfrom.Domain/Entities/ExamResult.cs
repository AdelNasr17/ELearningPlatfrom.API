

using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    public class ExamResult : BaseEntity
    {
        [Range(0, 100, ErrorMessage = "Score must be between 0 and 100.")] // Validates that Score is between 0 and 100
        public decimal Score { get; set; } // Score obtained in the exam

        public DateTime SubmissionDate { get; set; } = DateTime.UtcNow; // Date and time when the exam was submitted

        public int AttemptNumber { get; set; } = 1; // The attempt number for the exam

        public bool IsPassed { get; set; } // Indicates if the exam was passed

        public Guid EnrollmentId { get; set; } // Foreign key referencing the Enrollment

        public Guid ExamId { get; set; } // Foreign key referencing the Exam

        // Navigation properties
        public Enrollment Enrollment { get; set; } = null!; // The enrollment associated with the exam result
        public Exam Exam { get; set; } = null!; // The exam associated with the result
    }
}
