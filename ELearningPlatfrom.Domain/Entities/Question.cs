
using ELearningPlatfrom.Domain.Entities.Shared;
using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    public class Question:BaseEntity
    {
        [Required]
        public string Text { get; set; } = default!;
        public QuestionType QuestionType { get; set; } = default!;//MCQ - TrueFalse - Text
        [Required]
        public string CorrectAnswer { get; set; } = default!;
        public int Points { get; set; } = 1;

        public Guid ExamId { get; set; }//FK(Exams)

        //Navigations 

        public Exam Exam { get; set; } = null!; 
    }
}
