

using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    public class Video:BaseEntity
    {
        [Required]
        public string Title { get; set; } = default!;
        [Required]
        public string Url { get; set; } = default!;
        public int ViewCount { get; set; }
        [Required]
        public int DurationInSeconds { get; set; }
        public int MaxUsageCount { get; set; } = 10;
        public bool IsPreview { get; set; }=false;
        public bool IsPublished { get; set; } = false;

        public Guid CourseId { get; set; }// Fk(Courses)

        //Navigations 
        public Course Course { get; set; } = null!;
        public ICollection<VideoProgress> VideoProgresses { get; set; } = [];
    }
}
