
using ELearningPlatfrom.Domain.Entities.Shared;
using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    public class Question : BaseEntity
    {
        [Required(ErrorMessage = "Question text is required.")] // Indicates that the Text field is required
        public string Text { get; set; } = default!; // The text of the question

        public QuestionType QuestionType { get; set; } = default!; // Type of the question (e.g., MCQ, True/False, Text)

        [Required(ErrorMessage = "Correct answer is required.")] // Indicates that the CorrectAnswer field is required
        public string CorrectAnswer { get; set; } = default!; // The correct answer for the question

        public int Points { get; set; } = 1; // Points awarded for answering the question correctly

        public Guid ExamId { get; set; } // Foreign key referencing the Exam

        // Navigation properties
        public Exam Exam { get; set; } = null!; // The exam associated with the question
    }
}
