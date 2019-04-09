using Selection_4.Array;
using Selection_4.Math;
using System;

namespace Selection_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person");
            var Jody = new Person
            {
                FirstName = "Jody",
                LastName = "Sukma"
            };
            Jody.Introduce();

            Console.WriteLine("===========");
            Console.WriteLine("Kalkulator");
            Calculator calculator = new Calculator();
            var result = calculator.Add(3, 4);
            Console.WriteLine(result);

            Console.WriteLine("===========");
            Console.WriteLine("Array");
            ElementArray arr = new ElementArray();
            arr.Array();

            Console.WriteLine("===========");
            Console.WriteLine("Array String");
            StringArray arrStr = new StringArray();
            arrStr.ArrayString();

            Console.WriteLine("===========");
            Console.WriteLine("Enum");
            Enums enums = new Enums();
            enums.TryEnum();

            Console.WriteLine("===========");
            Console.WriteLine("Array");
            TypeAndValueType array = new TypeAndValueType();
            Person person = new Person();
            array.TypeOfInteger();
            Console.WriteLine();
            person.Umur();

            

            Console.ReadKey();
        }
    }
}
