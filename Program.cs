using System;

namespace test_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from remote clients!");
            Console.WriteLine("Enter your name: ");
            var input = Console.ReadLine();
            Console.WriteLine($"👋 {input}");
            Console.WriteLine("Well that's that!");
            Console.WriteLine("Hello again!");
            Console.ReadLine();
        }
    }
}
