using System.ComponentModel.DataAnnotations;

namespace ShopSampleWebApi.Core.DataTransferObjects
{
    /// <summary>
    /// Data Transfer Object for Product.
    /// </summary>
    public class ProductDto
    {
        /// <summary>
        /// Gets or sets the product ID.
        /// </summary>
        [Required]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the product name.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the image URI of the product.
        /// </summary>
        [Required]
        [Url(ErrorMessage = "Please enter a valid URL.")]
        public string ImgUri { get; set; }

        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the description of the product.
        /// </summary>
        public string? Description { get; set; }
    }
}
