using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypesChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 25;
            int number2 = 50;

            string myName = "Carr";
            string lastName = "OConnor";

            bool myTruth = true;

            float myFloat = 3.14f;
            float yourFloat = 8.33f;

            double myDouble = 5.55;
            double yourDouble = 6.55;

            decimal myDecimal = 5.323423M;
            decimal yourDecimal = 4.232342M;


            //SILVER

            string fullName = "Carr" + "OConnor";
            Console.WriteLine(fullName);
          

            //GOLD
            string birthYear = "1980";
            int year = Convert.ToInt32(birthYear);

            string age = "30";

            int numAge = Convert.ToInt32(age);
            numAge = numAge + 1;

            Console.WriteLine(numAge);
            Console.ReadLine();
        }
    }
}
