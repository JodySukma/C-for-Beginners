using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateAndTime DT = new DateAndTime();
            Console.WriteLine("Example Date Time");
            DT.Introduce();

            TimeSpans TS = new TimeSpans();
            Console.WriteLine("=================");
            Console.WriteLine("Example Time Span");
            TS.Introduce();

            Console.ReadKey();
        }
    }
}
