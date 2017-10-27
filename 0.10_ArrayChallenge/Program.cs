using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ArrayChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] food = new string[3];
            //food[0] = "pasta";
            //food[1] = "pizza";
            //food[2] = "cereal";

            //foreach (string a in food)
            //Console.WriteLine(a);
            //Console.ReadLine();

            //SILVER

            //int[] number = new int[5] { 3, 4, 4, 5, 5 };


            //int[] number2 = new int[5] { 7, 2, 43, 2, 12 };


            //int[] number3 = new int[5];

            //for (int i = 0; i < number3.Length; i++)
            //{
            //    number3[i] = number[i] + number2[i];
            //}
            //{
            //    Console.WriteLine(number3.Length);
            //    Console.ReadLine();
            //}


            // Gold Challenge

            int[] randsomNumbers = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < randsomNumbers.Length; i++)
            {
                randsomNumbers[i] = rnd.Next();
            }
            foreach (int number in randsomNumbers)
            {
                Console.WriteLine(number);
                Console.ReadLine();
                
            }



        }
    }
}
