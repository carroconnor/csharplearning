using System;

namespace _0._19_MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player me = new Player();
            me.Attack(2500);
            me.Attack(1000, "dusty stick");
            me.Attack(500, "Katana", 90);
            Console.WriteLine(me);
            Console.ReadLine();
        }
    }
}
