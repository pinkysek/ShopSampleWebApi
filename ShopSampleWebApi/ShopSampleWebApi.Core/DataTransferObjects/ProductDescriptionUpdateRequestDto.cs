using Swashbuckle.AspNetCore.Annotations;

namespace ShopSampleWebApi.Core.DataTransferObjects
{
    /// <summary>  
    /// Data Transfer Object for updating product description.  
    /// </summary>  
    [SwaggerSchema(Description = "Data Transfer Object for updating product description.")]
    public class ProductDescriptionUpdateRequestDto
    {
        /// <summary>  
        /// Gets or sets the product description.  
        /// </summary>  
        [SwaggerSchema(Description = "The product description.")]
        public string? Description { get; set; }
    }
}
