using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class PrimeNumbersOrNot
    {
        public static void primeOrNot()
        {
         /*   bool ContinueProgram = true;*/

            int number, a = 0;
            Console.Write("Enter the value of number : ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", number);
            }
            else
            {
                Console.WriteLine("{0} is Not a Prime Number",number);
            }
            Console.ReadLine();
/*
            Console.WriteLine("You want to try for different numbers? (Y/N?");
            string Input = Console.ReadLine();*/

         /*  if (Input.ToLower() != "y")
            {
                ContinueProgram = false;
            }*/

           /* Console.ReadKey();*/


        }
    }
}
