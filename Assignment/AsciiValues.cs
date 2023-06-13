using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class AsciiValues
    {
        public static void Ascii()
        {
            char a;
            Console.WriteLine("Please Enter the Character Here:");
            a = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("The Ascci Value of {0} is {1}", a, Convert.ToInt32(a));
            Console.ReadLine();
            Console.WriteLine("\n");    
        }
    }
}
