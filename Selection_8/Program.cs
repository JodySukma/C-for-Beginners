using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example Method String");
            var sentence = "This is going to be a really really really really long text.";
            var summary = SummarisingText.SummerizeText(sentence, 25);
            Console.WriteLine(summary);

            Console.WriteLine("=======================");
            Console.WriteLine("Example String Builder");

            StringBuilders sb = new StringBuilders();
            sb.stringBuliders();

            Console.WriteLine("=======================");
            Console.WriteLine("Exercise");
            Exercise lat = new Exercise();
            Console.WriteLine("=======================");
            Console.WriteLine("Exercise 1");
            lat.Exercise1();
            Console.WriteLine("=======================");
            Console.WriteLine("Exercise 2");
            lat.Exercise2();
            Console.WriteLine("=======================");
            Console.WriteLine("Exercise 3");
            lat.Exercise3();
            Console.WriteLine("=======================");
            Console.WriteLine("Exercise 4");
            lat.Exercise4();
            Console.WriteLine("=======================");
            Console.WriteLine("Exercise 5");
            lat.Exercise5();

            Console.ReadKey();
        }

    }
}
