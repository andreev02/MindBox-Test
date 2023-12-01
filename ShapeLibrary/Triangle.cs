using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Triangle : Shape
    {
        public double A;
        public double B;
        public double C;

        public Triangle(double a, double b, double c) : base()
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("One side is less then zero");
            }

            if (a > (b + c) || b > (c + a) || c > (a + b))
            {
                throw new ArgumentException("Invalid triangle");
            }

            this.A = a;
            this.B = b;
            this.C = c;
        }

        /// <summary>
        /// Get rectangle square by Heron's formula
        /// </summary>
        /// <returns>double square</returns>
        public override double GetSquare()
        {
            double p = (A + B + C) / 2;
            return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 1);
        }

        /// <summary>
        /// Is tiangle rectangular
        /// </summary>
        /// <returns>bool</returns>
        public bool IsRectangular()
        {
            return (
                A == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(C, 2))
                || B == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(C, 2))
                || C == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2))
            );
        }
    }
}
