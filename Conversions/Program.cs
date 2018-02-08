using System;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int i = 100;

            //    float f = i;

            //    //float is bigger than int so there is no problem

            //    Console.WriteLine(f);

            //    float x = 123.45F;

            //    //cast operator, will lose values after .
            //    //int e = (int)x;


            //    int e = Convert.ToInt32(x);

            //    Console.WriteLine(e);
            //    Console.ReadLine();

            //float f = 127373343433.45F;

            //int i = Convert.ToInt32(f);

            //Console.WriteLine(i);

            //string strNumber = "100TG";

            //int i = int.Parse(strNumber);
            //Console.WriteLine(i);
            //Console.ReadLine();

            //TRYPARSEMETHOD

            string strNumber = "100TG";

            int Result = 0;

            bool IsConversionSuccessful = int.TryParse(strNumber, out Result);

            if (IsConversionSuccessful)
            {
                Console.WriteLine(Result);
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
            Console.ReadLine();

            // Parse() method throws an exception if it cannot parse the value
            // whereas TryParse() returns a bool indicating whether it
            // succeeded or failed
            // use Parse() if you are sure the value will be valid, otherwise use TryParse()

        }
    }
}
