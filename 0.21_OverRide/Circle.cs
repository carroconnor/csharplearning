using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._21_OverRide
{
    class Circle : Shape
    {
        //Constructor
        public Circle (int radius)
        {
            this.Radius = radius;
        }
        //Propperties
        public int Radius { get; set; }
        //Method
        public override double Area()
        {
            return Math.PI*(Math.Pow(this.Radius, 2));
        }



    }
}
