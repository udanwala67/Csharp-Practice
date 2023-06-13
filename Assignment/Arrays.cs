using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Arrays
    {
        public static void arrays()
        {
            int[] intArray;
            intArray = new int[5] { 09, 22, 35, 40, 50 };

            Console.Write("For loop :");

            for (int i = 0; i < intArray.Length; i++)

                Console.Write(" " + intArray[i]);
            Console.WriteLine("");


            Console.Write("For Each :");


            foreach (int i in intArray)
                Console.Write(" " + i);
            Console.WriteLine("");

            Console.Write("Do while :");

            int j = 0;
            do
            {
                Console.Write(" " + intArray[j]);
                j++;
            }
            while (j < intArray.Length);

            Console.WriteLine("");
            Console.Write("while do:");

            int k = 0;

            while (k < intArray.Length)
            {
                Console.Write(" " + intArray[k]);
                k++;
            }
            Console.WriteLine("");

            Console.ReadKey();


            string[] StringArray;

            StringArray = new string[5] { "monday", "tuesday", "wednesday" , "thursday", "friday"};
            foreach(string sahil in StringArray)
            {
                Console.Write(sahil + " ");
            }
            Console.WriteLine("");
            Console.ReadKey();

            // Two-dimensional array
            int [,] IntArray1 = new int[,] { 
                                                { 2, 3 }, { 4, 5 }, {6,7}
                                           };
            Console.WriteLine("2D array:" + IntArray1[0,0]);
            Console.WriteLine("2D array:" + IntArray1[1,1]);
            Console.WriteLine("2D array:" + IntArray1[1,0]);

        }




    }
}
