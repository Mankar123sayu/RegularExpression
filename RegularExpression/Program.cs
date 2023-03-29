using System;
using System.ComponentModel.DataAnnotations;

namespace RegularExpression
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC1
           // Validate code = new Validate();
           // code.Try("400088");

           // Validate code = new Validate();
           // code.Try("S400088");

           // Validate code = new Validate();
           // code.Try("400088Z");

           // Validate code = new Validate();
            //code.Try("400 088");

            //Validate ecode = new Validate();
           // ecode.Try1("abc.xyz");

            Validate ecode = new Validate();
            ecode.Try1("abc.xyz@");
        }
    }
}
