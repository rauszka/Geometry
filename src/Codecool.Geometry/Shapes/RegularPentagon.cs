using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Regular Pentagon implementation class
    /// </summary>
    public class RegularPentagon : Shape
    {
        private double _a;
        private static string _areaFormula = "a×a×sqrt(5×(5+2×sqrt(5))/4|";
        private static string _perimeterFormula = "5×a";
        private double _area;
        private double _perimeter;

        public RegularPentagon(double a)
        {
            _a = a;
            _area = (Math.Sqrt(25 + 10 * Math.Sqrt(5))) / 4 * Math.Pow(_a, 2);
            _perimeter = 5 * _a;
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

        public override string ToString()
        {
            return $"Pentagon, a = {Math.Round(_a, 2)}";
        }
    }
}
