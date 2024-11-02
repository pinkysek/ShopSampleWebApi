using System.ComponentModel.DataAnnotations;

namespace ShopSampleWebApi.Core.DataTransferObjects
{
    public class ProductDto
    {
        [Required]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Url(ErrorMessage = "Please enter a valid URL.")]
        public string ImgUri { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string? Description { get; set; }
    }
}
