using NUnit.Framework;
using SimpleApp;

namespace TestProject1
{
    public class Exersice1UnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(Exersice1.ReplaceWhiteSpaces("") == "");
        }

        [Test]
        public void Test2()
        {
            Assert.IsTrue(Exersice1.ReplaceWhiteSpaces(" ") == " ");
        }

        [Test]
        public void Test3()
        {
            Assert.IsTrue(Exersice1.ReplaceWhiteSpaces("   ") == " ");
        }

        [Test]
        public void Test4()
        {
            Assert.IsTrue(Exersice1.ReplaceWhiteSpaces("a") == "a");
        }

        [Test]
        public void Test5()
        {
            Assert.IsTrue(Exersice1.ReplaceWhiteSpaces(" a") == " a");
        }

        [Test]
        public void Test6()
        {
            Assert.IsTrue(Exersice1.ReplaceWhiteSpaces("a ") == "a ");
        }

        [Test]
        public void Test7()
        {
            Assert.IsTrue(Exersice1.ReplaceWhiteSpaces("a a") == "a a");
        }

        [Test]
        public void Test8()
        {
            Assert.IsTrue(Exersice1.ReplaceWhiteSpaces("   a") == " a");
        }

        [Test]
        public void Test9()
        {
            Assert.IsTrue(Exersice1.ReplaceWhiteSpaces("a   ") == "a ");
        }

        [Test]
        public void Test10()
        {
            Assert.IsTrue(Exersice1.ReplaceWhiteSpaces("a   a") == "a a");
        }

        [Test]
        public void Test11()
        {
            Assert.IsTrue(Exersice1.ReplaceWhiteSpaces("hello     world   test") == "hello world test");
        }



    }
}