using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class CompoundInterest
    {
        public static void CI()
        {
            double P, R,N, T,A,CompundInterest;


            Console.Write("Please enter the value of Principal Amount: ");
            P = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the value of Interest Rate: ");
            R = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the value of Number Of Times The Amount Will Be given : ");
            N = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the number of Years : ");
            T = Convert.ToDouble(Console.ReadLine());

            A = P * Math.Pow((1 + R / (100 * N)), N*T) ;
            CompundInterest = A - P;

            Console.WriteLine("The Compund Interset Of Given Values are {0}", CompundInterest);
            Console.ReadLine();

        }
    }
}
