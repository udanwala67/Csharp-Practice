using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class convertCelciusToFerenHeit
    {
        public static void CelciusToFerenHeit()
        {
            Double Celcius, FerenHeit;

            Console.WriteLine("Enter The value of Celcius: ");
            Celcius = Convert.ToDouble(Console.ReadLine());

            FerenHeit = (Celcius *  9/5) + 32;

            Console.WriteLine("{0} Celcius is Equal To {1} FerenHeit.", Celcius,FerenHeit);
            Console.WriteLine("\n");
            
                                            // FerehnheitToCelcius

            Console.WriteLine("enter the value of FerenHeit :");
            FerenHeit = Convert.ToDouble(Console.ReadLine());

            Celcius = (Celcius - 32) * 5 / 9;

            Console.WriteLine("{0} FerenHeit is equal to {1} Celcius.", FerenHeit,Celcius);
            Console.ReadLine(); 

        }
    }
}
