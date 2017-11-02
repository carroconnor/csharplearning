using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._23_MyGame
{
    class Warrior
    {
        //Name Health Attack Maximum Block Maximum

        //Constructor

        //Random Numbers

        //Warrior capabilities (methods) attack blcok
        //generate random attack value from 1 to max

        public string Name { get; set; } =
            "Carr";
        public int Health { get; set; } = 0;
        public int AttkMax { get; set; } = 0;
        public int BlockMax { get; set; } = 0;

        Random rnd = new Random();

        public Warrior(string name = "Carr", int health = 0, int attack = 0, int block = 0)
        {
            Name = name;
            Health = health;
            AttkMax = attack;
            BlockMax = block;
        }

        public int Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }
        public int Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }


    }
}
