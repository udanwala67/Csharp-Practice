using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// go to consoleapp combinefiles for this pattern programs.
namespace ConsoleApp1
{
    public class combineLoop
    {
        public static void CombineLoop()
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

            for (int i = n; i >= 0; i--)
            {
                for (int j = 0; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                    Console.Write(' ');
                }
                Console.Write("\n");
            }

        }
    }
}
