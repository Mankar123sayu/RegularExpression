using System;
using System.ComponentModel.DataAnnotations;

namespace RegularExpression
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC1
            Validate code = new Validate();
            code.Try("400088");
        }
    }
}
