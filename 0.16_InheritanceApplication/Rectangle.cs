using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_InheritanceApplication
{
    class Rectangle:Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }
}
