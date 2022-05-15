using webbShop.models;
using System.Linq;
using System.Collections.Generic;

namespace webbShop.services.ProductServices
{
    public class ProductService : IProductService
    {
        private static List<Product> productList = new List<Product>()
        {
            new Product() {
                title = "Goblin Grease",
                ID = 0,
                rating = 4,
                cost = 50,
                stock = 50,
                description = "A jar of the finest goblin grease, apply daily for rich green skin."
            }
        };

        public List<Product> GetProductList()
        {
            return productList;
        }



        public List<Product> Deleteproduct(int id)
        {
            
            var foundProduct = productList.FirstOrDefault(product => product.ID == id);
            productList.Remove(foundProduct);
            return productList;
        }

        public List<Product> Updateproduct(Product updateProduct)
        {
            var foundProduct = productList.FirstOrDefault(Product => Product.ID == updateProduct.ID);
            if(foundProduct != null) 
            {
                foundProduct.title = updateProduct.title;
                foundProduct.description = updateProduct.description;
            }
            return productList;
        }
        

        
        
        public List<Product> Addproduct(Product newProduct)
        {
            productList.Add(newProduct);
            return productList;
        }
        
        
    }


}