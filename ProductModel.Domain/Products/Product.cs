using System.ComponentModel.DataAnnotations;

namespace ProductModel.Domain.Products
{
    public class Product
    {
        /// <summary>
        /// Unique identifier for the product.
        /// </summary>
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(200)]    
        public string Description { get; set; } = string.Empty;
        [Range(0.01, 10000.00, ErrorMessage = "Price must be between 0.01 and 10000.00")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}