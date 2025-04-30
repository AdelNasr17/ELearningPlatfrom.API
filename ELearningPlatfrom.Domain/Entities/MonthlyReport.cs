

using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    public class MonthlyReport:BaseEntity
    {
        [Range(1,12)]
        public int Month { get; set; }
        public int Year { get; set; }
        public int NewStudentsCount { get; set; }
        public decimal TotalEarnings { get; set; }
        public bool IsSentToTeacher { get; set; }=false;

        public Guid TeacherId { get; set; }//FK(Users)

        public User Teacher { get; set; } = null!;
    }
}
