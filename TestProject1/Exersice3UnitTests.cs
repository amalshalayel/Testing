using NUnit.Framework;
using SimpleApp;
using System.Collections.Generic;

namespace TestProject1
{
    public class Exersice3UnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(Exersice3.SearchByNameOrPhone("") == false);
        }

        [Test]
        public void Test2()
        {
            Assert.IsTrue(Exersice3.SearchByNameOrPhone("00112233") == true);


        }

        [Test]
        public void Test3()
        {
            Assert.IsTrue(Exersice3.SearchByNameOrPhone("2233") == true);


        }

        [Test]
        public void Test4()
        {
            Assert.IsTrue(Exersice3.SearchByNameOrPhone("Amal shalayel") == true);


        }

        [Test]
        public void Test5()
        {
            Assert.IsTrue(Exersice3.SearchByNameOrPhone("asd") == false);


        }


        [Test]
        public void Test6()
        {
            Assert.IsTrue(Exersice3.SearchByNameOrPhone("Amal") == true);

        }

        [Test]
        public void Test7()
        {
            Assert.IsTrue(Exersice3.SearchByNameOrPhone("Sara") == false);

        }
    }
}