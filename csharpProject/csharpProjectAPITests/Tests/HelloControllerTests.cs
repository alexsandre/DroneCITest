using NUnit.Framework;
using csharpProjectAPI.Controllers;
using System.Linq;
using System;

namespace csharpProjectAPITests
{
    public class HelloControllerTests
    {
        [Test]
        public void TestHelloControllerWithNameIsNull()
        {
            var controller = new HelloController();

            var response = controller.Get(null);

            Assert.AreEqual("Hello World", response);
        }
        
        [Test]
        public void TestHelloControllerWithNameIsEmpty()
        {
            var controller = new HelloController();

            var response = controller.Get(string.Empty);

            Assert.AreEqual("Hello World", response);
        }
        
        [Test]
        public void TestHelloControllerWithName()
        {
            var controller = new HelloController();

            string name = getRandomString(new Random().Next(1, 10));
            var response = controller.Get(name);

            Assert.AreEqual($"Hello {name}", response);
        }

        private string getRandomString(int size)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, size)
            .Select(s => s[new Random().Next(s.Length)]).ToArray());

        }
    }

}