﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using FreeCourse.Web.Models.Catalogs;

namespace FreeCourse.Web.Validators
{
    public class CourseCreateInputValidator : AbstractValidator<CourseCreateInput>
    {
        public CourseCreateInputValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş bırakılamaz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş olamaz");
            RuleFor(x => x.Feature.Duration).InclusiveBetween(1, int.MaxValue)
                .WithMessage("Süre alanı boş bırakılamaz.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat alanı boş bırakılamaz.").ScalePrecision(2, 6).WithMessage("Hatalı para formatı");

        }
    }
}
