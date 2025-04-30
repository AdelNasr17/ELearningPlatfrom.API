

using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    public class VideoProgress:BaseEntity
    {
        [Range(0.0,100.0)]
        public double ProgressPercent { get; set; }
        public bool IsCompleted { get; set; }=false;
        public DateTime LastWatchedDate { get; set; } = DateTime.UtcNow;
        public int WatchCount { get; set; }
        public Guid StudentId { get; set; }//Fk(Users)
        public Guid VideoId { get; set; }//FK(Video)

        //Navigations 
        public User student { get; set; } = null!;
        public Video Video { get; set; } = null!;


    }
}
