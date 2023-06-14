

namespace Assignment
{
    public class Program
    {
        public static void Main()
        {
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
