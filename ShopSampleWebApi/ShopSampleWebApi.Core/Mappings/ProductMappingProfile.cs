using AutoMapper;
using ShopSampleWebApi.Core.DataTransferObjects;
using ShopSampleWebApi.DataAccess.Models;

namespace ShopSampleWebApi.Core.Mappings
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            // Define mapping between Product and ProductDto.
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
        }
    }
}
