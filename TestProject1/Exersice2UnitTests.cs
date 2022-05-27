using NUnit.Framework;
using SimpleApp;

namespace TestProject1
{
    public class Exersice2UnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(Exersice2.TriangleType(1,1,1) == "Equilateral"); 

        }

        [Test]
        public void Test2()
        {
            Assert.IsTrue(Exersice2.TriangleType(2, 2, 3) == "Isosceles");

        }

        [Test]
        public void Test3()
        {
            Assert.IsTrue(Exersice2.TriangleType(2, 3, 4) == "Scalene");

        }

        [Test]
        public void Test4()
        {
            Assert.IsTrue(Exersice2.TriangleType(0, 1, 1) == "not valid");

        }

        [Test]
        public void Test5()
        {
            Assert.IsTrue(Exersice2.TriangleType(0, 0, 1) == "not valid");

        }
 

        [Test]
        public void Test6()
        {
            Assert.IsTrue(Exersice2.TriangleType(0, 0, 0) == "not valid");


        }

        [Test]
        public void Test7()
        {
            Assert.IsTrue(Exersice2.TriangleType(-1, 1, 1) == "not valid");

        }

        [Test]
        public void Test8()
        {
            Assert.IsTrue(Exersice2.TriangleType(-1, -1, 2) == "not valid");

        }

        [Test]
        public void Test9()
        {
            Assert.IsTrue(Exersice2.TriangleType(-1, -1, -1) == "not valid");
        }

    }
}