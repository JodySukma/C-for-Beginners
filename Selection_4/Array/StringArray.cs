using System;

namespace Selection_4.Array
{
    public class StringArray
    {
        public void ArrayString()
        {
            var firstName = "Jody";
            var lastName = "Sukma";
            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Iwan", "Budi", "Yanto" };
            var formatedNames = string.Join(",", names);
            Console.WriteLine(formatedNames);

            Console.WriteLine("==========");
            Console.WriteLine("Path String");

            var text = @"Hi Iwan
Look into the following path
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
