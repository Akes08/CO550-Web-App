using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ExampleBlazorApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; } = 0;

        [StringLength(60), Required]
        public string Name { get; set; } = String.Empty;

        [StringLength(255)]
        public string? Description { get; set; } = String.Empty;

        [Range(0, 100.00)]
        public decimal Price { get; set; } = 0;
    }
}
