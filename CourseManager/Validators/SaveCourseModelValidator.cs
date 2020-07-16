using CourseManager.Resources.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseManager.Validators
{
    public class SaveCourseModelValidator : AbstractValidator<SaveCourseModel>
    {
        public SaveCourseModelValidator()
        {
            RuleFor(a => a.Name)
                .NotEmpty()
                .MaximumLength(50);
            RuleFor(a => a.Price)
                .NotEmpty();
            RuleFor(a => a.DayOfWeekId)
                .NotEmpty();
            RuleFor(a => a.TimeOfDayId)
                .NotEmpty();

        }
    }
}
