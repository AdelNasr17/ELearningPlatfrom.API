

using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    public class ExamResult:BaseEntity
    {
        [Range(0,100)]
        public decimal Score { get; set; }
        public DateTime SubmissionDate= DateTime.UtcNow;
        public int AttemptNumber { get; set; } = 1;
        public bool IsPassed { get; set; }

        public Guid EnrollmentId { get; set; }//FK(Enrollment)
        public Guid ExamId { get; set; }//FK(Exam)

        //Navigation 
        public Enrollment Enrollment { get; set; } = null!;
        public Exam Exam { get; set; }= null!;
    }
}
