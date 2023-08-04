using Entites.Concretes;
using FluentValidation;

namespace Business.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("İsim alanı minimum 3 karakter olmalıdır.");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir alanı boş geçilemez.");
        }
    }
}