using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*C# Program to Swap Values of Two Variables.*/

namespace Assignment
{
    public class SwapValues
    {
        public static void swapvalues()
        {
            int a = 45;
            int b = 30;
          


            a = a + b;  //75
            b = a - b;  //75-30 = 45
            a = a - b; //45-15 = 30


            Console.WriteLine("Swapped Values of a = " + a + " and b = " + b);
            Console.ReadLine(); 
        }

    }
}
