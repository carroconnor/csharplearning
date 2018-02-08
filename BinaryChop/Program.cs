using System;
using System.Linq;

namespace BinaryChop
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Search for a number");
            int userNum = Int32.Parse(Console.ReadLine());

            var numbers = Enumerable.Range(1, 1000).ToList();

            int min = 1;
            int max = 1000;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (userNum < 1 || userNum > 1000)
                {
                    Console.WriteLine("Not there dummy");
                }
                else if (userNum == numbers[mid])
                {
                    ++mid;
                }
                else if (userNum < numbers[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            Console.WriteLine();

            Console.WriteLine("Search for a number");
            int userNum2 = Int32.Parse(Console.ReadLine());

            int max2 = numbers.Max() - 1;

            if (min > max)
            {
                Console.WriteLine("not there dummy");
            }
            else
            {
                int mid = (min + max) / 2;
                if (userNum2 == numbers[mid])
                {
                    ++mid;
                }
                else if (userNum2 < numbers[mid])
                {
                    (numbers, userNum2, min, mid - 1);
                }
                else
                {
                    (numbers, userNum2, mid + 1, max);
                }
            }
        }
    }
}
