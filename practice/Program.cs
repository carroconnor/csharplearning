using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 ||
                    i % 5 == 0)

                    sum += i;

            }

            Console.WriteLine(sum);

            int firstNum = 1;
            int secondNum = 1;
            int sum2 = 0;

            while (firstNum + secondNum < 4000000)
            {
                int temp = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = temp;

                if (temp % 2 == 0)
                    sum += temp;
                {

                }
            }

            Console.WriteLine(sum2);

            int prime = 1;
            int nextprime = 1;

            for (int i = 1; i < 600851475143; i++)
            {
                if (i % 1 == 0 && i % i == 0)
                {
                    i = prime;
                }

                else if (prime < i)
                {
                    i = nextprime;
                }

                Console.WriteLine(nextprime);
            }


        }
    }
}
