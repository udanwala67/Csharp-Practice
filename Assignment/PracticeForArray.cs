using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class PracticeForArray
    {
        //Write a C# Sharp program that stores elements in an array and prints them.

        public static void arrayPractice()
        {
            int[] arraylist = new int[10] ;

            for (int i = 0; i < arraylist.Length; i++)
            {
                Console.Write("the element {0} :", i);
                arraylist[i] = Convert.ToInt32 (Console.ReadLine());  
            }
            for(int i = 0; i < arraylist.Length;i++)
            {
                Console.Write("{0} ", arraylist[i]);
            }
            Console.WriteLine("");
            Console.ReadLine(); 

        }
    }
}
