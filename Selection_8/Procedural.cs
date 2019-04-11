using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_8
{
    public class Procedural
    {
        public void Example1()
        {
            Console.Write("What's your name ? ");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine("Reversed name : {0}", reversed);
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            return new string(array);
        }

        public void Example2()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (or 'Quit' to exit) : ");
                var strInput = Console.ReadLine();

                if (strInput.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(strInput));
            }
            
            Console.WriteLine("Unique numbers : ");
            foreach(var number in GetUniqueNumbers(numbers))
                Console.WriteLine(number);
        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var unique = new List<int>();
            foreach (var number in numbers)
            {
                if (!unique.Contains(number))
                    unique.Add(number);
            }

            return unique;
        }
    }
}
