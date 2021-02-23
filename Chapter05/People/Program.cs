using System;
using static System.Console;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bob = new Person();
            var (name, count) = bob.GetFruit();
            WriteLine($"{name}, {count} there are.");
        }
    }
}
