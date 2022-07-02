namespace AreaCalculator.Shapes
{
    public sealed class Circle : IShape
    {
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException($"{nameof(radius)} cannot be less than 0");

            Radius = radius;
        }

        public double Radius { get; }

        public double CalculateArea()
        {
            return Math.PI * Radius *Radius;
        }
    }
}
