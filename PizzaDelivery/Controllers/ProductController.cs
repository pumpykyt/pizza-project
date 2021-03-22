using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;

namespace PizzaDelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _products;

        public ProductController(IProductRepository products)
        {
            _products = products;
        }

        public async Task<IActionResult> GetAllProducts()
        {
            return Ok();
        }

        public async Task<IActionResult> GetProductById(int id)
        {
            return Ok();
        }

        public async Task<IActionResult> CreateProduct()
        {
            return Ok();
        }
    }
}