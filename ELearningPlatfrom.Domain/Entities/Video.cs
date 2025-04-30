

namespace ELearningPlatfrom.Domain.Entities
{
    public class Video:BaseEntity
    {
        public string Title { get; set; } = default!;
        public string Url { get; set; } = default!;
        public int DurationInSeconds { get; set; }
        public int MaxUsageCount { get; set; }
        public bool IsPublished { get; set; } = false;

        public Guid CourseId { get; set; }// Fk(Courses)

        //Navigations 
        public Course Course { get; set; } = null!;
        public ICollection<VideoProgress> VideoProgresses { get; set; } = [];
    }
}
