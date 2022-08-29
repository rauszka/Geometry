using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Square implementation class
    /// </summary>
    public class Square : Rectangle
    {
        private double _a;
        private static string _areaFormula = "a×a";
        private static string _perimeterFormula = "4×a";
        public Square(double side) : base(side, side)
        {
            _a = side;
            _area = _a * _a;
            _perimeter = 4 * _a;
        }

        /// <summary>
        ///     Gets formula for the area of the rectangle as a string.
        /// </summary>
        public new static string AreaFormula => _areaFormula;

        /// <summary>
        ///     Gets formula for the perimeter of the rectangle as a string.
        /// </summary>
        public new static string PerimeterFormula =>_perimeterFormula;

        public override string ToString()
        {
            return $"Square, a = {Math.Round(_a, 2)}";
        }
    }
}
