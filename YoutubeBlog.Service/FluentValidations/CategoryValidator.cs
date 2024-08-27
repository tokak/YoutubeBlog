﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Service.FluentValidations
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name)
               .NotEmpty()
               .NotNull()
               .MinimumLength(3)
               .MaximumLength(150)
               .WithName("Katogori Adı");
        }
    }
}
