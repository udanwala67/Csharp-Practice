using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Product
    {
        public int ProductId;
        public string Name;
        public string Description;
        public int Price;
    }

    public class Dog
    {
        public string Name;
        public string breed;
        public double price;
    }

    public class Sahil
    {
        public int num;
        public string name;

        Sahil()
        {
            Console.WriteLine("Constructor Called");
        }

       /* Sahil sahil1 = new Sahil();
        Sahil sahil2 = new Sahil();*/

        public static void Const(Sahil sahil1,Sahil sahil2)
        {


            sahil1.name = "Sahil";
            sahil2.name = "Aamir";

            sahil1.num = 1;
            sahil2.num = 2;

            Console.WriteLine(sahil1.name); 

        }
    }


}
