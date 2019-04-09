using System;

namespace Selection_4
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public int Age;

        public void Umur()
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }   
    }
}
