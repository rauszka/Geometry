using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Circle implementation class
    /// </summary>
    public class Circle : Shape
    {
        private double _radius;
        private static string _areaFormula = "π×r×r";
        private static string _perimeterFormula = "2×π×r";
        private double _area;
        private double _perimeter;

        public Circle(double radius)
        {
            _radius = radius;
            _area = Math.PI * Math.Pow(_radius,2);
            _perimeter = 2 * Math.PI * _radius;
        }
        /// <summary>
        ///     Gets formula for the area of the circle as a string.
        /// </summary>
        public new static string AreaFormula => _areaFormula;

        /// <summary>
        ///     Gets formula for the perimeter of the circle as a string.
        /// </summary>
        public new static string PerimeterFormula => _perimeterFormula;

        /// <inheritdoc />
        public override double Area => _area;
        /// <inheritdoc />
        public override double Perimeter => _perimeter;
    }
}
