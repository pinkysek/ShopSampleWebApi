using Microsoft.AspNetCore.Mvc;
using ShopSampleWebApi.Core.DataTransferObjects;
using ShopSampleWebApi.Core.Interfaces;

namespace ShopSampleWebApi.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("id/{id}")]
        public async Task<ActionResult<ProductDto>> GetById(long id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAll()
        {
            var products = await _productService.GetAllAsync();
            return Ok(products);
        }

        [HttpPatch("id/{id}/description")]
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
