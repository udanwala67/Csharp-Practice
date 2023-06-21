namespace Inheritance
{
    public class Program
    {
        public static void Main()
        {
            // create reference variable for Employee class (abstract class)
            IEmployees employees;

            // create object of manager

            Manager manager1 = new Manager(102,"sahil",30,42342,1,"sahil udanwala",12000,"IT");
            System.Console.WriteLine(manager1.GetEmployeeAge());
            Salesman salesman1 = new Salesman(103,"keval",22,45000,2,"Nirav",2222,"india");
            System.Console.WriteLine(salesman1.GetEmployeeAge());

            // create object of Salesman

            System.Console.WriteLine(salesman1.EmployeeId);
            System.Console.WriteLine(salesman1.Salary);
            System.Console.WriteLine(salesman1.GetTotalSalesOfTheMonth());
            System.Console.WriteLine(manager1.GetTotalSalesOfTheYear());
            System.Console.WriteLine(manager1.GetEmployeeAge());
           




        }


    }

}
