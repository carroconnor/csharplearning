﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._24_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART ONE: OVERRIDE
            //
            //Create an abstract class 'Shape'
            //that has an abstract method 'Area()'
            //
            //Create a class 'Triangle' that inherits
            //from Shape.
            //
            //'Triangle' should have a constructor that accepts
            //2 Parameters, TBase and THeight (as Int)
            //
            //Triangle should also have an Area property.
            //
            //Implement Area()
            //SIDENOTE: Area of Triangle = (1/2)*(Base)*(Height)
            //
            //Create 5 triangles, and use the Area() method
            //to set their Area property.

            Triangle triOne = new Triangle(3, 2);
            Triangle triTwo = new Triangle(12, 1);
            Triangle triThree = new Triangle(2, 4);
            Triangle triFour = new Triangle(6, 5);
            Triangle triFive = new Triangle(8, 3);

            triOne.Area();
            triTwo.Area();
            triThree.Area();
            triFour.Area();
            triFive.Area();

            IEnumerable<Triangle> triangles = new List<Triangle>
            {
                triOne,
                triTwo,
                triThree,
                triFour,
                triFive
               
            };

            IEnumerable<Triangle> query = from t in triangles
                                          where t.TArea > 4
                                          orderby t.TArea ascending
                                          select t;

            foreach (Triangle triangle in query)
            {
                Console.WriteLine(triangle.TArea);
            }



            Console.ReadLine();

        }
    }
}
