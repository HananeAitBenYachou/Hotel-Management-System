using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public static class clsValidation
    {
        public static bool ValidateEmailAddress(string EmailAddress)
        {
            string Pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            Regex regex = new Regex(Pattern);

            return regex.IsMatch(EmailAddress);
        }

        public static bool ValidateInteger(string Number)
        {
            string Pattern = @"^[0-9]*$";

            Regex regex = new Regex(Pattern);

            return regex.IsMatch(Number);
        }

        public static bool ValidateFloat(string Number)
        {
            string Pattern = @"^[0-9]*(?:\.[0-9]*)?$";

            Regex regex = new Regex(Pattern);

            return regex.IsMatch(Number);
        }

        public static bool IsNumber(string Number)
        {
            return ValidateFloat(Number) || ValidateInteger(Number);
        }


    }
}
