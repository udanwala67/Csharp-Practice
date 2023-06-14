using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class arraylistfromuser
    {
        public static void arrayfromuser()
        {
            Console.WriteLine("Please enter the size of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] newArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter the value of "+ i + " number");
                newArray[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            int total = 0;
            for (int j=0; j < n; j++)
            {
                total += newArray[j];
            }
            if (total > 0)
                Console.WriteLine(total / n);
            Console.ReadLine();
            Console.WriteLine("");
        }
    }
}
