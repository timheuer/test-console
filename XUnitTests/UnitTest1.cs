using System;
using Xunit;

namespace XUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void SayHelloTest()
        {
            GreetingLib.Greetings greet = new GreetingLib.Greetings();
            var result = greet.SayHello("Tim");
            Assert.Equal("Hello Tim", result);
        }

        [Fact]
        public void RandomDoesntIncludeTest()
        {
            GreetingLib.Greetings greet = new GreetingLib.Greetings();
            for (int i = 0; i < 100; i++)
            {
                var result = greet.SaySomething("Tim");
                Assert.NotEqual("Hi there Tim", result);
            }
        }

        [Fact]
        public void RandomIncludesOnlyFromListTest()
        {
            GreetingLib.Greetings greet = new GreetingLib.Greetings();
            for (int i = 0; i < 1000; i++)
            {
                var prefix = greet.GetRandomGreeting();
                Assert.True(Array.IndexOf(greet.greetings, prefix) >= 0);
            }
        }
    }
}
