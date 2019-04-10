using System;

namespace Selection_5
{
    public class Exercise
    {
        public void Exercise1()
        {
            var count = 0;
            for (var i = 0; i <= 100; i++)
                if (i % 3 == 0)
                    count++;

            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);
        }

        public void Exercise2()
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or 'ok' to exit) : ");
                var strInput = Console.ReadLine();

                if (strInput.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(strInput);
            }
            Console.WriteLine("Sum of all numbers is : {0}", sum);
        }

        public void Exercise3()
        {
            Console.Write("Enter a number : ");
            var number = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine("{0}! = {1}", number, factorial);
        }

        public void Exercise4()
        {
            var number = new Random().Next(1, 10);

            Console.WriteLine("Secret is {0}", number);
            for (var i = 0; i < 4; i++)
            {
                Console.Write("Guess the secret number : ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You won !");
                    return;
                }
            }
            Console.WriteLine("You lost !");
        }

        public void Exercise5()
        {
            Console.Write("Enter comma separated numbers : ");
            var strInput = Console.ReadLine();

            var numbers = strInput.Split(',');

            var max = Convert.ToInt32(numbers[0]);
            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }
            Console.WriteLine("Max is {0}", max);
        }
    }
}
