using NUnit.Framework;
using SimpleApp;

namespace TestProject1
{
    public class Exersice2UnitTestsCopy1
    {
        [SetUp]
        public void Setup()
        {
        }

        [Ignore("")]
        [Test]
        public void Test1()
        {
            Assert.IsTrue(Exersice2Copy1.TriangleType(1,1,1) == "Equilateral"); 

        }
        [Ignore("")]

        [Test]
        public void Test2()
        {
            Assert.IsTrue(Exersice2Copy1.TriangleType(2, 2, 3) == "Isosceles");

        }
        [Ignore("")]

        [Test]
        public void Test3()
        {
            Assert.IsTrue(Exersice2Copy1.TriangleType(2, 3, 4) == "Scalene");

        }

        [Test]
        public void Test4()
        {
            Assert.IsTrue(Exersice2Copy1.TriangleType(0, 1, 1) == "not valid");

        }

        [Test]
        public void Test5()
        {
            Assert.IsTrue(Exersice2Copy1.TriangleType(0, 0, 1) == "not valid");

        }
 

        [Test]
        public void Test6()
        {
            Assert.IsTrue(Exersice2Copy1.TriangleType(0, 0, 0) == "not valid");


        }

        [Test]
        public void Test7()
        {
            Assert.IsTrue(Exersice2Copy1.TriangleType(-1, 1, 1) == "not valid");

        }

        [Test]
        public void Test8()
        {
            Assert.IsTrue(Exersice2Copy1.TriangleType(-1, -1, 2) == "not valid");

        }

        [Test]
        public void Test9()
        {
            Assert.IsTrue(Exersice2Copy1.TriangleType(-1, -1, -1) == "not valid");
        }

    }
}