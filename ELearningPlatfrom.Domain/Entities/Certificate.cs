
namespace ELearningPlatfrom.Domain.Entities
{
    public class Certificate:BaseEntity
    {
        public string CertificateUrl { get; set; } = default!;
        public string Level { get; set; } = default!; // Ex,VG,G,P,F
        public string VerificationCode { get; set; } = default!;
        public DateTime IssueDate { get; set; }=DateTime.UtcNow;

        public Guid EnrollmentId  { get; set; }//FK(Enrollment)
        //Navigations 
        public Enrollment Enrollment { get; set; } = null!;
    }
}
