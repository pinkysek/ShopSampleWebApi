using Microsoft.EntityFrameworkCore;
using ShopSampleWebApi.DataAccess.Factories;
using ShopSampleWebApi.DataAccess.Models;
using ShopSampleWebApi.DataAccess.Repositories;
using ShopSampleWebApi.Helpers;
using Xunit;

namespace ShopSampleWebApi.DataAccess.Tests
{
    public class ProductRepositoryTests : IAsyncLifetime
    {
        private readonly ApplicationDbContext _context;
        private readonly ProductRepository _productRepository;

        public ProductRepositoryTests()
        {
            var databaseSettings = ConfigurationHelper.GetDatabaseSettings();

            // Set up the database based on the value from DatabaseSettings configuration.
            _context = DbContextFactory.CreateDbContext(
                databaseSettings.DatabaseType == "InMemory" ? DatabaseType.InMemory : DatabaseType.Real,
                databaseSettings.RealDatabaseConnectionString
            );
            _context = DbContextFactory.CreateDbContext(DatabaseType.InMemory);
            _productRepository = new ProductRepository(_context);
        }

        public Task InitializeAsync()
        {
            return Task.CompletedTask;
        }

        public Task DisposeAsync()
        {
            // Delete the database after each test (optional for InMemory).
            if (_context.Database.IsInMemory())
                _context.Database.EnsureDeleted();

            _context.Dispose();
            return Task.CompletedTask;
        }

        [Fact]
        public async Task AddAsync_ShouldAddProduct()
        {
            var product = new Product { Name = "TestProduct", ImgUri = "https://picsum.photos/g/200/200/?image=123", Price = 1000 };

            await _productRepository.AddAsync(product);

            var addedProduct = await _context.Products.FindAsync(product.Id);

            // Assert that the added product is not null.
            Assert.NotNull(addedProduct);
            // Assert that the name of the added product is "TestProduct".
            Assert.Equal("TestProduct", addedProduct.Name);
            // Assert that the image URI of the added product is not null.
            Assert.NotNull(addedProduct.ImgUri);
            // Assert that the price of the added product is 1000.
            Assert.Equal(1000, addedProduct.Price);
        }

        [Fact]
        public async Task GetAllAsync_ShouldReturnAllProducts()
        {
            var products = await _productRepository.GetAllAsync();

            // Assert that the products count initialization is 100.
            Assert.Equal(100, ((List<Product>)products).Count);
        }

        [Fact]
        public async Task GetAllAsync_WithPaging_ShouldReturnPagedResults()
        {
            var pagedProducts = await _productRepository.GetAllAsync(1, 1); // Page 1, page size 1.

            // Assert that the paged result contains a single item.
            Assert.Single(pagedProducts.Items);
            // Assert that the total count of products is 100.
            Assert.Equal(100, pagedProducts.TotalCount);
        }
    }
}
