using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone newPhone = new Phone("Google", 6);
            Phone newPhone2 = new Phone("Samsung", 5);

            Console.WriteLine($"My phones are {newPhone.MakeMake} {newPhone.MakeMake}");
            Console.ReadLine();
        }
    }
}
