using System;

namespace Forforeachloops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[3];

            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;



            foreach (int k in Numbers)
            {
                Console.WriteLine(k);
                if (k == 102)
                    break;
            }

            for (int j = 0; j < Numbers.Length; j++)
            {
                Console.WriteLine(Numbers[j]);
            }

            int i = 0;
            while (i < Numbers.Length)
            {
                Console.WriteLine(Numbers[i]);
                i++;
            }

            for (int x = 0; x <= 20; x++)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
            }

            Console.ReadLine();
        }
    }
}
