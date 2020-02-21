using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            var result = greet.SaySomething("Tim");
            Assert.AreNotEqual("Hi there Tim", result);
        }
    }
}
