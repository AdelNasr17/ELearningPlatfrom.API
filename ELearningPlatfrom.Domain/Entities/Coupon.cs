

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    [Index(nameof(Code), IsUnique = true)]
    public class Coupon:BaseEntity
    {
        [Required]
        public string Code { get; set; } = default!;// //Unique
        [Required]
        public decimal DiscountPercent { get; set; }
        public string CreateBy { get; set; }= default!;
        [Required]
        public DateTime ExpiryDate { get; set; }
        public  bool IsActive { get; set; }
        public int MaxUsageCount { get; set; } = 1;
        public int UsedCount { get; set; } = 1;

        public Guid? CourseId { get; set; }//FK(Courses)

        //Navigations 
        public Course Course { get; set; } = null!;
    }
}
