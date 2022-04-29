using AreaOfFigures;
using NUnit.Framework;

namespace TestOfFigures
{
    internal class TriangleTest
    {
        [Test]
        public void AreaOfTriangleTest()
        {
            Triangle triangle = new Triangle(3,4,5);

            double area = triangle.Calculate();

            Assert.AreEqual(6, area);
        }
        [Test]
        public void IsRightTriangleTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            bool isRightTriangle = triangle.IsRightTriangle();

            Assert.AreEqual(true, isRightTriangle);
        }
        [Test]
        public void AreaOfTriangleMethodTest()
        {
            double area;

            area = Area.GetAreaTriangle(3,4,5);

            Assert.AreEqual(6, area);
        }
        [Test]
        public void IsRightTriangleMethodTest()
        {
            bool isRightTriangle = false;

            isRightTriangle = Area.IsRightTriangle(3, 4, 5);

            Assert.AreEqual(true, isRightTriangle);
        }
    }
}
