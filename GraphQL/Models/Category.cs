using System.ComponentModel.DataAnnotations;

namespace GraphQL.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ExternalId { get; set; }
        [Required]
        public string? CategoryName { get; set; }

        public ICollection<Coupon> Coupons { get; set; } = new List<Coupon>();
    }
}
