using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _31_Validation.Models.Validators
{
    public class ProductValidators: AbstractValidator<Product>
    {
        public ProductValidators()
        {
            RuleFor(x=>x.Email).NotNull().WithMessage("Email boş olamaz!");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen doğru email giriniz!");

            RuleFor(x => x.ProductName).NotNull().NotEmpty().WithMessage("Lütfen product name'i boş geçmeyin!");
            RuleFor(x => x.ProductName).MaximumLength(100).NotEmpty().WithMessage("Lütfen product name'i 100 karakterden fazla girmeyin!");

        }
    }
}
