using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Game_Official
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constantiate
            //abstract class you can constantiate but you can make sub classes off of it 
            // Character myName = new Character();
            Player newHero = new Player();
            Enemy jenn = new Enemy();

            

            Console.WriteLine("Hello, wanderer.. \n" + "What be thy name?");
            newHero.Name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Nice to meet you, {newHero.Name}.");
            Console.ReadLine();

            Console.WriteLine($"Nice to meet you, {newHero.Name}.");

            Console.WriteLine("Whats your specialization friend?\n" +
                "1: Hourse Mange\n" +
                "2: Troll Cat\n" +
                "3: Knight Templatetor\n" +
                "4: Demogorg\n" +
                "5: Sire Cena");
            Player.Specialization = int.Parse(Console.ReadLine());
            
        }
    }
}
