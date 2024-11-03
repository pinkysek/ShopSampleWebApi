using Microsoft.AspNetCore.Mvc;
using ShopSampleWebApi.Core.DataTransferObjects;
using ShopSampleWebApi.Core.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace ShopSampleWebApi.Controllers
{
    /// <summary>
    /// Controller for managing products.
    /// </summary>
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [Produces("application/json")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductController"/> class.
        /// </summary>
        /// <param name="productService">The product service.</param>
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Gets a product by its ID.
        /// </summary>
        /// <param name="id">The product ID.</param>
        /// <returns>The product with the specified ID.</returns>
        [HttpGet("id/{id}")]
        [MapToApiVersion("1.0")]
        [MapToApiVersion("2.0")]
        [SwaggerResponse(StatusCodes.Status200OK, "OK - The product was successfully retrieved.", typeof(ProductDto))]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Not Found - The product with the specified ID was not found.", typeof(void))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal Server Error - An error occurred while processing the request.", typeof(void))]
        public async Task<ActionResult<ProductDto>> GetById(long id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        /// <summary>
        /// Gets all products.
        /// </summary>
        /// <returns>A list of all products.</returns>
        [HttpGet]
        [MapToApiVersion("1.0")]
        [SwaggerResponse(StatusCodes.Status200OK, "OK - Returns a list of all products.", typeof(IEnumerable<ProductDto>))]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Not Found - No products found.", typeof(void))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal Server Error - An error occurred while processing the request.", typeof(void))]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAll()
        {
            var products = await _productService.GetAllAsync();
            return Ok(products);
        }

        /// <summary>
        /// Gets all products with pagination.
        /// </summary>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="pageSize">The number of items per page.</param>
        /// <returns>A paginated list of products.</returns>
        [HttpGet]
        [MapToApiVersion("2.0")]
        [SwaggerResponse(StatusCodes.Status200OK, "OK - Returns a list of all products.", typeof(PagedListDto<ProductDto>))]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Not Found - No products found.", typeof(void))]
        [SwaggerResponse(StatusCodes.Status409Conflict, "Conflict - The page size or page number must be greater than 0.", typeof(void))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal Server Error - An error occurred while processing the request.", typeof(void))]
        public async Task<ActionResult<PagedListDto<ProductDto>>> GetAllWithPaging(int pageNumber = 1, int pageSize = 10)
        {
            if (pageNumber < 1)
                return Conflict("Page number must be greater than 0.");

            if (pageSize < 1)
                return Conflict("Page size must be greater than 0.");

            var pagedProducts = await _productService.GetAllAsync(pageNumber, pageSize);
            return Ok(pagedProducts);
        }

        /// <summary>
        /// Updates the description of a product.
        /// </summary>
        /// <param name="id">The product ID.</param>
        /// <param name="request">The request containing the new description.</param>
        /// <returns>No content if the update was successful.</returns>
        [HttpPatch("id/{id}/description")]
        [MapToApiVersion("1.0")]
        [MapToApiVersion("2.0")]
        [SwaggerResponse(StatusCodes.Status200OK, "OK - The product description was successfully updated.", typeof(void))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad Request - The request is invalid.", typeof(void))]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Not Found - The product with the specified ID was not found.", typeof(void))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal Server Error - An error occurred while processing the request.", typeof(void))]
        public async Task<IActionResult> UpdateDescription(long id, [FromBody] ProductDescriptionUpdateRequestDto request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var success = await _productService.UpdateDescriptionAsync(id, request?.Description);
            if (!success)
                return NotFound();

            return NoContent();
        }
    }
}
