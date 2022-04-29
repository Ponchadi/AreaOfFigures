using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    public static class Area
    {
        public static double GetAreaCircle(double radius)
        {
            return new Circle(radius).Calculate();
        }
        public static double GetAreaTriangle(double x, double y, double z)
        {
            return new Triangle(x, y, z).Calculate();
        }
        public static bool IsRightTriangle(double x, double y, double z)
        {
            return new Triangle(x, y, z).IsRightTriangle();
        }
    }
}
