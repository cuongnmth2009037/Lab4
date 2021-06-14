using System;

namespace Lab4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person("Cuong", "0964615565", "cuong@gmail.com");
            Console.WriteLine(person.ToString());
        }
    }
}