using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Equilateral Triangle implementation class
    /// </summary>
    public class EquilateralTriangle : Triangle
    {
        private double _a;
        private static string _areaFormula = "a×a×sqrt(3)/4";
        private static string _perimeterFormula = "3×a";

        public EquilateralTriangle(double a) : base(a, a, a)
        {
            _a = a;
            _area = Math.Pow(_a, 2) * Math.Sqrt(0.75);
            _perimeter = 3 * _a;
        }

        /// <summary>
        ///     Gets formula for the area of the triangle as a string.
        /// </summary>
        public new static string AreaFormula => _areaFormula;

        /// <summary>
        ///     Gets formula for the perimeter of the triangle as a string.
        /// </summary>
        public new static string PerimeterFormula => _perimeterFormula;

        public override string ToString()
        {
            return $"Equilateral Triangle, a = {Math.Round(_a, 2)}";
        }
    }
}
