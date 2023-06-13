using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class ArithmeticOperation
    {
        public static void Arithmetic()
        {
            int a = 500;
            int b = 5;

            Console.WriteLine("Addition of two numbers = {0}" , a + b);
            Console.WriteLine("Substraction of two numbers = {0}" , a - b);
            Console.WriteLine("Multiplication of two numbers = {0}" , a * b);
            Console.WriteLine("Dividation of two numbers = {0}" , a / b);
            Console.WriteLine("Modulo of two numbers = {0}" , a % b);
            Console.WriteLine("Power of two numbers = {0}" , Math.Pow(a ,b));
            Console.ReadLine();
        }
    }
}
