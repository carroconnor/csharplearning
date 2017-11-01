using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._19_MethodOverloading
{
    class Player
    {

        public void Attack(int damage)
        {
            Console.WriteLine($" attacked for {damage}!");
        }

        public void Attack(int damage, string weapon)
        {
            Console.WriteLine($" attacked with {weapon} for {damage}!");
        }

        public void Attack(int damage, string weapon, int hitTimes)
        {
            int totalDamage = damage * hitTimes;
            Console.WriteLine($" attacked with {weapon} {hitTimes} times for {damage}!");
        }


    }

}
