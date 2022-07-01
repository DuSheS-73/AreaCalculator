using AreaCalculator.Shapes;

namespace AreaCalculator.Helpers
{
    public sealed class ShapeDefinitionHelper
    {
        /// <summary>
        /// Define shape based on the number of values
        /// </summary>
        /// <param name="values"></param>
        /// <returns>Instance assignable from IShape</returns>
        /// <exception cref="ArgumentException">Throws if parameter is null or empty or values count doesn't match the quantity of declared shapes</exception>
        public IShape DefineShape(params double[] values)
        {
            if (values == null && values.Length == 0)
                throw new ArgumentException($"Parameter {nameof(values)} is Null or empty");

            return values.Length switch
            {
                1 => new Circle(values[0]),
                3 => new Triangle(values[0], values[1], values[2]),
                _ => throw new ArgumentException($"Cannot define shape for {values.Length} arguments");
            };
        }
    }
}
