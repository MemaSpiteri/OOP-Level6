using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSheet1;

namespace Lesson2
{
    class Program2
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Area is {c.GetArea()}");
            //Console.WriteLine("Area is " + c.GetArea()); //this is the same as the above just diff. methos to concat string with output
            //Console.WriteLine($"Perimeter is {c.GetPerimeter()}");
            
            //object (instance) ->> object is when you create a space in memory and you start assigning values to the template you created earlier
            Circle2 c = new Circle2(); //eg. of an object

            Console.WriteLine("Input a radius: ");
            c.Radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Area is {Math.Round(c.GetArea(), 2)}, Perimeter is{Math.Round(c.GetPerimeter(), 2)}");
            
            Console.WriteLine("Press key to terminate");
            Console.ReadKey();

        }
    }
}
