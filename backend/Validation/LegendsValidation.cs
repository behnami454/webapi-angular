using backend.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Validation
{
    public class LegendsValidation : AbstractValidator<Legends>
    {
        public LegendsValidation()
        {
            RuleFor(c => c.LegendsName).MaximumLength(50).NotNull();
        }

    }
}


