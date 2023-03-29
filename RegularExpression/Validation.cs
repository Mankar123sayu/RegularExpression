using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class Validate
    {
       // public const string PIN_CODE = "^[0-9]{6}$";
        //public const string PIN_CODE = "^[A-Za-z]{1}[0-9]{6}$";
        public const string PIN_CODE = "^[0-9]{6}[A-Za-z]{1}$";
        public void Try(string pinCode)
        {
            if (Regex.IsMatch(pinCode, PIN_CODE))
            {
                Console.WriteLine("Validation Successfull");
            }
            else
            {
                Console.WriteLine("Validation UnSuccessfull");
            }
        }
    }
}
