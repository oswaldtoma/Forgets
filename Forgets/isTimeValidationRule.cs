using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Forgets
{
    public class isTimeValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var val = value as string;
            DateTime time = new DateTime();

            bool isTime = DateTime.TryParse(val, out time);
            return new ValidationResult(isTime, "Not a valid time input");
        }
    }
}
