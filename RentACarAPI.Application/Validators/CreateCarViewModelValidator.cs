using FluentValidation;
using RentACarAPI.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarAPI.Application.Validators
{
    public class CreateCarViewModelValidator : AbstractValidator<CreateCarViewModel>
    {
        public CreateCarViewModelValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull()
                .WithMessage("Please Don't Forget Write Car Name")
                .MaximumLength(50).MinimumLength(2)
                .WithMessage("Car Name Should Be Between 2 And 50 Characters");
            RuleFor(x => x.price).NotEmpty().NotNull()
              .WithMessage("Please Don't Forget Write Car Price")
              .GreaterThan(0)
              .WithMessage("Car Price Should Be Greater Than 0");




        }
    }
}
