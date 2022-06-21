using backend.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Validation
{
    public class StadiumValidation : AbstractValidator<Stadium>
    {
        public StadiumValidation()
        {
            RuleFor(c => c.StadiumName).MaximumLength(50).NotNull();
            RuleFor(c => c.StadiumPlace).NotEmpty().MaximumLength(50);
        }

    }
}

