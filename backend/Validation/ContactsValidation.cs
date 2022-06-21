using backend.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Validation
{
    public class ContactsValidation : AbstractValidator<Contact>
    {
        public ContactsValidation()
        {
            RuleFor(c => c.ContactEmail).EmailAddress();
            RuleFor(c => c.ContactDiscription).MaximumLength(500).NotNull();
            RuleFor(c => c.ContactCreateDate).NotEmpty();
        }

    }
}
