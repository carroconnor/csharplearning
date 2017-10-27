using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_CollectionsDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> awardwinners = new Dictionary<string, string>();

            //awardwinners.Add("Gladiators", "2000");
            //awardwinners.Add("A beautiful mind", "2001");
            //awardwinners.Add("Chicago", "2002");
            //awardwinners.Add("The Lord of the Rings", "2003");
            //awardwinners.Add("Million Dollar Baby", "2004");
            //awardwinners.Add("Ratataouli", "2005");

            //foreach (var movie in awardwinners)
            //{
            //    Console.WriteLine(movie);
            //}

            Dictionary<string, string[]> awardNominees = new Dictionary<string, string[]>()
            {
                {"2006", new string[] {"Happy Feet", "Cars", "Monster House" } },
                {"2007", new string[] {"Rataouille", "Persepolis", "Surfs Up"} },

            };

            foreach (var nominee in awardNominees)
            {
                Console.WriteLine($"Nominees for {nominee.Key}: {nominee.Value[0]}, {nominee.Value[1]}");
            }

            Console.ReadLine();

        }
    }
}
