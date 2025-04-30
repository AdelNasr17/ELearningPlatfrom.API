

using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    public class MonthlyReport : BaseEntity
    {
        [Range(1, 12, ErrorMessage = "Month must be between 1 and 12.")] // Validates that Month is between 1 and 12
        public int Month { get; set; } // Month of the report (1 for January, 12 for December)

        public int Year { get; set; } // Year of the report

        public int NewStudentsCount { get; set; } // Number of new students enrolled in the month

        public decimal TotalEarnings { get; set; } // Total earnings for the month

        public bool IsSentToTeacher { get; set; } = false; // Indicates if the report has been sent to the teacher

        public Guid TeacherId { get; set; } // Foreign key referencing the Teacher (User )

        // Navigation properties
        public User Teacher { get; set; } = null!; // The teacher associated with the report
    }
}
