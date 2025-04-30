
using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    public class Exam : BaseEntity
    {
        [Required(ErrorMessage = "Title is required.")] // Indicates that the Title field is required
        public string Title { get; set; } = default!; // Title of the exam

        [Required(ErrorMessage = "Duration in minutes is required.")] // Indicates that the DurationInMinutes field is required
        public int DurationInMinutes { get; set; } // Duration of the exam in minutes

        public double PassingScore { get; set; } // Minimum score required to pass the exam

        public int MaxAttempts { get; set; } = 2; // Maximum number of attempts allowed for the exam

        public DateTime AvailableFrom { get; set; } // Date and time when the exam becomes available

        public DateTime AvailableTo { get; set; } // Date and time when the exam is no longer available

        public bool IsPublished { get; set; } = false; // Indicates if the exam is published and available to students

        public bool ShuffleQuestion { get; set; } // Indicates if the questions should be shuffled for each attempt

        public Guid CourseId { get; set; } // Foreign key referencing the Course

        // Navigation properties
        public Course Course { get; set; } = null!; // The course associated with the exam
        public ICollection<Question> Questions { get; set; } = []; // Questions associated with the exam
        public ICollection<ExamResult> ExamResults { get; set; } = []; // Results of the exam attempts
    }
}
