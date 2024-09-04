
using System.ComponentModel.DataAnnotations;

namespace StoreProject.Models
{
    public class ProductDto
    {

        [Required, MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(100)]
        public string? Brand { get; set; }

        [MaxLength(100)]
        public string? Category { get; set; }
        [Required]
        public Decimal Price { get; set; }


        public string? Description { get; set; }

        
        public IFormFile? ImageFile { get; set; }
    }
}
