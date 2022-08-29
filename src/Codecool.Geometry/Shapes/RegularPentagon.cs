using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Regular Pentagon implementation class
    /// </summary>
    public class RegularPentagon : Shape
    {
        private double _a;
        private double _b;
        private static string _areaFormula = "a×b";
        private static string _perimeterFormula = "2×a+2×b";
        public double _area;
        public double _perimeter;

        public Rectangle(double a, double b)
        {
            _a = a;
            _b = b;
            _area = a * b;
            _perimeter = 2 * (a + b);
        }
        /// <summary>
        ///     Gets formula for the area of the pentagon as a string.
        /// </summary>
        public new static string AreaFormula => _areaFormula;

        /// <summary>
        ///     Gets formula for the perimeter of the pentagon as a string.
        /// </summary>
        public new static string PerimeterFormula => _perimeterFormula;

        /// <inheritdoc/>
        public override double Area => Area => _area;

        /// <inheritdoc/>
        public override double Perimeter => _perimeter;
    }
}
