using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88;
            object name = "John";
            Console.WriteLine($"{name} is {height} meters tall");
            int length1 = ((string)name).Length;
        }
    }
}
