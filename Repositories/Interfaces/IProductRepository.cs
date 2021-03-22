using System.Collections.Generic;
using System.Threading.Tasks;
using EFCore.Entities;

namespace Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductById(int id);
        Task<Product> CreateProductAsync(Product product);
    }
}