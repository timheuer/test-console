using System;

namespace GreetingLib
{
    public class Greetings
    {
        string[] greetings = new String[] { "Hello", "Goodbye", "G'day", "Cheers" };

        public string SaySomething(string inputName)
        {
            Random r = new Random();

            var greet = r.Next(0, greetings.Length - 1);

            return $"{greetings[greet]} {inputName}";
        }

        public string SayHello(string inputName) => $"Hello {inputName}";
    }
}
