using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSheet1
{
    class Circle2
    {
        //constructor - bears the same name as the class - when you create a class it's alreasy there - just hidden
        // - which is used to create an instance of a class(the object) - secondary objects of a construct : it can be used as a normal methos

        //Contructor can have parameters as well 
        //public Circle2(double radius, String color) //constructor
        //{
        //    Radius = radius;
        //    Color = color;
        //}
        public Circle2() //constructor is like the key to start the class / the key to initialize the object
        {
            Radius = 0;
            Color = "Black";
        }
        public double Radius { get; set; }

        public string Color { get; set; }

        public string GetRadius()
        {
            return "Radius: " + Radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }


    }
}
