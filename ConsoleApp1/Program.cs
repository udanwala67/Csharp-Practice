// ok so i just want to check time allocation of multithreading for the different Thread in same program.


namespace ConsoleApp1
{
    public class Program
    {
        public class Multithreding
        {
            public static void multiThreding()
            {
                Thread T = Thread.CurrentThread; ;
                T.Name = "Main Thread";
                Console.WriteLine("Current executing thread is:{0}", Thread.CurrentThread.ManagedThreadId);
                Console.ReadKey();
            }

            public static void Test1()
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine("Test :" + i);
                    if (i == 50)
                    {
                        Console.WriteLine("The thread will stop here for 5 seconds");
                        Thread.Sleep(5000);
                    }
                }
                Console.ReadKey();
            }
            public static void Test2()
            {
                for (int i = 101; i <= 200; i++)
                {
                    Console.WriteLine(i);
                }
                Console.ReadKey();
            }
            public static void Test3()
            {
                for (int i = 201; i <= 300; i++)
                {
                    Console.WriteLine(i);
                }
                Console.ReadKey();
            }
            static void Main()
            {
                Thread t1 = new Thread(Test1);
                Thread t2 = new Thread(Test2);
                Thread t3 = new Thread(Test3);
                t1.Start(); t2.Start(); t3.Start();
            }

        }
    }
}


