using System;

namespace _0._03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName;
            string lName;
            string Occupation;

            fName = "Fred";
            lName = "Rogers";
            Occupation = "TV Personalities";

            string fullName = fName + lName;

            Console.WriteLine("Hello my name is {0}. I am a {1}.", fullName, Occupation);

            Console.WriteLine($"Hello, my name is {fullName}. I am a {Occupation}");
        }
    }
}
