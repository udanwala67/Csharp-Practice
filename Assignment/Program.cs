namespace Assignment
{
    public class Program
    {
        public static void Main()
        {

            Employees employees1 = new Employees();
            {
                employees1.EmployeeId = 1;
                employees1.Age = 45;
                employees1.Salary = 45000;

            };

            Manager manager1 = new Manager();
            {
                manager1.FullName = "Harshad Patel";
                manager1.Age = 50;
                manager1.Salary = 100000;
                manager1.EmployeeId = 2;

            };

            Salesman salesman1 = new Salesman();
            {
                salesman1.SalesmanID = 1;
                salesman1.SalesmanName = "mandar";
                salesman1.Name = "saif";
                salesman1.Salary = 23000;
                salesman1.EmployeeId = 3;
                salesman1.Age = 15;
            }



            System.Console.WriteLine(salesman1.EmployeeId);
            System.Console.WriteLine(salesman1.SalesmanName);
            System.Console.WriteLine(salesman1.Age);
            System.Console.WriteLine(salesman1.Name);
            System.Console.ReadKey();


        

            // create objects
            /*Employee employee1 = new Employee(1, "sahil", "developer");
              Employee employee2 = new Employee(2, "shehzad", "buiesnessman");
              Employee employee3 = new Employee(3, "Aamir", "SE");*/


            // create objects
            Employee employee1 = new Employee(
                empID: 1,
                empName: "Sahil",
                job: "Developer"
                );

            Employee employee2 = new Employee(
                empID: 2,
                empName: "Sahfjgil",
                job: "Develomfdvper"
                );

            Employee employee3 = new Employee(
                empID: 3,
                empName: "fkfd",
                job: "Develmvfdmklsdv,ṣv;clvb;vc.oper"
                );

            //execute static feilds (feilds of static constructor)

            System.Console.WriteLine(Employee.CompanyName);
            System.Console.ReadLine();  

            // excecute instance feilds (feilds of instance constructor)

            System.Console.WriteLine(employee1.empID);
            System.Console.WriteLine(employee1.empName);
            System.Console.WriteLine(employee1.job);
            System.Console.ReadLine();

            System.Console.WriteLine(employee2.empID);
            System.Console.WriteLine(employee2.empName);
            System.Console.WriteLine(employee2.job);
            System.Console.ReadLine();

            System.Console.WriteLine(employee3.empID);
            System.Console.WriteLine(employee3.empName);
            System.Console.WriteLine(employee3.job);
            System.Console.ReadLine();




            // create reference variable
            Product product1, product2;


            // create objects
            product1 = new Product();
            product2 = new Product();

            //initialize feilds
            product1.Name = "Mobile";
            product1.ProductId = 1;
            product1.Price = 5888;
            product1.Description = "Hello brother";


            product2.Name = "Laptop";
            product2.ProductId = 2;
            product2.Price = 58887;
            product2.Description = "Hello Developer";

            /*Product1,product2 is just a reference variable and not an object */
            /*now you can print the data as well by using referece variable*/

            System.Console.WriteLine(product1.Name);
            System.Console.WriteLine(product2.Name);
            System.Console.ReadLine();

            // ---------------------------------------------------------------------------------------------------

            Dog dog1, dog2;

            dog1 = new Dog();
            dog2 = new Dog();

            dog1.Name = "tuffy";
            dog1.breed = "Dobber";
            dog1.price = 96000;

            dog2.Name = "tuffy";
            dog2.breed = "yhrt";
            dog2.price = 96000;

            System.Console.WriteLine(dog1.Name);
            System.Console.ReadLine();
            // ---------------------------------------------------------------------------------------------------


            /*    sahil1 = new Sahil();
                sahil2 = new Sahil();   */




            // -----------------------------------------------------------------------------------------------------
            arraylistfromuser.arrayfromuser();

            positiveFromArray.positiveNumbers();

            PracticeForArray.arrayPractice();

            stringProperties.properties();

            Strings.program();

            /* SwapFirstAndLast.swapFirstAndLast();*/

            ReverseNumber.reversenumber();

            PrimeNumbersOrNot.primeOrNot();

            /* FirstAndLastDigit.firstAndLastDigit();*/

            CompoundInterest.CI();

            MultiplicationTable.Table();

            AsciiOfChar.Asciiof();

            Alphabets.alphabets();

            Arrays.arrays();

            Addition.AdditionOfNumbers();

            SwapValues.swapvalues();

            MultiplyFloating.MultipyFloat();

            ArithmeticOperation.Arithmetic();

            convertFeetToMeter.FeetToMeter();

            convertCelciusToFerenHeit.CelciusToFerenHeit();

            SizeOfDatatype.SizeOfDataType();

            AsciiValues.Ascii();

            AreaOfCircle.areaOfCircle();


            AreaOfSquare.areaOfSquare();

            AreaOfRectangle.areaOfRectangle();

            ConvertDays.convertDays();

        }
    }
}
