using AutoMapper;
using ShopSampleWebApi.Core.DataTransferObjects;
using ShopSampleWebApi.Core.Interfaces;
using ShopSampleWebApi.Core.Services.Base;
using ShopSampleWebApi.DataAccess.Interfaces;
using ShopSampleWebApi.DataAccess.Models;

namespace ShopSampleWebApi.Core.Services
{
    /// <summary>
    /// Service for managing products.
    /// </summary>
    public class ProductService : BaseService<Product, ProductDto>, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository, IMapper mapper) : base(productRepository, mapper)
        {
            _productRepository = productRepository;
        }

        public async Task<bool> UpdateDescriptionAsync(long id, string? description)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null) 
                return false;

            product.Description = description;
            await _productRepository.UpdateAsync(product);
            return true;
        }
    }
}
