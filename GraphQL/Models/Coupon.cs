using System.ComponentModel.DataAnnotations;

namespace GraphQL.Models
{
    public class Coupon
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Code { get; set; }
        [Required]
        public string? CategoryName { get; set; }
        [Required]
        public int ExternalCategoryId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public float Amount { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime Expiry { get; set; }

        public Category? Category { get; set; }
    }
}
