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
            Donut carrDonut = new Donut();
            Donut chrisDonut = new Donut();
            Donut nickDonut = new Donut();

            carrDonut.Filling = "cherry";
            carrDonut.Price = 3;
            carrDonut.Type = "normal";
            carrDonut.IsSpecial = true;

            chrisDonut.Filling = "chocolate";
            chrisDonut.Price = 2;
            chrisDonut.Type = "small";
            chrisDonut.IsSpecial = false;

            nickDonut.Filling = "cherry";
            nickDonut.Price = 5;
            nickDonut.Type = "normal";
            nickDonut.IsSpecial = true;

            Console.WriteLine(nickDonut);

            
            //Donut jellyDonut = new Donut();
            //Donut kennDonut = new Donut();

            //kennDonut.Filling = "Strawberry Jelly";
            //kennDonut.Price = 0;
            //kennDonut.Type = "Jelly";
            //kennDonut.IsSpecial = false;

            //jellyDonut.Filling = "Cherry Jelly";
            //jellyDonut.Price = 7.99M;
            //jellyDonut.Type = "Jelly";
            //jellyDonut.IsSpecial = true;

            //Console.WriteLine(jellyDonut);
            Console.ReadLine();
        }

    }
}
