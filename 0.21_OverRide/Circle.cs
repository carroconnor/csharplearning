﻿using System;

namespace _0._21_OverRide
{
    class Circle : Shape
    {
        //Constructor
        public Circle(int radius)
        {
            this.Radius = radius;
        }
        //Propperties
        public int Radius { get; set; }
        //Method
        public override double Area()
        {
            return Math.PI * (Math.Pow(this.Radius, 2));
        }
    }
}
