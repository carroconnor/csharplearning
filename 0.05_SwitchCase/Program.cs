using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend = "Tommy";

            switch (friend)
            {       
                case "Jay":
                    Console.WriteLine("Hey Jay.");
                    break;
                case "Paul":
                    Console.WriteLine("Paul is pretty cool.");
                    break;
                case "Kenn":
                    Console.WriteLine("I don't know you");
                    break;
                case "Carr":
                    Console.WriteLine("Coolest dude ever");
                    break;
                case "Tommy":
                    Console.WriteLine("Dumbest dude ever");
                    break;
            }

            int age = 25;

            switch (age)
            {
                case 25:
                    Console.WriteLine("Man youre old.");
                    break;
            }

            string friends = "Matt";

            switch (friends)
            {
                case "Matt":
                    Console.WriteLine("Very Smart guy, Matt.");
                    break; 
            }

            Console.ReadLine();
        }
    }
}
