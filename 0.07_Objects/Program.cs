using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donut jellyDonut = new Donut();
            Donut kennDonut = new Donut();

            kennDonut.Filling = "Strawberry Jelly";
            kennDonut.Price = 0;
            kennDonut.Type = "Jelly";
            kennDonut.IsSpecial = false;

            jellyDonut.Filling = "Cherry Jelly";
            jellyDonut.Price = 7.99M;
            jellyDonut.Type = "Jelly";
            jellyDonut.IsSpecial = true;

            Console.WriteLine(jellyDonut);
            Console.ReadLine();
        }

    }
}
