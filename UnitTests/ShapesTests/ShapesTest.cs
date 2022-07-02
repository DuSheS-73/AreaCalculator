using AreaCalculator.Shapes;

namespace UnitTests.ShapesTests
{
    public class ShapesTest
    {
        [Fact]
        public void Circle_CalculateArea()
        {
            IShape circle1 = new Circle(1);
            IShape circle2 = new Circle(37498);
            IShape circle3 = new Circle(71.123456);

            double area1 = circle1.CalculateArea();
            double area2 = circle2.CalculateArea();
            double area3 = circle3.CalculateArea();

            Assert.Equal(Math.Round(Math.PI, 6), Math.Round(area1, 6));
            Assert.Equal(4417393442.778978, Math.Round(area2, 6));
            Assert.Equal(15891.890931, Math.Round(area3, 6));
        }

        [Fact]
        public void Triangle_CalculateArea()
        {
            IShape triangle1 = new Triangle(1, 1, 1);
            IShape triangle2 = new Triangle(1.1, 1.1, 1.1);
            IShape triangle3 = new Triangle(25, 50, 25);
            IShape triangle4 = new Triangle(13, 255, 250);

            double area1 = triangle1.CalculateArea();
            double area2 = triangle2.CalculateArea();
            double area3 = triangle3.CalculateArea();
            double area4 = triangle4.CalculateArea();

            Assert.Equal(0.433013, Math.Round(area1, 6));
            Assert.Equal(0.523945, Math.Round(area2, 6));
            Assert.Equal(0, Math.Round(area3, 6));
            Assert.Equal(1514.497937, Math.Round(area4, 6));
        }

        [Fact]
        public void Triangle_IsEquilateral()
        {
            var triangle1 = new Triangle(25, 25, 25);
            var triangle2 = new Triangle(25.555666, 25.555666, 25.555666);
            var triangle3 = new Triangle(25.555666, 25.555667, 25.555666);
            var triangle4 = new Triangle(25, 50, 25);
            var triangle5 = new Triangle(13, 16, 27);

            Assert.True(triangle1.IsEquilateral());
            Assert.True(triangle2.IsEquilateral());
            Assert.False(triangle3.IsEquilateral());
            Assert.False(triangle4.IsEquilateral());
            Assert.False(triangle5.IsEquilateral());
        }
    }
}