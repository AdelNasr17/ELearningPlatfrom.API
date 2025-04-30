

namespace ELearningPlatfrom.Domain.Entities
{
    public class Enrollment:BaseEntity
    {
        public DateTime EnrollmentDate { get; set; }
        public string PaymentStatus { get; set; } = default!;//Pending - Paid - Failed
        public decimal? PaymentAmount { get; set; }
        public Guid StudentId { get; set; }//Fk(Users)
        public Guid CourseId { get; set; }//Fk(Courses)

        //Navigations 
        public Course Course { get; set; } = null!;
        public User Student { get; set; } = null!;
        public Certificate Certificate { get; set; } = null!;
    }
}
