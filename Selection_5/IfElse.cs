using System;

namespace Selection_5
{
    public class IfElse
    {
        public void ElseIf()
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
                Console.WriteLine("It's Morning");
            else if (hour >= 12 && hour < 18)
                Console.WriteLine("It's Afternoon");
            else
                Console.WriteLine("It's Evening");
        }

    }
}
