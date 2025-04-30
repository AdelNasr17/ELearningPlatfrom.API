

using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    public class Course:BaseEntity
    {
        [Required]
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Price { get; set; }
        public string? ThumbnailUrl { get; set; }
        public bool HasCertificate { get; set; } = false;
        public bool IsPublished { get; set; }=false;
        public Guid TeacherId { get; set; } = default!;//FK (Users)

        //Navigations 
        public User Teacher { get; set; } = null!;
        public ICollection<Video> Videos { get; set; }=[];
        public ICollection<Enrollment> Enrollments { get; set; } = [];
        public ICollection<Exam> Exams { get; set; } = [];
        public ICollection<Coupon> Coupons { get; set; } = [];
        
    }
}
