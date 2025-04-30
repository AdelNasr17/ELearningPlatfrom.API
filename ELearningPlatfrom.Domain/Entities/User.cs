

using ELearningPlatfrom.Domain.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    [Index(nameof(Email), IsUnique = true)] // Index attribute to ensure the Email field is unique in the database
    public class User : BaseEntity
    {
        [Required(ErrorMessage = "Name is required.")] // Indicates that the Name field is required
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")] // Specifies the maximum length of the Name field
        public string Name { get; set; } = default!; // User's name

        [Required(ErrorMessage = "Email is required.")] // Indicates that the Email field is required
        [EmailAddress(ErrorMessage = "Invalid email format.")] // Validates that the Email field contains a valid email address format
        public string Email { get; set; } = default!; // User's email address, must be unique

        [Required(ErrorMessage = "Phone number is required.")] // Indicates that the PhoneNumber field is required
        [StringLength(15, ErrorMessage = "Phone number cannot exceed 15 characters.")] // Specifies the maximum length of the PhoneNumber field
        [Phone(ErrorMessage = "Invalid phone number format.")] // Validates that the PhoneNumber field contains a valid phone number format
        public string? PhoneNumber { get; set; } = default!; // User's phone number

        [Required(ErrorMessage = "Password is required.")] // Indicates that the PasswordHash field is required
        public string PasswordHash { get; set; } = default!; // Hashed password for user authentication

        [Required(ErrorMessage = "Role is required.")] // Indicates that the Role field is required
        public Role Role { get; set; } = default!; // User's role (e.g., Student, Teacher, Admin)

        [Url(ErrorMessage = "Invalid URL format.")] // Validates that the ProfileImageUrl field contains a valid URL format
        public string? ProfileImageUrl { get; set; } // URL for the user's profile image

        // Navigation properties for related entities
        public ICollection<Course> Courses { get; set; } = []; // Courses associated with the user
        public ICollection<Enrollment> Enrollments { get; set; } = []; // Enrollments associated with the user
        public ICollection<VideoProgress> VideoProgresses { get; set; } = []; // Video progress records for the user
        public ICollection<MonthlyReport> MonthlyReports { get; set; } = []; // Monthly reports associated with the user
    }
}
