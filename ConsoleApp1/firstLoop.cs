using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// go to consoleapp name combinefiles for this pattern programs.
namespace ConsoleApp1
{
    public class firstLoop
    {
        public static void FirstLoop()
        {
            Console.Write("Please Enter The value of n : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                    Console.Write(' ');

                }
                Console.Write("\n");
            }
        }
    }
}
