 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._22_Inheritance
{
    class MainClass
    {
        class Animal
        {
            public string name { get; set; }
            public int age { get; set; }
            public float happiness { get; set; }

            public void PrintBase()
            {
                Console.WriteLine("name:" + name);
                Console.WriteLine("Age:" + age);
                Console.WriteLine("Happiness:" + happiness);
            }
        }

        class Dog : Animal
        {
            public int SpotCount { get; set; }
            public void Bark()
            {
                Console.WriteLine("WUF!");
            }
        }
        class Cat : Animal
        {
            public float Cuteness { get; set; }

            public void Meow()
            {
                Console.WriteLine("MEO!");
            }
        }
        static void Main(string[] args)
        {
            Dog spotty = new Dog();
            spotty.name = "spotty";
            spotty.age = 4;
            spotty.happiness = 8;
            spotty.SpotCount = 35;
            spotty.PrintBase();
            spotty.Bark();

            Cat catty = new Cat();
            catty.name = "Catty";
            catty.age = 3;
            catty.happiness = 4;
            catty.PrintBase();
            catty.Meow();


            Console.ReadLine();


        }
    }
}
