using System.Collections.Generic;
using webapi_fluentvalidation.Models;

namespace webapi_fluentvalidation.Persistence.Domain
{
    public interface IProductDataSource
    {
        List<Product> Get();

        void Add(Product product);
    }
}
