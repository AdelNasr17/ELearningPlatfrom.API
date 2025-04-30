

namespace ELearningPlatfrom.Domain.Entities
{
    public class Coupon:BaseEntity
    {
        public string Code { get; set; } = default!;
        public decimal DiscountPercent { get; set; }
        public DateTime ExpiryDate { get; set; }
        public  bool IsActive { get; set; }
        public int MaxUsageCount { get; set; } = 1;
        public int UsedCount { get; set; } = 1;

        public Guid? CourseId { get; set; }//FK(Courses)

        //Navigations 
        public Course Course { get; set; } = null!;
    }
}
