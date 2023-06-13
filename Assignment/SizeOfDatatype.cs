using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class SizeOfDatatype
    {
        public static void SizeOfDataType()
        {
            Console.WriteLine("Size Of Intenger is equal to {0}",sizeof(int));
            Console.WriteLine("Size Of Character is equal to {0}", sizeof(Char)); 
            Console.WriteLine("Size Of Float is equal to {0}", sizeof(float)); 
            Console.WriteLine("Size of Double is equal to {0} ", sizeof(double));
            Console.WriteLine("Size of Bool is equal to {0} ", sizeof(bool));   

            Console.ReadLine(); 
         
        }
    }
}
