using ShopSampleWebApi.Core.DataTransferObjects;
using ShopSampleWebApi.Core.Interfaces.Base;
using ShopSampleWebApi.DataAccess.Models;

namespace ShopSampleWebApi.Core.Interfaces
{
    /// <summary>
    /// Interface for product service operations.
    /// </summary>
    public interface IProductService : IBaseService<Product, ProductDto>
    {

        /// <summary>
        /// Updates the description of a product.
        /// </summary>
        /// <param name="id">The product identifier.</param>
        /// <param name="description">The new description.</param>
        /// <returns>A task that represents the asynchronous operation. The task result indicates whether the update was successful.</returns>
        Task<bool> UpdateDescriptionAsync(long id, string? description);
    }
}
