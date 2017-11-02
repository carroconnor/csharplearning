using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._23_LINQ_Dog_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dogs = {"K 9", "Brian Griffin",
            "Scooby Doo", "Old Yeller", "Rin Tin Tin",
            "Benji", "Charlie B. Barkin", "Lassie",
            "Snoopy"};

            //print dog names that have length of 5

            IEnumerable<string> query = from i in dogs
                                        where i.Length == 5
                                        select i;

            foreach (string name in query)
            {
                Console.WriteLine(name);
            }

            //Print dog names that have spaces

            IEnumerable<string> query2 = from dog in dogs
                                         where dog.Contains(" ")
                                         orderby dog descending
                                         select dog;
            foreach (string i in query2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


        }
    }
}
