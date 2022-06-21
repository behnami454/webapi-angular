using backend.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Validation
{
    public class ArticleValidation : AbstractValidator<Articles>
    {
        public ArticleValidation()
        {
            RuleFor(c => c.ArticleName).MaximumLength(50).NotNull();
            RuleFor(c => c.ArticleDescription).MaximumLength(1000).NotNull();
            RuleFor(c => c.ArticlesCreateDate).NotEmpty();
        }

    }
}


