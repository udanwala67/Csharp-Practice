using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    /*  Write a program to find average of all postive number from array*/
    public class positiveFromArray
    {
        public static void positiveNumbers()
        {
            int[] ArrayList = new int[5] { 2, 5, 7, 8, -5 };

            for (int i = 0; i < ArrayList.Length; i++)
            {

                if (ArrayList[i] > 0)
                {

                    Console.WriteLine("positive array is : {0}", ArrayList[i]);
                }
                else
                {
                    break;
                }

            }
            Console.ReadLine();

        }
    }
}
