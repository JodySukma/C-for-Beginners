using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays arrSingleDimen = new Arrays();
            Console.WriteLine("Example Array Single Dimentions");
            arrSingleDimen.ArraySingleDimen();

            Lists list = new Lists();
            Console.WriteLine("=============");
            Console.WriteLine("Example Lists");
            list.AddToList();

            Exercise lat = new Exercise();
            Console.WriteLine("=============");
            Console.WriteLine("Exercise 1");
            lat.Exercise1();

            Console.WriteLine("=============");
            Console.WriteLine("Exercise 2");
            lat.Exercise2();

            Console.WriteLine("=============");
            Console.WriteLine("Exercise 3");
            lat.Exercise3();

            Console.WriteLine("=============");
            Console.WriteLine("Exercise 4");
            lat.Exercise4();

            Console.WriteLine("=============");
            Console.WriteLine("Exercise 5");
            lat.Exercise5();
        }
    }
}
