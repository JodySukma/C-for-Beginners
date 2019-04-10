using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_5
{
    public class RandomClass
    {
        public void ExRandom()
        {
            var random = new Random();
            for (var i = 0; i <= 10; i ++)
                Console.WriteLine(random.Next(1, 10));

            for (var i = 0; i <= 10; i++)
                Console.Write((char)('a' + random.Next(0, 26)));

            const int passowordLenght = 10;
            var buffer = new char[passowordLenght];
            for (var i = 0; i <= passowordLenght; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
