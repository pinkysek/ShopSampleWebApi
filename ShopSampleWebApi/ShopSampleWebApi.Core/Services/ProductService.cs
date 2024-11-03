using AutoMapper;
using Microsoft.Extensions.Logging;
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

        public ProductService(IProductRepository productRepository, IMapper mapper, ILogger<ProductService> logger) : base(productRepository, mapper, logger)
        {
            _productRepository = productRepository;
        }

        public async Task<bool> UpdateDescriptionAsync(long id, string? description)
        {
            _logger.LogInformation($"Starting UpdateDescriptionAsync for Product with ID {id}.");

            try
            {
                var product = await _productRepository.GetByIdAsync(id);
                if (product == null)
                {
                    _logger.LogWarning($"Product with ID {id} is not found.");
                    return false;
                }
                
                _logger.LogInformation($"Updating description for Product with ID {id}.");

                product.Description = description;
                await _productRepository.UpdateAsync(product);

                _logger.LogInformation($"Successfully updated description for Product with ID {id}.");

                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"An error occurred while updating the description for Product with ID {id}.");
                throw;
            }
        }
    }
}
