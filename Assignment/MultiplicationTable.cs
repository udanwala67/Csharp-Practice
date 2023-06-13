using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class MultiplicationTable
    {
        public static void Table()
        {
            int a,result;
          

            Console.Write("Please enter the value of a : ");
            a = Convert.ToInt32(Console.ReadLine());
        

            for (int i = 1; i <= 10; i++)
            {
                result = a * i;
                Console.WriteLine(a + " * " + i + " = {0}" , result);
            }
            Console.ReadKey();
            Console.WriteLine("");
        }
    }
}
