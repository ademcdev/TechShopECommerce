using Microsoft.AspNetCore.Mvc;
using TechShop.API.Repositories.ProductRepositories;

namespace TechShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductInterface _productInterface;

        public ProductsController(ProductInterface productInterface)
        {
            _productInterface = productInterface;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productInterface.GetAllProductAsync();
            return Ok(values);
        }

        [HttpGet("ProductListWithNames")]
        public async Task<IActionResult> ProductListWithNames()
        {
            var values = await _productInterface.GetAllProductWithNamesAsync();
            return Ok(values);
        }
    }
}
