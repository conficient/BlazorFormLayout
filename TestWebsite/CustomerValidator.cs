using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebsite
{
    /// <summary>
    /// Validator for customer object
    /// </summary>
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Please enter a name");
            RuleFor(c => c.Name).MinimumLength(3).WithMessage("Name must be at least 3 chars long");

            RuleFor(c => c.DeliveryDate).GreaterThan(DateTime.Today).WithMessage("Delivery date must be in the future!");
            RuleFor(c => c.Price).GreaterThan(0m).WithMessage("Price must be > 0");
            RuleFor(c => c.Units).GreaterThan(0).WithMessage("Order must be at least 1 unit");

            RuleFor(c => c.AcceptTerms).Equal(true).WithMessage("You must accept our terms to continue!");
        }
        
    }
}
