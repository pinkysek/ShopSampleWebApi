using Microsoft.AspNetCore.Mvc;
using ShopSampleWebApi.Core.DataTransferObjects;
using ShopSampleWebApi.Core.Interfaces;

namespace ShopSampleWebApi.Controllers.v2
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("2.0")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<PagedListDto<ProductDto>>> GetAll(int pageNumber = 1, int pageSize = 10)
        {
            var pagedProducts = await _productService.GetAllAsync(pageNumber, pageSize);
            return Ok(pagedProducts);
        }
    }
}
