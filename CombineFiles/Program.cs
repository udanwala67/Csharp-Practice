namespace Inheritance
{
    public class Program
    {
        public static void FirstLoop()
        {
            Console.Write("Please Enter The value of n : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                    Console.Write(' ');

                }
                Console.Write("\n");
            }
        }

        public static void SecondLoop()
        {
            Console.Write("Please Enter The value of n : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = n; i >= 0; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                    Console.Write(' ');

                }
                Console.Write("\n");
            }
        }

        public static void CombineLoop()
        {
            Console.Write("Please Enter The value of n : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                    Console.Write(' ');

                }
                Console.Write("\n");
            }

            for (int i = n; i >= 0; i--)
            {
                for (int j = 0; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                    Console.Write(' ');
                }
                Console.Write("\n");
            }

        }

        public static void findRepeatingChar()
        {
            Console.WriteLine("Please Enter a string");
            string value = Console.ReadLine();
        
            int count = 0; 
            char c = value[0];

            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == c)
                {
                    count++;
                }
                else
                {
                    if (count == 1)
                        break;

                    else
                    {
                        count = 1;
                        c = value[i];
                    }
                }
            }
            if (count == 1)
            {
                Console.WriteLine("Non Repeating character is {0}", c);
            }
            if (count > 1)
            {
                Console.WriteLine("There is no Repating character available");
            }

        }

        public static void Main()
        {
            FirstLoop();
            SecondLoop();
            CombineLoop();
            findRepeatingChar();

        }
    }
}