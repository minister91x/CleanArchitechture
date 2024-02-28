using CleanArchitecture.Entites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public interface IProductRepository
    {
        Task<int> CreateProduct(Product createProduct);
        Task<List<Product>> GetListProduct();
    }
}
