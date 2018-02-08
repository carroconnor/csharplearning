using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserChoice = "";
            do
            {
                int Start = 0;

                Console.WriteLine("Please Enter Your Target Number.");
                int UserTarget = int.Parse(Console.ReadLine());

                while (Start <= UserTarget)
                {
                    Console.Write(Start + " ");
                    Start = Start + 2;
                }

                do
                {
                    Console.WriteLine("Do you want to continue? - Yes or No?");
                    UserChoice = Console.ReadLine().ToUpper();

                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("Invalid choice, please say yes or no");
                    }
                } while (UserChoice != "YES" && UserChoice != "NO");
            } while (UserChoice == "YES");
        }
    }
}
