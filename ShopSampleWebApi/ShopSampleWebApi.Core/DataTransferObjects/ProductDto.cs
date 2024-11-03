using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace ShopSampleWebApi.Core.DataTransferObjects
{
    /// <summary>
    /// Data Transfer Object for Product.
    /// </summary>
    [SwaggerSchema(Description = "Data Transfer Object for Product.")]
    public class ProductDto
    {
        /// <summary>
        /// Gets or sets the product ID.
        /// </summary>
        [Required(ErrorMessage = "ID is required.")]
        [SwaggerSchema("The unique identifier of the product.")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the product name.
        /// </summary>
        [Required(ErrorMessage = "Name is required.")]
        [SwaggerSchema("The name of the product.")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the image URI of the product.
        /// </summary>
        [Required(ErrorMessage = "Image URI is required.")]
        [Url(ErrorMessage = "Please enter a valid URL.")]
        [SwaggerSchema("The image URI of the product.")]
        public string ImgUri { get; set; }

        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        [Required(ErrorMessage = "Price is required.")]
        [SwaggerSchema("The price of the product.", Format = "decimal")]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the description of the product.
        /// </summary>
        [SwaggerSchema("The description of the product.", Nullable = true)]
        public string? Description { get; set; }
    }
}
