using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class convertFeetToMeter
    {
        public static void FeetToMeter()
        {
            Double Feet, Meter;

           Console.WriteLine("Enter the value of feet:");
            Feet = Convert.ToDouble(Console.ReadLine());

            Meter = Feet * 0.3048;

            Console.WriteLine("{0} Feet Is Equal To {1} Meter.",Feet,Meter);
            Console.ReadLine(); 

        }
    }
}
