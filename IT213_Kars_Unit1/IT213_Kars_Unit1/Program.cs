using System;

namespace IT213_Kars_Unit1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unit 1 Project Assignment\n\n");
            //Initalize variables
            String name = "John Smith";
            String address = "101 N. Main Street";
            String city = "Anytown";
            String state = "TX";
            String zipCode = "11111";
            String unitsTaken = "19";

            const double pricePerUnit = 100.50;
            const double discount = 150;

            //processing
            int intUnitsTaken = Convert.ToInt32(unitsTaken);
            intUnitsTaken++;
            double tuition = pricePerUnit * intUnitsTaken;
            double afterDiscount = tuition - discount;
            double monthlyPayment = afterDiscount / 12;

            //Display results
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("City: " + city);
            Console.WriteLine("State: " + state);
            Console.WriteLine("Zip Code: " + zipCode);

            Console.WriteLine("The number of units taken is: " + intUnitsTaken);
            Console.WriteLine(string.Format("The tuition before discount is {0:c}", tuition));
            Console.WriteLine(string.Format("The tuition after discount is {0:c}", afterDiscount));
            Console.WriteLine(string.Format("The monthly payment is {0:c}", monthlyPayment));

            //end program
            Console.Read();
        }
    }
}
