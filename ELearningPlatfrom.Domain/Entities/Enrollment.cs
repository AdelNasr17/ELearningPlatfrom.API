

using ELearningPlatfrom.Domain.Entities.Shared;

namespace ELearningPlatfrom.Domain.Entities
{
    public class Enrollment:BaseEntity
    {
        public DateTime EnrollmentDate { get; set; }=DateTime.UtcNow;
        public PaymentStatus PaymentStatus { get; set; } = default!;//Pending - Paid - Failed
        public decimal? PaymentAmount { get; set; }
        public DateTime? CompletionDate { get; set; }
        public decimal? FinalScore { get; set; }
        public string? FeedBack {  get; set; }
        public Guid StudentId { get; set; }//Fk(Users)
        public Guid CourseId { get; set; }//Fk(Courses)

        //Navigations 
        public Course Course { get; set; } = null!;
        public User Student { get; set; } = null!;
        public Certificate Certificate { get; set; } = null!;
    }
}
