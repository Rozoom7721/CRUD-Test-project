using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace StoreProject.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100), Required]
        public string? Name { get; set; }

        [MaxLength(100)]
        public string? Brand { get; set; }

        [MaxLength(100)]
        public string? Category { get; set; }

        [Precision(16,2), Required]
        public Decimal Price { get; set; }


        public string? Description { get; set; }

        [MaxLength(100)]
        public string? ImageFileName { get; set; }


        public DateTime CreatedAt { get; set; }
    }
}
