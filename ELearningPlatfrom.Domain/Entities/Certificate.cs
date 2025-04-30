
using ELearningPlatfrom.Domain.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    [Index(nameof(VerificationCode), IsUnique = true)]
    public class Certificate:BaseEntity
    {
        [Required]
        public string CertificateUrl { get; set; } = default!;

        public Level Level { get; set; } = default!; // Ex,VG,G,P,F
        [Required]
        public string VerificationCode { get; set; } = default!;//Unique
        public string VerificationUrl { get; set; } = default!;
        public string? QRCodeUrl { get; set; } = default!;
        public DateTime IssueDate { get; set; }=DateTime.UtcNow;

        public Guid EnrollmentId  { get; set; }//FK(Enrollment)
        //Navigations 
        public Enrollment Enrollment { get; set; } = null!;
    }
}
