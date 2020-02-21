using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SayHelloTest()
        {
            GreetingLib.Greetings greet = new GreetingLib.Greetings();
            var result = greet.SayHello("Tim");
            Assert.AreEqual("Hello Tim", result);
        }

        [TestMethod]
        public void RandomDoesntIncludeTest()
        {
            GreetingLib.Greetings greet = new GreetingLib.Greetings();
            for (int i = 0; i < 100; i++)
            {
                var result = greet.SaySomething("Tim");
                Assert.AreNotEqual("Hi there Tim", result);
            }
        }

        [TestMethod]
        public void RandomIncludesOnlyFromListTest()
        {
            GreetingLib.Greetings greet = new GreetingLib.Greetings();
            for (int i = 0; i < 10000000; i++)
            {
                var prefix = greet.GetRandomGreeting();
                Assert.IsTrue(Array.IndexOf(greet.greetings, prefix) >= 0);
            }
        }
    }
}
