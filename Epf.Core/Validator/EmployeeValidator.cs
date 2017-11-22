using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Epf.Core.Model;

namespace Epf.Core.Validator
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            SetNameRule();
        }

        private void SetNameRule()
        {
            RuleFor(employee => employee.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage(ErrorMessage.EmptyField);
        }        
    }
}
