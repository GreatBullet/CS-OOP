using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Person POP = new Person("Barney", "Stinson");
            while (!POP.HatHunger)
            {
                Console.WriteLine(POP.Energie);
                POP.Laufe(50);
                if (POP.Energie <= 0)
                    POP.HatHunger = true;
            }

            Console.WriteLine(POP.Energie);
            Console.ReadKey();
        }
    }
}
