using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Rectangle implementation class
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        ///     Gets formula for the area of the rectangle as a string.
        /// </summary>
        public new static string AreaFormula => throw new NotImplementedException();

        /// <summary>
        ///     Gets formula for the perimeter of the rectangle as a string.
        /// </summary>
        public new static string PerimeterFormula => throw new NotImplementedException();

        /// <inheritdoc />
        public override double Area => throw new NotImplementedException();

        /// <inheritdoc />
        public override double Perimeter => throw new NotImplementedException();
    }
}
