using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_6
{
    public class Exercise
    {
        public void Exercise1()
        {
            var names = new List<string>();

            while (true)
            {
                Console.Write("Type a name (or hit ENTER to quit): ");

                var strInput = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(strInput))
                    break;
                names.Add(strInput);
            }

            if(names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            else if(names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if(names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else
                Console.WriteLine();
        }

        public void Exercise2()
        {
            Console.Write("What's your names? ");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            Console.WriteLine("Reversed name : {0}", reversed);
        }

        public void Exercise3()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.Write("Enter a number : ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previously entered {0}", number);
                    continue;
                }
                numbers.Add(number);
            }
            numbers.Sort();

            foreach(var number in numbers)
                Console.WriteLine(number);
        }

        public void Exercise4()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (or 'Quit' to exit): ");
                var strInput = Console.ReadLine();

                if (strInput.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(strInput));
            }

            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            Console.WriteLine("Unique numbers : ");
            foreach(var number in numbers)
                Console.WriteLine(number);
        }

        public void Exercise5()
        {
            string[] elements;
            while(true)
            {
                Console.Write("Enter a list of comma-separated numbers : ");
                var strInput = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(strInput))
                {
                    elements = strInput.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smalles numbers are : ");
            foreach(var number in smallests)
                Console.WriteLine(number);
        }
    }
}
