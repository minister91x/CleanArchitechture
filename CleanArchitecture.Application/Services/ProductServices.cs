using CleanArchitecture.Application.IRepository;
using CleanArchitecture.Entites.Entites;
using CleanArchitecture.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Repository
{
    public class ProductServices : IProductServices
    {
        private readonly IProductRepository _productRepository;

        public ProductServices(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<List<Product>> Products_GetList()
        {
            return _productRepository.GetListProduct();
        }

        public Task<int> Product_InsertUpdate(Product product)
        {
            return _productRepository.CreateProduct(product);
        }
    }
}
