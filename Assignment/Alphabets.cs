using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Alphabets
    {
        public static void alphabets()
        {
         /*   for (char c = 'A'; c <= 'Z'; c++)
            {
                Console.Write(c +"\n");
            }*/
         
            for (int i =0 ;i < 26; i++)
            {
                Console.Write(Convert.ToChar(i + (int)'A')+ " ");
            }
            Console.WriteLine("");

        }
    }
}
