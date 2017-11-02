using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._27_Interfaces_Collection_Pseudocode
{
    class ArrayClass : IEnum, IList, ICollect  
    {
        public void IterateOverCollection()
        {
            Console.WriteLine("Iterating over the array...");
        }

        public void AddStuff()
        {
            Console.WriteLine("Added stuff to array...");
        }

        public void RemoveStuff()
        {
            Console.WriteLine("Removed stuff from array...");
        }

        public void CheckTheCount()
        {
            Console.WriteLine("Check the count...");
        }

        public void CheckTheCapacity()
        {
            Console.WriteLine("You cant check the capacity of an array");
        }
    }
}
