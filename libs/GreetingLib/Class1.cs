using System;

namespace GreetingLib
{
    public class Greetings
    {
        public string[] greetings = new string[] { "Hello", "Goodbye", "G'day", "Cheers" };

        public string SaySomething(string inputName)
        { 
            return $"{GetRandomGreeting()} {inputName}";
        }

        public string GetRandomGreeting()
        {
            Random r = new Random();
            return greetings[r.Next(0, greetings.Length - 1)];
        }

        public string SayHello(string inputName) => $"Hello {inputName}";
    }
}
