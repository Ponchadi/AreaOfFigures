namespace AreaOfFigures
{
    public class Circle
    {
        private double radius;
        public Circle(double radius)
        {
            if (!(radius <= 0))
                this.radius = radius;
            else
                throw new ArgumentException("Радиус меньше или равен 0");
        }
        public double Calculate()
        {
            double area = Math.Round((Math.PI * Math.Pow(radius, 2)),1);
            return area;
        }
    }
}