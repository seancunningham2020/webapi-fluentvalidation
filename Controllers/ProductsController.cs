using System.Web.Http;
using webapi_fluentvalidation.Models;
using webapi_fluentvalidation.Persistence.Domain;

namespace webapi_fluentvalidation.Controllers
{
    public class ProductsController : ApiController
    {
        private IProductDataSource _productDataSource;

        public ProductsController(IProductDataSource productDataSource)
        {
            _productDataSource = productDataSource;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var products = _productDataSource.Get();

            if (products == null)
            {
                return NotFound();
            }

            return Ok(products);
        }

        [HttpPost]
        public IHttpActionResult Add(Product product)
        {
            _productDataSource.Add(product);

            return Ok();
        }
    }
}
