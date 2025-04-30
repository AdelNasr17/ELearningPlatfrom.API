

using ELearningPlatfrom.Domain.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    [Index(nameof(Email),IsUnique =true)]
    public class User:BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = default!;
        [Required]
        [EmailAddress]
        
        public string Email { get; set; } = default!; //Unique 
        [Required,StringLength(15)]
        [Phone]
        public string PhoneNumber { get; set; } = default!;
        [Required]
        
        public string PasswordHash { get; set; } = default!;
        public Role Role { get; set; } = default!;//Student - Teacher - Admin 
        public string? ProfileImageUrl { get; set; } 
        
        //Navigations 
        public ICollection<Course> Courses { get; set; } = [];
        public ICollection<Enrollment> Enrollments  { get; set; } = [];
        public ICollection<VideoProgress> VideoProgresses  { get; set; } = [];
        public ICollection<MonthlyReport> MonthlyReports  { get; set; } = [];



    }
}
