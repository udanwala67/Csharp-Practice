using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class AreaOfRectangle
    {
        public static void areaOfRectangle()
        {
            double length, width,area;

            Console.WriteLine("Please enter the values of length and width respectively:");
            length = Convert.ToDouble(Console.ReadLine());
            width = Convert.ToDouble(Console.ReadLine());

            area = length * width;

            Console.WriteLine("area of rectangle for given values is : {0}", area);
            Console.ReadLine(); 

        }
    }
}
