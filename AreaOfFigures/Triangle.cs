using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    public class Triangle
    {
        private double x, y, z;
        public Triangle(double x, double y, double z)
        {
            if (y + z < x || x + z < y || x + y < z)
            {
                throw new ArgumentException("Заданные стороны невозможны");
            }
            else if (x <= 0 || y <= 0 || z <= 0)
            {
                throw new ArgumentException("Заданные стороны меньше или равны нулю");
            }
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public double Calculate()
        {
            double halfPerimeter = (x + y + z) / 2;
            double areaP = halfPerimeter * (halfPerimeter - x) * (halfPerimeter - y) * (halfPerimeter - z);
            double area = Math.Round((Math.Sqrt(areaP)),1);
            return area;
        }
        public bool IsRightTriangle()
        {
            bool isRightTriangle = false;
            if (x > y && x > z)
            {
                double sumCathets = Math.Sqrt(Math.Pow(y,2) + Math.Pow(z,2));
                if (x == sumCathets)
                    isRightTriangle = true;

            }
            else if (y > x && y > z)
            {
                double sumCathets = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(z, 2));
                if (y == sumCathets)
                   isRightTriangle = true;
            }
            else if (z > x && z > y)
            {
                double sumCathets = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (z == sumCathets)
                    isRightTriangle = true;
            }
            return isRightTriangle;
            
        }
    }
}
