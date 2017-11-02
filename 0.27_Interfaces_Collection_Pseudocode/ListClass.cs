using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._27_Interfaces_Collection_Pseudocode
{
    class ListClass : IEnum, IList, ICollect
    {
        public void AddStuff()
        {
            Console.WriteLine("Added some stuff");
        }

        public void CheckTheCapacity()
        {
            Console.WriteLine("Check the capacity");
        }

        public void CheckTheCount()
        {
            Console.WriteLine("Check the coutn");
        }

        public void IterateOverCollection()
        {
            Console.WriteLine("Check the collection");
        }

        public void RemoveStuff()
        {
            Console.WriteLine("Removed some stuff");
        }
    }
}
