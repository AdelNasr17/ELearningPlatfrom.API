
namespace ELearningPlatfrom.Domain.Entities
{
    public class Exam:BaseEntity
    {
        public string Title { get; set; } = default!;
        public int DurationInMinutes {  get; set; }
        public DateTime AvailableFrom { get; set; }
        public DateTime AvailableTo { get; set; }
        public bool IsPublished { get; set; } = false;

        public Guid CourseId { get; set; }//Fk(Courses)

        //Navigations 
        public Course Course { get; set; } = null!;
        public ICollection<Question> Questions { get; set; } = [];

    }
}
