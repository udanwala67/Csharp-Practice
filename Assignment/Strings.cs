using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Strings
    {
        public static void program()
        {
               // from literal

            string[] Sahil = new string[5];
            Sahil[1] = "hello";
            Sahil[2] = "sahil";
            Sahil[3] = "bhai";

            for (int i = 1; i < Sahil.Length; i++)
            {
                Console.WriteLine("Value of index position " + i + " is " + Sahil[i]);
            }
                Console.ReadLine();

            Console.Write("Enter the string here:");
            string sahil = Console.ReadLine();

            Console.WriteLine(sahil);
            Console.ReadLine();
            Console.WriteLine("");

            // using constructor


            char[] chars = {'S','A','H','I','L' };         //char[] chars = new chars[5]
                                                           //chars[i] = {'a','b','v','c','d'}

            string str1 = new string(chars) ;
            Console.WriteLine(str1);

            string str2 = new string('B', 10);
            Console.WriteLine(str2);

            Console.ReadLine();
            Console.WriteLine("");

            // from Concat


            string[] newstr1 = new string[3] { "hello", "world","C#"};

            for(int i = 0; i < newstr1.Length; i++)
            {
                Console.WriteLine(newstr1[i]);
            }


        }

    }
}
