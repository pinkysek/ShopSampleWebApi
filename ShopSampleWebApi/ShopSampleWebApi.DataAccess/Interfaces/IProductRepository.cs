using ShopSampleWebApi.DataAccess.Interfaces.Base;
using ShopSampleWebApi.DataAccess.Models;

namespace ShopSampleWebApi.DataAccess.Interfaces
{
    // This interface defines the contract for a product repository, extending the base repository interface.
    // It inherits all CRUD operations from IBaseRepository and can include additional product-specific methods.
    public interface IProductRepository : IBaseRepository<Product>
    {
    }
}
