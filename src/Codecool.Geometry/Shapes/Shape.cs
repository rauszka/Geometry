using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     This is an abstract class representing geometrical shapes.
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        ///     Gets formula for the area of the shape as a string.
        ///     It is a static property so it cannot be abstract
        ///     This property should be hidden by subclasses
        /// </summary>
        public static string AreaFormula { get; }
    }

        /// <summary>
        ///     Gets formula for the perimeter of the shape as a string.
        ///     It is a static property so it cannot be abstract
        ///     This property should be hidden by subclasses
        /// </summary>
        public static string PerimeterFormula { get; }

        /// <summary>
        ///     Check if all args are greater than 0
        /// </summary>
        /// <param name="args">Arguments to check</param>
        /// <returns>True if all of args are greater than 0</returns>
        public static bool CheckIfArgsAreGreaterThanZero(params double[] args)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///    Gets calculated shape's area
        /// </summary>
        /// <returns>Area of the shape</returns>
        public abstract double Area { get; }

        /// <summary>
        ///     Gets calculated shape's perimeter.
        /// </summary>
        /// <returns>Perimeter of the shape</returns>
        public abstract double Perimeter { get; }
    }
}
