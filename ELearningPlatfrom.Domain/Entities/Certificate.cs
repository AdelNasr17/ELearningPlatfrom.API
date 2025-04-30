
using ELearningPlatfrom.Domain.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    [Index(nameof(VerificationCode), IsUnique = true)] // Index attribute to ensure the VerificationCode field is unique in the database
    public class Certificate : BaseEntity
    {
        [Required(ErrorMessage = "Certificate URL is required.")] // Indicates that the CertificateUrl field is required
        public string CertificateUrl { get; set; } = default!; // URL where the certificate can be accessed

        public Level Level { get; set; } = default!; // Level of achievement (e.g., Ex, VG, G, P, F)

        [Required(ErrorMessage = "Verification code is required.")] // Indicates that the VerificationCode field is required
        public string VerificationCode { get; set; } = default!; // Unique verification code for the certificate

        public string VerificationUrl { get; set; } = default!; // URL for verifying the certificate

        public string? QRCodeUrl { get; set; } = default!; // URL for the QR code associated with the certificate (nullable)

        public DateTime IssueDate { get; set; } = DateTime.UtcNow; // Date when the certificate was issued

        public Guid EnrollmentId { get; set; } // Foreign key referencing the Enrollment

        // Navigation properties
        public Enrollment Enrollment { get; set; } = null!; // The enrollment associated with the certificate
    }
}
