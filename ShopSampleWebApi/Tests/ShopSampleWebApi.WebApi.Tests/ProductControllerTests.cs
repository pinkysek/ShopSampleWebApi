using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopSampleWebApi.Controllers;
using ShopSampleWebApi.Core.DataTransferObjects;
using ShopSampleWebApi.Core.Mappings;
using ShopSampleWebApi.Core.Services;
using ShopSampleWebApi.DataAccess;
using ShopSampleWebApi.DataAccess.Factories;
using ShopSampleWebApi.DataAccess.Repositories;
using ShopSampleWebApi.Helpers;
using Xunit;

namespace ShopSampleWebApi.WebApi.Tests
{
    public class ProductControllerTests : IAsyncLifetime
    {
        private readonly ApplicationDbContext _context;
        private readonly ProductRepository _productRepository;
        private readonly Mapper _mapper;
        private readonly ProductService _productService;
        private readonly ProductController _productController;

        public ProductControllerTests()
        {
            var databaseSettings = ConfigurationHelper.GetDatabaseSettings();

            // Set up the database based on the value from DatabaseSettings configuration.
            _context = DbContextFactory.CreateDbContext(
                databaseSettings.DatabaseType == "InMemory" ? DatabaseType.InMemory : DatabaseType.Real,
                databaseSettings.RealDatabaseConnectionString
            );
            _context = DbContextFactory.CreateDbContext(DatabaseType.InMemory);
            _productRepository = new ProductRepository(_context);
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile<ProductMappingProfile>()));
            _productService = new ProductService(_productRepository, _mapper);
            _productController = new ProductController(_productService);
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
        /// This test verifies that when a product with ID 1 exists, the GetById method returns an OkObjectResult.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task GetById_ReturnsOkResult_WhenProductExists()
        {
            // Arrange & Act.
            var result = await _productController.GetById(1);

            // Assert that the result is of type OkObjectResult.
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            // Assert that the value of the OkObjectResult is of type ProductDto.
            var product = Assert.IsType<ProductDto>(okResult.Value);
            // Assert that the product ID is 1.
            Assert.Equal(1, product.Id);
        }

        /// <summary>
        /// This test verifies that when a product with ID 500 does not exist, the GetById method returns a NotFoundResult.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task GetById_ReturnsNotFound_WhenProductDoesNotExist()
        {
            // Arrange & Act.
            var result = await _productController.GetById(500);

            // Assert that the result is of type NotFoundResult.
            Assert.IsType<NotFoundResult>(result.Result);
        }

        /// <summary>
        /// This test verifies that the GetAll method returns an OkObjectResult with a list of products.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task GetAll_ReturnsOkResult_WithListOfProducts()
        {
            // Arrange & Act.
            var result = await _productController.GetAll();

            // Assert that the result is of type OkObjectResult.
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            // Assert that the value of the OkObjectResult is a list of ProductDto.
            var products = Assert.IsType<List<ProductDto>>(okResult.Value);
            // Assert that the list contains 100 products.
            Assert.Equal(100, products.Count);
        }

        /// <summary>
        /// This test verifies that when the page number is less than 1, the GetAllWithPaging method returns a ConflictObjectResult.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task GetAllWithPaging_ReturnsConflict_WhenPageNumberIsLessThan1()
        {
            // Arrange & Act.
            var result = await _productController.GetAllWithPaging(0, 10);

            // Assert that the result is of type ConflictObjectResult.
            var conflictResult = Assert.IsType<ConflictObjectResult>(result.Result);
            // Assert that the conflict message is "Page number must be greater than 0."
            Assert.Equal("Page number must be greater than 0.", conflictResult.Value);
        }

        /// <summary>
        /// This test verifies that the GetAllWithPaging method returns an OkObjectResult with a paginated list of products.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task GetAllWithPaging_ReturnsOkResult_WithPagedProducts()
        {
            // Arrange & Act.
            var result = await _productController.GetAllWithPaging(1, 10);

            // Assert that the result is of type OkObjectResult.
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            // Assert that the value of the OkObjectResult is a PagedListDto of ProductDto.
            var pagedProducts = Assert.IsType<PagedListDto<ProductDto>>(okResult.Value);
            // Assert that the total count of products is 100.
            Assert.Equal(100, pagedProducts.TotalCount);
        }

        /// <summary>
        /// This test verifies that when the model state is invalid, the UpdateDescription method returns a BadRequestObjectResult.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task UpdateDescription_ReturnsBadRequest_WhenModelStateIsInvalid()
        {
            // Arrange.
            _productController.ModelState.AddModelError("Description", "Description is required");

            // Act.
            var result = await _productController.UpdateDescription(1, new ProductDescriptionUpdateRequestDto());

            // Assert that the result is of type BadRequestObjectResult.
            Assert.IsType<BadRequestObjectResult>(result);
        }

        /// <summary>
        /// This test verifies that when a product with ID 500 does not exist, the UpdateDescription method returns a NotFoundResult.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task UpdateDescription_ReturnsNotFound_WhenProductDoesNotExist()
        {
            // Arrange & Act.
            var result = await _productController.UpdateDescription(500, new ProductDescriptionUpdateRequestDto { Description = "Updated Description" });

            // Assert that the result is of type NotFoundResult.
            Assert.IsType<NotFoundResult>(result);
        }

        /// <summary>
        /// This test verifies that when the update is successful, the UpdateDescription method returns a NoContentResult.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task UpdateDescription_ReturnsNoContent_WhenUpdateIsSuccessful()
        {
            // Arrange & Act.
            var result = await _productController.UpdateDescription(1, new ProductDescriptionUpdateRequestDto { Description = "Updated Description" });

            // Assert that the result is of type NoContentResult.
            Assert.IsType<NoContentResult>(result);

            // Verify that the update is reflected in the database.
            var updatedProduct = await _productRepository.GetByIdAsync(1);
            // Assert that the product description is updated to "Updated Description".
            Assert.Equal("Updated Description", updatedProduct.Description);
        }
    }
}
