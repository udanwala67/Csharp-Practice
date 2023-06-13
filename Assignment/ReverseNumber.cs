using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class ReverseNumber
    {
        public static void reversenumber()
        {
            int number, reverse = 0, random;

            Console.Write("Enter a number you want to reverse: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                random = number % 10;
                reverse = reverse * 10 + random;
                number = number / 10;

            }
            Console.WriteLine("Reverese number = {0}", reverse);
            Console.ReadLine();
            Console.WriteLine("");
        }
    }
}
