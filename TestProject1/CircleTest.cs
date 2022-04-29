using AreaOfFigures;
using NUnit.Framework;

namespace TestOfFigures
{
    public class CircleTest
    {
        [Test]
        public void AreaOfCircleTest()
        {
            Circle circle = new Circle(10);

            double area = circle.Calculate();

            Assert.AreEqual(314.2, area);
        }
        [Test]
        public void AreaOfCircleMethodTest()
        {
            double area;
            
            area = Area.GetAreaCircle(10);

            Assert.AreEqual(314.2,area);
        }
    }
}