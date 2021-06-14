using System;

namespace Lab4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person("Cuong", "0999999999", "cuong@gmail.com");
            Console.WriteLine(person.ToString());
        }
    }
}