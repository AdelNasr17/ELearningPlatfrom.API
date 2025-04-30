

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ELearningPlatfrom.Domain.Entities
{
    [Index(nameof(Code), IsUnique = true)] // Index attribute to ensure the Code field is unique in the database
    public class Coupon : BaseEntity
    {
        [Required(ErrorMessage = "Code is required.")] // Indicates that the Code field is required
        public string Code { get; set; } = default!; // Unique code for the coupon

        [Required(ErrorMessage = "Discount percent is required.")] // Indicates that the DiscountPercent field is required
        [Range(0, 100, ErrorMessage = "Discount percent must be between 0 and 100.")] // Validates that DiscountPercent is between 0 and 100
        public decimal DiscountPercent { get; set; } // Discount percentage provided by the coupon

        [Required(ErrorMessage = "Created by is required.")] // Indicates that the CreateBy field is required
        public string CreateBy { get; set; } = default!; // The user who created the coupon

        [Required(ErrorMessage = "Expiry date is required.")] // Indicates that the ExpiryDate field is required
        public DateTime ExpiryDate { get; set; } // Expiry date of the coupon

        public bool IsActive { get; set; } = true; // Indicates if the coupon is active

        public int MaxUsageCount { get; set; } = 1; // Maximum number of times the coupon can be used

        public int UsedCount { get; set; } = 0; // Number of times the coupon has been used

        public Guid? CourseId { get; set; } // Foreign key referencing the Course (nullable)

        // Navigation properties
        public Course Course { get; set; } = null!; // The course associated with the coupon
    }
}
