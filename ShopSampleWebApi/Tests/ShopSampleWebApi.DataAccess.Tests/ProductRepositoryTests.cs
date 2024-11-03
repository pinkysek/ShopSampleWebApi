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

        /// <summary>
        /// Tests the AddAsync method of the ProductRepository class.
        /// This test verifies that a product can be successfully added to the database.
        /// </summary>
        [Fact]
        public async Task AddAsync_ShouldAddProduct()
        {
            // Arrange: Create a new product instance with test data.
            var product = new Product { Name = "TestProduct", ImgUri = "https://picsum.photos/g/200/200/?image=123", Price = 1000 };

            // Act: Add the product to the repository and save changes.
            await _productRepository.AddAsync(product);

            // Act: Retrieve the added product from the database.
            var addedProduct = await _context.Products.FindAsync(product.Id);

            // Assert: Verify that the product was added successfully.
            Assert.NotNull(addedProduct); // The added product should not be null.
            Assert.Equal("TestProduct", addedProduct.Name); // The name should match the test data.
            Assert.NotNull(addedProduct.ImgUri); // The image URI should not be null.
            Assert.Equal(1000, addedProduct.Price); // The price should match the test data.
        }


        /// <summary>
        /// Tests the GetAllAsync method of the ProductRepository class.
        /// This test verifies that all products can be successfully retrieved from the database.
        /// </summary>
        [Fact]
        public async Task GetAllAsync_ShouldReturnAllProducts()
        {
            var products = await _productRepository.GetAllAsync();

            // Assert that the products count initialization is 100.
            Assert.Equal(100, ((List<Product>)products).Count);
        }

        /// <summary>
        /// Tests the GetAllAsync method of the ProductRepository class with paging.
        /// This test verifies that the method returns the correct paged results.
        /// </summary>
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
