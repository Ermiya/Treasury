using Bitspco.Framework.Common.Exceptions;
using Bitspco.Framework.Common.Exceptions.Validations;
using Bitspco.Framework.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Treasury.Shared.Models.Bank
{
    public class BankAddDto: IValidation
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public DateTime CreationTime { get; set; }

        public ValidationException Validate()
        {
            var ex = new ValidationException();
            if (string.IsNullOrEmpty(Name)) ex.InnerExceptions.Add(new RequiredException() { FieldName = "Name" });
            return ex;
        }
    }
}
