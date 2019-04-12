using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_10
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleDebug1 debug1 = new ExampleDebug1();
            Console.WriteLine("Debug log : ");
            debug1.start();

            Console.ReadKey();
        }
    }
}
