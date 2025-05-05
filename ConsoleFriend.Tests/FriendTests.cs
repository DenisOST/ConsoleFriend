using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleFriend.Tests
{
    [TestClass]
    public class FriendTests
    {
        [TestMethod]
        public void TestGreeting()
        {
            var result = Friend.GetGreeting("Олег");
            Assert.AreEqual("Привет, Олег! Как дела?", result);
        }

        [TestMethod]
        public void TestWeatherResponse()
        {
            
            StringAssert.Contains(Friend.GetResponse("Какая сегодня погода?"), "ясно");
        }
    }

}
