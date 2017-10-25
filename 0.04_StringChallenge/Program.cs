using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_StringChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname;
            string lname;
            fname = "Carr";
            lname = "OConnor";

            string fullname = lname + " " + fname;

            Console.WriteLine(fullname);



            //BRONZE
            double cash = 563.32;
            Console.WriteLine("{0:C}", cash);
            Console.ReadLine();

            //Phone Number
            int phoneNumber = 1234567890;
            Console.WriteLine("{0:(###) ### - ####}", phoneNumber);
            Console.ReadLine();
                

        }
    }
}
