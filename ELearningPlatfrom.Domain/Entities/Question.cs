
namespace ELearningPlatfrom.Domain.Entities
{
    public class Question:BaseEntity
    {
        public string Text { get; set; } = default!;
        public string QuestionType { get; set; } = default!;//MCQ - TrueFalse - Text
        public string CorrectAnswer { get; set; } = default!;
        public int Points { get; set; }

        public Guid ExamId { get; set; }//FK(Exams)

        //Navigations 

        public Exam Exam { get; set; } = null!; 
    }
}
