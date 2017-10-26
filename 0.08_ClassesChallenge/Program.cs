using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

           

        }
    }
}


