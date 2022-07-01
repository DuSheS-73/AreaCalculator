namespace AreaCalculator.Shapes
{
    public sealed class Circle : IShape
    {
        public Circle(ulong radius)
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
