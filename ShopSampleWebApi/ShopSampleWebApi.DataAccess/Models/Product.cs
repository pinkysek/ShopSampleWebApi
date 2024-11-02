using Microsoft.EntityFrameworkCore;
using ShopSampleWebApi.DataAccess.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace ShopSampleWebApi.DataAccess.Models
{
    /// <summary>
    /// Represents a product in the shop.
    /// </summary>
    public class Product : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the image URI of the product.
        /// </summary>
        [Required]
        public string ImgUri { get; set; }

        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        [Required]
        [Precision(18, 2)]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the description of the product.
        /// </summary>
        public string? Description { get; set; }
    }
}
