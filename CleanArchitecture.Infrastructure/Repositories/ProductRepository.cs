using CleanArchitecture.Entites.Entites;
using CleanArchitecture.Infrastructure.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationContext _userContext;

        public ProductRepository(ApplicationContext userContext)
        {
            _userContext = userContext;
        }

        public async Task<int> CreateProduct(Product createProduct)
        {
            _userContext.Add(createProduct);
            return _userContext.SaveChanges();
        }

        public async Task<List<Product>> GetListProduct()
        {
            return _userContext.Product.ToList();
        }
    }
}
