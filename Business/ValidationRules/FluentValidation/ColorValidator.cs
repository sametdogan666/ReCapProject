using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(co => co.ColorId).NotEmpty();
            RuleFor(co => co.ColorName).NotEmpty();
            RuleFor(co => co.ColorName).MinimumLength(3);
        }
    }
}
