namespace AreaCalculator.Shapes
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; }

        public double CalculateArea()
        {
            return Math.PI * Radius *Radius;
        }
    }
}
