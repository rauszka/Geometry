using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Circle implementation class
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        ///     Gets formula for the area of the circle as a string.
        /// </summary>
        public new static string AreaFormula => throw new NotImplementedException();

        /// <summary>
        ///     Gets formula for the perimeter of the circle as a string.
        /// </summary>
        public new static string PerimeterFormula => throw new NotImplementedException();

        /// <inheritdoc />
        public override double Area => throw new NotImplementedException();

        /// <inheritdoc />
        public override double Perimeter => throw new NotImplementedException();
    }
}
