using System;
using System.Collections.Generic;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace OOPS
{
    public class Program
    {
        static void Main()
        {
            Multithreding.multiThreding();

            Multithreding.Test1();
            Multithreding.Test2();  
            Multithreding.Test3();

            AddandMulty.AddandMultiply();

            Console.ReadKey();

            Encaptulation encaptulation1 = new Encaptulation();

            Encaptulation encaptulation2 = new Encaptulation();
            {
                encaptulation2.CategoryID = 3;
                encaptulation2.ProductName = "SK White Mamry";
                encaptulation2.PackageDate = DateTime.Now;
            }

            Console.WriteLine(Encaptulation.productName);
            Console.WriteLine(encaptulation1.ProductID);
            Console.WriteLine(encaptulation1.ProductName);
            Console.WriteLine(encaptulation2.ProductName);
            Console.WriteLine(encaptulation2.PackageDate);
            Console.ReadKey();

            // Create a reference variable

            /*List<int> myList;*/

            // Create an object for list class

           /* myList = new List<int>() { 30, 45, 43 };*/

           /* or also we can implement bith the things in same line*/

            List<int> myList = new List<int>() { 1, 2, 3 };

            // Add method for adding an element in List,inserting

            myList.Add(230);

            myList.Insert(2, 56);

            List<int> AnotherList = new List<int>() { 40, 50, 60 };

            // AddRange method for adding more than one elements in List. it will add values after the initial already given data.
            // in insertRange the data at first shows index number where the Data will be inserted.

            myList.AddRange(AnotherList);
            myList.InsertRange(3, AnotherList);

            foreach (int i in myList)
            {
                Console.WriteLine("the Entered Number is : {0} ", i);
            }
            List<int> ArrayList = new List<int>() { 45, 75, 89 };

            List<int> AnotherArrayList = new List<int>() { 78, 33, 22, 65, 6788, 67, 89 };


            //remove ranges starts from index 2 and count 4 indexes including 2 to 4 undex values
            AnotherArrayList.RemoveRange(2, 4);

            // For Removing Particular Element from given List.
            AnotherList.Remove(65);


            // for Removing the data from particular index

            AnotherArrayList.RemoveAt(5);
            foreach (int i in AnotherArrayList)
            {
                Console.WriteLine(i);
            }

          /*  RemoveAll = to remove every data from given list where condition satisfies.*/
            AnotherArrayList.RemoveAll(n => n >= 60);


            foreach (int s in AnotherArrayList)
            {
                Console.WriteLine("the remaining data after removing value is : {0}", s);
            }

            Console.ReadKey();

            foreach (int item in ArrayList)
            {
                Console.WriteLine("The amount of data given is : {0}", item);
            }
            Console.ReadKey();

        }
    }
}
