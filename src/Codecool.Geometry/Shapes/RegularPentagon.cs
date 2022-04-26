using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Regular Pentagon implementation class
    /// </summary>
    public class RegularPentagon : Shape
    {
        /// <summary>
        ///     Gets formula for the area of the pentagon as a string.
        /// </summary>
        public new static string AreaFormula => throw new NotImplementedException();

        /// <summary>
        ///     Gets formula for the perimeter of the pentagon as a string.
        /// </summary>
        public new static string PerimeterFormula => throw new NotImplementedException();

        /// <inheritdoc/>
        public override double Area => throw new NotImplementedException();

        /// <inheritdoc/>
        public override double Perimeter => throw new NotImplementedException();
    }
}
