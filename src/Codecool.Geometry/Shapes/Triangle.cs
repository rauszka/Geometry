using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Triangle implementation class
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        ///     Gets formula for the area of the triangle as a string.
        /// </summary>
        public new static string AreaFormula => throw new NotImplementedException();

        /// <summary>
        ///     Gets formula for the perimeter of the triangle as a string.
        /// </summary>
        public new static string PerimeterFormula => throw new NotImplementedException();

        /// <inheritdoc/>
        public override double Perimeter => throw new NotImplementedException();

        /// <inheritdoc />
        public override double Area => throw new NotImplementedException();
    }
}
