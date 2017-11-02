using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._25_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How are you feeling today? 1-5");
            string feelingnumber = Console.ReadLine();

            if (feelingnumber == "5")
            {
                Console.WriteLine("Great to hear.");
            }
            else if (feelingnumber == "4")
            {
                Console.WriteLine("Not bad.");
            }
            else if (feelingnumber == "3")
            {
                Console.WriteLine("We could do better.");
            }
            else if (feelingnumber == "2")
            {
                Console.WriteLine("Ouch");
            }
            else if (feelingnumber == "1")
            {
                Console.WriteLine("Im Sorry");
            }
            Console.ReadLine();
            //Console.WriteLine("How are you feeling today from 1-5?");
            //string feelingNumber = Console.ReadLine();

            //// if else 
            //if (feelingNumber == "5")
            //{
            //    Console.WriteLine("That's great to hear!");
            //}
            //else if (feelingNumber == "4")
            //{
            //    Console.WriteLine("Good stuff!");
            //}
            //else if (feelingNumber == "3")
            //{
            //    Console.WriteLine("Hope things get better!");
            //}
            //else if (feelingNumber == "2")
            //{
            //    Console.WriteLine("Oh. Sorry to hear that.");
            //}
            //else if (feelingNumber == "1")
            //{
            //    Console.WriteLine("Dang. We hope your day gets better!");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, we don't understand. Come back later.");
            //}
        }
    }
}
