using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entites.Concretes;
using FluentValidation;

namespace Business.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün adı boş bırakılamaz");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ürün adı en az 3 karakter içermelidir");

            RuleFor(x => x.StockAmount).NotEmpty().WithMessage("Stok Sayısı boş geçilemez");
            RuleFor(x => x.UnitPrice).NotEmpty().WithMessage("Ürün Fiyatı boş geçilemez");
        }
    }
}


