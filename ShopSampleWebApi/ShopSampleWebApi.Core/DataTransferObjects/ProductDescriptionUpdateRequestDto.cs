namespace ShopSampleWebApi.Core.DataTransferObjects
{
    /// <summary>  
    /// Data Transfer Object for updating product description.  
    /// </summary>  
    public class ProductDescriptionUpdateRequestDto
    {
        /// <summary>  
        /// Gets or sets the product description.  
        /// </summary>  
        public string? Description { get; set; }
    }
}
