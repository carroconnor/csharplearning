using System;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int UserNumber = int.Parse(Console.ReadLine());

            //if (UserNumber == 1)
            //{
            //    Console.WriteLine("Your number is 1");
            //}
            //else if (UserNumber == 2)
            //{
            //    Console.WriteLine("Your number is 2");
            //}
            //else if (UserNumber == 3)
            //{
            //    Console.WriteLine("Your number is 3");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Number");
            //}

            // a single | it will always check both conditions
            //a double || will stop when one of them is true (faster)

            if (UserNumber == 10 || UserNumber == 20)
            {
                Console.WriteLine("Your number is 10 or 20");
            }
            else
            {
                Console.WriteLine("Your number is wrong");
            }

            Console.ReadLine();
        }
    }
}
