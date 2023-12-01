using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius) : base()
        {
            if (radius < 0)
            {
                throw new ArgumentException("The radius is less than zero");
            }

            this._radius = radius;
        }

        /// <summary>
        /// Get circle square by radius
        /// </summary>
        /// <returns>double square</returns>
        public override double GetSquare()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 1);
        }
    }
}
