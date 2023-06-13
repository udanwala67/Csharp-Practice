using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*C# Program to Multiply two Floating Point Numbers*/


namespace Assignment
{
    public class MultiplyFloating
    {
        public static void MultipyFloat()
        {
            float a = 34.523f;
            float b = 23.562f;

            var result =  a *  b;

            Console.WriteLine("Multiplication of two Floating points = " + result);
            Console.ReadLine(); 
        }
    }
}
