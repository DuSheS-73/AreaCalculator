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

            double area1 = circle1.CalculateArea();
            double area2 = circle2.CalculateArea();

            Assert.Equal(Math.Round(Math.PI, 6), Math.Round(area1, 6));
            Assert.Equal(4417393442.778978, Math.Round(area2, 6));
        }

        [Fact]
        public void Triangle_CalculateArea()
        {
            IShape triangle1 = new Triangle(1, 1, 1);
            IShape triangle2 = new Triangle(25, 50, 25);
            IShape triangle3 = new Triangle(13, 255, 250);

            double area1 = triangle1.CalculateArea();
            double area2 = triangle2.CalculateArea();
            double area3 = triangle3.CalculateArea();

            Assert.Equal(0.433013, Math.Round(area1, 6));
            Assert.Equal(0, Math.Round(area2, 6));
            Assert.Equal(1514.497937, Math.Round(area3, 6));
        }

        [Fact]
        public void Triangle_IsEquilateral()
        {
            IShape triangle1 = new Triangle(25, 25, 25);
            IShape triangle2 = new Triangle(25, 50, 25);
            IShape triangle3 = new Triangle(13, 16, 27);

            bool isEquilateral1 = ((Triangle)triangle1).IsEquilateral();
            bool isEquilateral2 = ((Triangle)triangle2).IsEquilateral();
            bool isEquilateral3 = ((Triangle)triangle3).IsEquilateral();

            Assert.True(isEquilateral1);
            Assert.False(isEquilateral2);
            Assert.False(isEquilateral3);
        }
    }
}