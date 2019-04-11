using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_8
{
    public class Exercise
    {
        public void Exercise1()
        {
            Console.WriteLine("Enter a few numbers (eg 1-2-3-4): ");
            var strInput = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in strInput.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }
        }

        public void Exercise2()
        {
            Console.WriteLine("Enter a few numbers (eg 1-2-3-4): ");
            var strInput = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(strInput))
                return;

            var numbers = new List<int>();
            foreach (var number in strInput.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            var uniques = new List<int>();
            var includesDuplicates = false;

            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }
            if(includesDuplicates)
                Console.WriteLine("Duplicate");
        }

        public void Exercise3()
        {
            Console.Write("Enter time : ");
            var strInput = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(strInput))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = strInput.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if(hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch(Exception)
            { 
            Console.WriteLine("Invalid Time");
            }
        }

        public void Exercise4()
        {
            Console.Write("Enter a few words : ");
            var strInput = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(strInput))
            {
                Console.WriteLine("Error");
                return;
            }

            var variableName = "";
            foreach (var word in strInput.Split(' '))
            {
                var wordWithPasclCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPasclCase;
            }
            Console.WriteLine(variableName);
        }

        public void Exercise5()
        {
            Console.Write("Enter a word :");
            var strInput = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;

            foreach (var character in strInput)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }
            Console.WriteLine(vowelsCount);
        }
    }
}
