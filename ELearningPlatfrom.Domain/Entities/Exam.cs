
using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    public class Exam:BaseEntity
    {
        [Required]
        public string Title { get; set; } = default!;
        [Required]
        public int DurationInMinutes {  get; set; }
        public double PassingScore { get; set; }
        public int MaxAttempts { get; set; } = 2;
        public DateTime AvailableFrom { get; set; }
        public DateTime AvailableTo { get; set; }
        public bool IsPublished { get; set; } = false;
        public bool ShuffleQuestion { get; set; }

        public Guid CourseId { get; set; }//Fk(Courses)

        //Navigations 
        public Course Course { get; set; } = null!;
        public ICollection<Question> Questions { get; set; } = [];

    }
}
