using AreaCalculator.Helpers;
using AreaCalculator.Shapes;

namespace UnitTests.HelpersTests
{
    public class ShapeDefinitionHelperTest
    {
        [Fact]
        public void ShapeDefinitionHelper_DefineShape()
        {
            var shapeDefinitionHelper = new ShapeDefinitionHelper();

            Assert.True(shapeDefinitionHelper.DefineShape(25) is Circle);
            Assert.False(shapeDefinitionHelper.DefineShape(25, 25, 25) is Circle);

            Assert.False(shapeDefinitionHelper.DefineShape(25) is Triangle);
            Assert.True(shapeDefinitionHelper.DefineShape(25, 25, 25) is Triangle);
        }
    }
}
