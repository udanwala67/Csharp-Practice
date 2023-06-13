using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class FirstAndLastDigit
    {
        public static void firstAndLastDigit()
        {
            int a;
            int FirstNumber,LastNumber;
            Console.Write("Please Enter the value of a : ");
            a = Convert.ToInt32(Console.ReadLine());

           
             int numberOfDigits = Convert.ToInt32(Math.Floor(Math.Log10(a)));      
             FirstNumber = Convert.ToInt32((a / Math.Pow(10, numberOfDigits)));
             LastNumber = a % 10;

            Console.WriteLine("the first number for given value is {0}.",FirstNumber);

            Console.WriteLine("the last number for given value is {0}.", LastNumber);
            Console.ReadKey();
            Console.WriteLine();    
        }
    }
}
