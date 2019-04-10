using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_7
{
    public class DateAndTime
    {
        public void Introduce()
        {
            var dateTime = new DateTime(2019, 04, 10);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour : {0}", now.Hour);
            Console.WriteLine("Minute : {0}", now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }
    }
}
