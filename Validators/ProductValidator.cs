using FluentValidation;
using webapi_fluentvalidation.Models;

namespace webapi_fluentvalidation.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");
        }
    }
}