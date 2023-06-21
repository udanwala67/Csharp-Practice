using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class nonRepetiveChar
    {
        public static void NonRepetiveChar()
        {
            Console.WriteLine("Please enter the string : ");
            string data = Console.ReadLine();

            char c = data[0];
            int count = 0;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == c)
                {
                    count++;
                }
                else
                {
                    if (count == 1)
                    {
                        break;
                    }
                    else
                    {
                        count = 1;
                        c = data[i];
                    }

                }
                if (count == 1)
                {
                    Console.WriteLine("the non repeated characters will be:{0}", c);
                }
                else if (count > 1)
                {
                    Console.WriteLine("all charcters in the given string are unique");
                }
            }
        }
    }
}