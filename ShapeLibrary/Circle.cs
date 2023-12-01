using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Circle : Shape
    {
        public readonly double Radius;

        public Circle(double radius) : base()
        {
            if (radius < 0)
            {
                throw new ArgumentException("The radius is less than zero");
            }

            this.Radius = radius;
        }

        /// <summary>
        /// Get circle square by radius
        /// </summary>
        /// <returns>double square</returns>
        public override double GetSquare()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }
    }
}
