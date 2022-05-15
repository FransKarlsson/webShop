using Microsoft.AspNetCore.Mvc;
using webbShop.services.ProductServices;
using System.Collections.Generic;
using webbShop.models;

namespace webbShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private  IProductService _productService {get;}

        public ProductController(IProductService productService)
        {
            _productService = productService;
            
        }
    
        
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_productService.GetProductList());
        }

        [HttpPost]
        public ActionResult<List<Product>> AddProduct(Product newProduct)
        {
            return Ok(_productService.Addproduct(newProduct));
        }

        [HttpDelete]
        public ActionResult<List<Product>> DeleteProduct(int id)
        {
            return Ok(_productService.Deleteproduct(id));
        }

        [HttpPut]
        public ActionResult<List<Product>> UpdateProduct(Product UpdateProduct)
        {
            return Ok(_productService.Updateproduct(UpdateProduct));
        }
        

    }
}