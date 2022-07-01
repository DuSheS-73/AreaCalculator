namespace AreaCalculator.Shapes
{
    public sealed class Triangle : IShape
    {
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double A { get; }
        public double B { get; }
        public double C { get; }


        public double CalculateArea()
        {
            double semiPerimeter = (A + B + C) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter * C));
        }

        public bool IsEquilateral()
        {
            return A == B && A == C;
        }
    }
}
