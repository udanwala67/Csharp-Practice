using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class AreaOfSquare
    {
        public static void areaOfSquare()
        {
            double a, area;

            Console.WriteLine("Please enter the value one side of square:");
            a = Convert.ToDouble(Console.ReadLine());

            area = Math.Pow(a, 2); 

            Console.WriteLine("The area of square for given value is {0}.", area);
            Console.ReadLine(); 
        }
    }
}
