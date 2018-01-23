using System;

namespace _0._04_StringChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName;
            //string lastName;
            //fname = "Carr";
            //lname = "OConnor";

            ////BRONZE
            //double cash = 563.32;
            //Console.WriteLine("{0:C}", cash);
            //Console.ReadLine();

            ////Phone Number
            //int phoneNumber = 1234567890;
            //Console.WriteLine("{0:(###) ### - ####}", phoneNumber);
            //Console.ReadLine();

            string country = "USA";
            Console.WriteLine(country);

            string firstName = "Carr";
            string lastName = "OConnor";
            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName);

            string age = "30";
            int numAge = Convert.ToInt32(age);
            numAge = numAge + 1;

            Console.WriteLine(numAge);
            Console.ReadLine();
        }
    }
}
