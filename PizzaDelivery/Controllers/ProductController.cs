using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DTO.Requests.Product;
using DTO.Responses.Product;
using EFCore.Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;

namespace PizzaDelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _products;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository products, IMapper mapper)
        {
            _products = products;
            _mapper = mapper;
        }

        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var result = await _products.GetAllProductsAsync();
            return Ok(_mapper.Map<IEnumerable<Product>,IEnumerable<ProductResponseDTO>>(result));
        }
        
        /// <summary>
        /// Get product by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var result = await _products.GetProductByIdAsync(id);
            return Ok(_mapper.Map<Product, ProductResponseDTO>(result));
        }
        
        /// <summary>
        /// Create new product
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] ProductPostDTO model)
        {
            var result = await _products.CreateProductAsync(_mapper.Map<ProductPostDTO, Product>(model));
            return Ok(result);
        }
    }
}