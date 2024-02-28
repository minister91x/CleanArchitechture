using CleanArchitecture.Application.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_2911_CleanArchitechture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductServices _productServices;
        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpPost("GetListProduct")]
        public async Task<IActionResult> GetListProduct()
        {
            var list = await _productServices.Products_GetList();
            return Ok(list);
        }
    }
}
