using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numerator = 10;
            int Denominator = 2;

            int Result = Numerator / Denominator;

            Console.WriteLine("Result = {0}", Result);
            Console.ReadLine();

            int Number = 12;
            int AnotherNumber = 20;
            bool IsNumber10;
            bool IsNumber12 = Number == 12 ? true : false;

            Console.WriteLine("Number == 12 is {0}", IsNumber12);

            if (Number != 10)
            {

            }

            // Comparison Operators
            // == != > >= < <=

            //Conditional Operators &&, || (and, or)


            if (Number == 10 && AnotherNumber == 20)
            {
                Console.WriteLine("Hello");
            }

            if (Number == 5 || AnotherNumber == 20)
            {
                Console.WriteLine("Bye");
            }

            if (Number == 15)
            {
                IsNumber10 = true;
            }
            else
            {
                IsNumber10 = false;
            }
            Console.WriteLine("Number == 10 is {0}", IsNumber10);
            Console.ReadLine();

        }
    }
}
