using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class AsciiOfChar
    {
        public static void Asciiof()
        {
         
            
            for (char c='A'; c <='Z'; c++)
            {
                int m = Convert.ToInt32(c);
             
          
                Console.WriteLine("Ascii value for {0} is {1}" ,c, m + " ");
            }
                Console.WriteLine("");
                 Console.ReadLine(); 

        }
    }
}