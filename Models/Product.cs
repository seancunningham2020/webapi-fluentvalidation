using FluentValidation.Attributes;
using webapi_fluentvalidation.Validators;

namespace webapi_fluentvalidation.Models
{
    [Validator(typeof(ProductValidator))]
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool Active { get; set; }
    }
}