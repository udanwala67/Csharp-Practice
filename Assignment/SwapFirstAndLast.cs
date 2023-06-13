using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class SwapFirstAndLast
    {
        public static void swapFirstAndLast()
        {
            {
                int Num, First_Digit, Digits_Count, Last_Digit, x, y, Swap_Num;
                Console.Write("Enter a number");
                Num = Convert.ToInt32(Console.ReadLine());
                Digits_Count = (int)Math.Log10(Num);
                First_Digit = (int)((int) Num / Math.Pow(Digits_Count,10));
                Last_Digit = Num % 10;
                Swap_Num = Last_Digit;
                Swap_Num = Swap_Num * (int) (Math.Round(Math.Pow(Digits_Count,10)));
                Swap_Num = Swap_Num + Num % (int)(Math.Round(Math.Pow(Digits_Count,10)));
                Swap_Num = Swap_Num - Last_Digit;
                Swap_Num = Swap_Num + First_Digit;
                Console.WriteLine(Swap_Num); 
            }




        }
    }
}
