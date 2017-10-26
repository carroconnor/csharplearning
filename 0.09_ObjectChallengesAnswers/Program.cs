using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_ObjectChallengesAnswers
{
    class Program
    {
        static void Main(string[] args)
        {

            Netflix2 theoffice = new Netflix2();
            Netflix2 strangerthings = new Netflix2();
            Netflix2 theitcrowd = new Netflix2();

            theoffice.Name = "The Office";
            theoffice.Genre = "Comedy";
            theoffice.Rating = 5.0;

            strangerthings.Name = "Stranger Things";
            strangerthings.Genre = "Horror";
            strangerthings.Rating = 4.5;

            theitcrowd.Name = "The IT Crowd";
            theitcrowd.Genre = "Comedy";
            theitcrowd.Rating = 1.5;

            // Calling the method

            theoffice.GetSuggestion();
            theitcrowd.GetSuggestion();
            strangerthings.GetSuggestion();

            // Lists

            List<Netflix2> favoriteShows = new List<Netflix2>();

            favoriteShows.Add(theoffice);
            favoriteShows.Add(strangerthings);
            favoriteShows.Add(theitcrowd);

            foreach (Netflix2 show in favoriteShows)
            {
                Console.WriteLine(show.Name);
                Console.WriteLine(show.Genre);
                Console.WriteLine(show.Rating);
            }

            Console.ReadLine();
            
            


        }
    }
}
