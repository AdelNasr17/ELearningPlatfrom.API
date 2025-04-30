

using ELearningPlatfrom.Domain.Entities.Shared;
using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    public class User:BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = default!;
        [Required]
        public string Email { get; set; } = default!; //Unique 
        [Required,StringLength(15)]
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
