using CleanArchitecture.Entites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.IRepository
{
    public interface IProductServices
    {
        Task<List<Product>> Products_GetList();
        Task<int> Product_InsertUpdate(Product product);
    }
}
