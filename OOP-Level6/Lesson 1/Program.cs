using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            p.IdCard = "383838m";
            p.Name = "Emma";
            p.Surname = "Spiteri";

            Console.WriteLine("Please input address: ");
            p.Address = Console.ReadLine();

            Console.WriteLine(p.DelimitAddress(','));
            Console.WriteLine("Press a key to terminate app");
            Console.ReadKey();

        }
    }
}
