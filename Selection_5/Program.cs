using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Condisional kondisi = new Condisional();
            Console.WriteLine("this is hour");
            kondisi.Hour();
            Console.WriteLine("==============");
            Console.WriteLine("This is customer state");
            kondisi.CustomerState();

            Loops pengulangan = new Loops();
            Console.WriteLine("Example For");
            pengulangan.For();
            Console.WriteLine("==============");
            Console.WriteLine("Example Foreach");
            pengulangan.Foreach();

            Console.WriteLine("==============");
            Console.WriteLine("Example While Loops");
            pengulangan.WhileLoops();
            Console.WriteLine();

            Console.WriteLine("==============");
            Console.WriteLine("Example Switch");
            var season = Season.Autumn;

            switch (season)
            {
                //case Season.Autumn:
                //    Console.WriteLine("It's autumn and beautifull season.");
                //    break;

                //case Season.Summer:
                //    Console.WriteLine("It's perfect to go to beach.");
                //    break;

                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We ve got promotion");
                    break;

                default:
                    Console.WriteLine("I dont understand that season !");
                    break;
            }

            Console.WriteLine("Exercise Selection 5");
            Exercise lat = new Exercise();
            Console.WriteLine("Exercise 1");
            lat.Exercise1();
            Console.WriteLine("===========");
            Console.WriteLine("Exercise 2");
            lat.Exercise2();
            Console.WriteLine("===========");
            Console.WriteLine("Exercise 3");
            lat.Exercise3();
            Console.WriteLine("===========");
            Console.WriteLine("Exercise 4");
            lat.Exercise4();
            Console.WriteLine("===========");
            Console.WriteLine("Exercise 5");
            lat.Exercise5();
        }
    }
}
