using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            var person1 = new Person(5);
            Console.WriteLine(person1.Age);
            Console.WriteLine(person1.Name);

            var person3 = new Person("Pesho", 10);
            Console.WriteLine(person3.Age);
            Console.WriteLine(person3.Name);
        }
    }
}
