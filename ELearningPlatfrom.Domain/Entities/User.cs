

namespace ELearningPlatfrom.Domain.Entities
{
    public class User:BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PasswordHash { get; set; } = default!;
        public string Role { get; set; } = default!;//Student - Teacher - Admin 
        
        //Navigations 
        public ICollection<Course> Courses { get; set; } = [];
        public ICollection<Enrollment> Enrollments  { get; set; } = [];
        public ICollection<VideoProgress> VideoProgresses  { get; set; } = [];
        public ICollection<MonthlyReport> MonthlyReports  { get; set; } = [];



    }
}
