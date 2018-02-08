using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int is a non nullable type
            // ? after type makes it nullable

            int? i = null;
            string name = null;

            bool? AreYouMajor = null;

            if (AreYouMajor == true)
            {
                Console.WriteLine("User is Major");
            }
            else if (AreYouMajor == false)
            {
                Console.WriteLine("User is not Major");
            }
            else
            {
                Console.WriteLine("User did not answer the question");
            }

            int? TicketsOnSale = 100;

            //int AvailableTickets;

            //if (TicketsOnSale == null)
            //{
            //    AvailableTickets = 0;
            //}
            //else
            //{
            //    AvailableTickets = TicketsOnSale.Value;
            //}

            //Console.WriteLine("Available Tickets = {0}", AvailableTickets);

            //Null Coalescing Operator

            int AvailableTickets = TicketsOnSale ?? 0;
            Console.WriteLine("AvailableTickets = {0}", AvailableTickets);

            Console.ReadLine();
        }
    }
}
