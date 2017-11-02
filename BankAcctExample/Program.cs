using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcctExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = 10000;
            var debt = 4200;
            var difference = bankAccount - debt;

            Console.WriteLine(difference);

            Console.WriteLine($"I have {bankAccount} in my bank account and I am {debt} in debt.");

            if (difference >= 700 && difference <= 1999)
            {
                Console.WriteLine($"I have extra money.  I should pay off my debt.  Ill have ${difference} left");
            }
            else if (bankAccount - debt > 2000)
            {
                Console.WriteLine($"I have a ton of extra money");
            }
            Console.ReadLine();
            //Console.WriteLine("Is your bank account more or less than 10000$?");
            //int bankAmount = Convert.ToInt32(Console.ReadLine());
            //if (bankAmount = "10000");
            //{
            //    Console.WriteLine("That's great to hear!");
            //}
        }
    }
}
