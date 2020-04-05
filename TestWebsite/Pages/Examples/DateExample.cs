using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebsite.Pages.Examples
{
    public class DateExample
    {
        public DateTime Date1 { get; set; }

        public DateTime? Date2 { get; set; }

        public DateTime Date3 { get; set; }
    }


    public class DateExampleValidator : AbstractValidator<DateExample>
    {
        public DateExampleValidator()
        {
            RuleFor(d => d.Date1).GreaterThanOrEqualTo(DateTime.Today).WithMessage("Must be today or later");
            RuleFor(d => d.Date3).NotEmpty().WithMessage("Date3 must be set");
        }
    }
}
