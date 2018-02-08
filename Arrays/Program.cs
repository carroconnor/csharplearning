using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //type, array, name, asign, size
            int[] EvenNumbers = new int[3];

            EvenNumbers[0] = 0;
            EvenNumbers[1] = 2;
            EvenNumbers[2] = 4;

            Console.WriteLine(EvenNumbers[1]);
            Console.ReadLine();
        }
    }
}
