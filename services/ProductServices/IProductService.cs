using System.Collections.Generic;
using webbShop.models;

namespace webbShop.services.ProductServices
{
    public interface IProductService
    {
        List<Product> GetProductList();

        List<Product> Addproduct(Product newProduct);
        List<Product> Deleteproduct(int id);
        List<Product> Updateproduct(Product updateProduct);
    }
}