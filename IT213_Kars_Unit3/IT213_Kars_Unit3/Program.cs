using System;

namespace IT213_Kars_Unit3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment 3 section 1

            //declare variables
            int total;
            int gradeCounter;
            int grade;
            int average;

            //initalize
            total = 0;
            gradeCounter = 1;

            Console.WriteLine("**** Assignment 3: Section 1 - While Loop to Average Grades ****\n");

            while (gradeCounter <= 10)
            {
                Console.WriteLine("Enter grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
                total = total + grade;
                gradeCounter = gradeCounter + 1;
            }

            average = total / 10;

            Console.WriteLine("\nTotal if all 10 grades is {0}", total);
            Console.WriteLine("Class average is " + average);

            //Assignment 3 Section 2
            Console.WriteLine("\n\n**** Assignment 3: Section 2 - Nested For Loops ****/n");
            for (int k = 5; k >= 1; k--)

            {
                for (int i = 0; i <= 10; i += 2)
                {
                    Console.WriteLine("k = {0} i = {1}", k, i);
                }
            }
            //Assignment 3 Section 3
            int number=0;
            int totalNumbers=0;

            Console.WriteLine("\n\n**** Assignment 3: Section 3 - While Loop With Sentinel ****\n");

            while (number != -1)
            {
                Console.WriteLine("Enter a positive number to be added to the total or -1 to end.");
                number = Convert.ToInt32(Console.ReadLine());
                if (number != -1)
                {
                    totalNumbers = totalNumbers + number;
                }
            }

            Console.WriteLine("The sum of all numbers entered is " + totalNumbers);
            Console.Read();
        }
    }
}
