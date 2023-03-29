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
         public const string PIN_CODE = "^[0-9]{6}$";
        //public const string PIN_CODE = "^[A-Za-z]{1}[0-9]{6}$";
        // public const string PIN_CODE = "^[0-9]{6}[A-Za-z]{1}$";
        //public const string PIN_CODE = "^[0-9]{3}[ ]{1}[0-9]{3}$";
        //public const string EMAIL = "^[A-Za-z]{3,}[.]{0,1}[A-Za-z]{3,}$";
       // public const string EMAIL = "^[A-Za-z]{3,}[.]{0,1}[A-Za-z]{3,}[@]{1}$";
        public const string EMAIL = "^[A-Za-z]{3,}[.]{0,1}[A-Za-z]{3,}[@]{1}[A-Za-z]{1,}[.]{1}$";
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
       // abc.xyz@bridgelabz.co.in
        public void Try1(string email)
        {
            if (Regex.IsMatch(email, EMAIL))
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
