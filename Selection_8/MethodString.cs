using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_8
{
    public class MethodString
    {
        public void FungsiString()
        {
            var fullName = "Jodi Sukma Atmadja";
            Console.WriteLine("Trim : '{0}'", fullName.Trim());
            Console.WriteLine("Trim : '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name : {0}", firstName);
            Console.WriteLine("Last Name : {0}", lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First Name : {0}", names[0]);
            Console.WriteLine("Last Name : {0}", names[1]);

            Console.WriteLine(fullName.Replace("Jodi", "Jody"));

            if(String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
        }
    }
}
