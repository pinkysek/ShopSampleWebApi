using ShopSampleWebApi.DataAccess.Interfaces;
using ShopSampleWebApi.DataAccess.Models;
using ShopSampleWebApi.DataAccess.Repositories.Base;

namespace ShopSampleWebApi.DataAccess.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
