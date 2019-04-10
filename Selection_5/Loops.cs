using System;

namespace Selection_5
{
    public class Loops
    {
        public void For()
        {
            for (var i = 1; i <= 10; i++)
            {
                if(i % 2 == 0)
                    Console.WriteLine(i);
            }

            for (var i = 10; i >= 1; i--)
            {
                if(i % 2 == 0)
                    Console.WriteLine(i);
            }
        }

        public void Foreach()
        {
            var name = "Jody Sukma";
            var numbers = new int[] { 1, 2, 3, 4 };

            //for(var i = 0; i < name.Length; i++)
            //    Console.WriteLine(name[i]);

            foreach(var character in name)
                Console.WriteLine(character);

            foreach(var number in numbers)
                Console.WriteLine(number);
        }

        public void WhileLoops()
        {
            //for(var i = 1; i <= 10; i++)
            //    if(i % 2 == 0)
            //        Console.WriteLine(i);

            //var i = 0;
            //while (i <= 0)
            //{
            //    if(i % 2 == 0)
            //        Console.WriteLine(i);

            //    i++;
            //}

            while (true)
            {
                Console.WriteLine("Input your name : ");
                var strInput = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(strInput))
                {
                    Console.WriteLine("@ehco : {0}", strInput);
                    continue;
                }
                break;
            }
        }

    }
}
