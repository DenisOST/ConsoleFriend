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

        [TestMethod]
        public void TestAnecdoteResponse()
        {

            StringAssert.Contains(Friend.GetResponse("Расскажешь анекдот?"), "анекдот");
        }

        [TestMethod]
        public void TestExamResponse()
        {

            StringAssert.Contains(Friend.GetResponse("Когда экзамен по Тестированию?"), "экзамен");
        }

        [TestMethod]
        public void ShouldExit_Variant1()
        {

            Assert.IsTrue(Friend.ShouldExit("пока"));
        }

        public void ShouldExit_Variant2()
        {

            Assert.IsTrue(Friend.ShouldExit("выход"));
        }
    }

}
