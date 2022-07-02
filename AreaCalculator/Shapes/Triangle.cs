namespace AreaCalculator.Shapes
{
    public sealed class Triangle : IShape
    {
        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException($"Side length cannot be less than 0");

            double[] sides = new double[] { a, b, c };
            Array.Sort(sides);

            if (sides[2] > sides[0] + sides[1])
                throw new ArgumentException("One side of a triangle is greater than the sum of the other two sides. Such a triangle cannot exist.");

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
            return Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
        }

        public bool IsEquilateral()
        {
            return A == B && A == C;
        }
    }
}
