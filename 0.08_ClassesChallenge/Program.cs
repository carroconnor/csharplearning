using System;

namespace _0._08_ClassesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Netflix mindhunters = new Netflix();
            Netflix strangerthings = new Netflix();
            Netflix office = new Netflix();

            mindhunters.Genre = "Psychological thriller";
            strangerthings.Genre = "Psychological thriller";
            office.Genre = "Comedy";

            mindhunters.Rating = 4;
            strangerthings.Rating = 3;
            office.Rating = 5;

            Movie IAmLegend = new Movie();
            Movie Matrix = new Movie();
            Movie HomeAlone = new Movie();

            IAmLegend.Genre = "Horror";
            IAmLegend.Rating = 5;
            IAmLegend.Year = 2010;

            Matrix.Genre = "Action";
            Matrix.Rating = 5;
            Matrix.Year = 2007;

            HomeAlone.Genre = "Comedy";
            HomeAlone.Rating = 3;
            HomeAlone.Year = 1993;

            Console.WriteLine($"The genre of Home Alone is {HomeAlone.Genre}");
            Console.ReadLine();
        }
    }
}


