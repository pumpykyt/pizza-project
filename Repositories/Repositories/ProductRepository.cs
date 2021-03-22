using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Context;
using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;

namespace Repositories.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly EFContext _context;

        public ProductRepository(EFContext context)
        {
            _context = context;
        }
        
        public async Task<Product> CreateProductAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.Products.SingleOrDefaultAsync(t => t.Id == id);
        }
    }
}