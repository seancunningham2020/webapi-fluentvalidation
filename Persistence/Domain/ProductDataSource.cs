using System.Collections.Generic;
using System.Linq;
using webapi_fluentvalidation.Models;

namespace webapi_fluentvalidation.Persistence.Domain
{
    public class ProductDataSource : IProductDataSource
    {
        private List<Product> _productList;

        public ProductDataSource()
        {
            _productList = new List<Product>();

            _productList.Add(
                new Product
                {
                    Id = 1,
                    Name = "iPhone 6",
                    Description = "Apple Smartphone",
                    Price = 499,
                    Active = true
                });

            _productList.Add(
                new Product
                {
                    Id = 2,
                    Name = "Sony Xperia X",
                    Description = "Sony Smartphone",
                    Price = 399,
                    Active = true
                });
        }

        public List<Product> Get()
        {
            return _productList;
        }

        public void Add(Product product)
        {
            var maxProductId = _productList.Max(x => x.Id);

            _productList.Add(new Product
            {
                Id = maxProductId + 1,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Active = true
            });
        }
    }
}