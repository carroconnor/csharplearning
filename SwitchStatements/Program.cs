using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number");
            int UserNumber = int.Parse(Console.ReadLine());

            //if (UserNumber == 10)
            //{
            //    Console.WriteLine("Your number is 10");
            //}
            //else if (UserNumber == 20)
            //{
            //    Console.WriteLine("Your number is 20");
            //}
            //else if (UserNumber == 30)
            //{
            //    Console.WriteLine("Your number is 30");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Number");
            //}

            //Can be replaced with switch case

            //switch (UserNumber)
            //{
            //    case 10:
            //        Console.WriteLine("Your number is 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("Your number is 20");
            //        break;
            //    case 30:
            //        Console.WriteLine("Your number is 30");
            //        break;
            //    default:
            //        Console.WriteLine("wrong number");
            //        break;
            //}

            switch (UserNumber)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your number is {0}", UserNumber);
                    break;
                default:
                    Console.WriteLine("wrong number");
                    break;
            }
            Console.ReadLine();

            int TotalCoffeeCost = 0;
            Start:
            Console.WriteLine("Please Select Your Coffee Size: 1 - Small, 2 -- Medium, 3 - large");
            int UserChoice = int.Parse(Console.ReadLine());


            switch (UserChoice)
            {
                case 1:
                    TotalCoffeeCost += 1;
                    break;
                case 2:
                    TotalCoffeeCost += 2;
                    break;
                case 3:
                    TotalCoffeeCost += 3;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid", UserChoice);
                    goto Start;
            }

            Decide:
            Console.WriteLine("Do you want to buy another coffee - Yes or No?");
            string UserDecision = Console.ReadLine();

            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid");
                    goto Decide;
            }

            Console.WriteLine("Thank You for shopping with us");
            Console.WriteLine("Bill Ammount = ${0}", TotalCoffeeCost);
            Console.ReadLine();
        }
    }
}
