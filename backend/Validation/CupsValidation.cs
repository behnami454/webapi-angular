using backend.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Validation
{
    public class CupsValidation : AbstractValidator<Cups>
    {
        public CupsValidation()
        {
            RuleFor(c => c.CupsName).MaximumLength(50).NotNull();
            RuleFor(c => c.CupsYear).NotEmpty();
        }

    }
}


