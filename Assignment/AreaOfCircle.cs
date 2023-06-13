using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class AreaOfCircle
    {
        public static void areaOfCircle()
        {
            double radius, areaOfCircle;

            Console.WriteLine("Please enter the radius of circle:");
            radius = Convert.ToDouble(Console.ReadLine());

            areaOfCircle = Math.PI * radius * radius;

            Console.WriteLine("area of circle for given value is : {0}.",areaOfCircle);
            Console.ReadLine();

        }
    }
}
