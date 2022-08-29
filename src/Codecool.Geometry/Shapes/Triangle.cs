using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Triangle implementation class
    /// </summary>
    public class Triangle : Shape
    {
        private double _a;
        private double _b;
        private double _c;
        private double _height;
        private static string _areaFormula = "sqrt(s×(s-a)×(s-b)×(s-c))";
        private static string _perimeterFormula = "a+b+c";
        public double _area;
        public double _perimeter;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
            _height = Math.Sqrt((a + b + c) * (-a + b + c) * (a - b + c) * (a + b - c)) / (2 * c);
            _area = 0.5 * b * _height;
            _perimeter = a + b + c;
        }

        /// <summary>
        ///     Gets formula for the area of the triangle as a string.
        /// </summary>
        public new static string AreaFormula => _areaFormula;

        /// <summary>
        ///     Gets formula for the perimeter of the triangle as a string.
        /// </summary>
        public new static string Perimeter => _perimeter
        /// <inheritdoc/>
        public override double PerimeterFormula => _perimeterFormula;


        /// <inheritdoc />
        public override double Area => _area;

        public override string ToString()
        {
            return $"Triangle, a = {Math.Round(_a, 2)}, b = {Math.Round(_b, 2)}, c = {Math.Round(_c, 2)}";
        }
    }
}
