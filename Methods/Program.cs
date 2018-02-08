using System;

namespace Methods
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.EvenNumber(30);
            int sum = p.Add(10, 20);

            Console.WriteLine("Sum = {0}", sum);
            Console.ReadLine();

        }


        public int Add(int first, int second)
        {
            return first + second;
        }

        public void EvenNumber(int Target)
        {
            int Start = 0;

            while (Start <= Target)
            {
                Console.WriteLine(Start);
                Start = Start + 2;
                Console.ReadLine();
            }
        }
    }
}
