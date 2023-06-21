using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class AddandMulty
    {
        public static void AddandMultiply()
        {

            Console.Write("\nPlease enter the size of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] newArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nPlease enter the value of " + i + " number:");
                newArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            int total = 0;
            for (int j = 0; j < n; j++)
            {
                total = total + newArray[j];
            }

            int multiply = 1;
            for (int k = 0; k < n; k++)
            {
                /*multiply = multiply * total + newArray[k];*/
                multiply = multiply * newArray[k];
            }

            Console.WriteLine("the addition of given array is : {0}", total);
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("the multipliction of given array is : {0}", multiply);
            Console.ReadKey();
        }
    }
}
