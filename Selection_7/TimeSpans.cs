using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_7
{
    public class TimeSpans
    {
        public void Introduce()
        {
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration : {0}", duration);

            // properties
            Console.WriteLine("Minutes : {0}", timeSpan.Minutes);
            Console.WriteLine("Total Minutes : {0}", timeSpan.TotalMinutes);

            // add
            Console.WriteLine("Add Example : {0}", timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example : {0}", timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // ToString
            Console.WriteLine("To String : {0}", timeSpan.ToString());

            // parse
            Console.WriteLine("Parse : {0}", TimeSpan.Parse("01:02:03"));

        }
    }
}
