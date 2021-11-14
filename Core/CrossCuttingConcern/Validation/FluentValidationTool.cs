using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcern.Validation
{
    public static class FluentValidationTool
    {
        public static void Validate(IValidator validator, Object entity)
        {
            var validationContext = new ValidationContext<object>(entity);           
            var result = validator.Validate(validationContext);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

        }
    }
}
