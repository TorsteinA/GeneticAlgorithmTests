using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Santom;
using Tomtom.Utility;

namespace Tomtom
{
    static class Point2DHelpers
    {
        public static Vector2D PointToVector(this Point2D point)
        {
            return new Vector2D(point.X, point.Y);
        }


        public static bool IsOutOfBounds(this Point2D point, double minX, double maxX, double minY, double maxY)
        {
            return point.X > minX && point.X < maxX && point.Y > minY && point.Y < maxY;
        }

        public static bool IsOutOfBounds(this Point2D point, Battlefield battlefield)
        {
            return point.X > battlefield.Left && point.X < battlefield.Right && point.Y > battlefield.Bottom && point.Y < battlefield.Top;
        }

        /// <summary>
        /// Returns the SQUARED distance between this vector and the one passed as a parameter.
        /// </summary>
        public static double DistanceSq(this Point2D a, Point2D b)
        {
            double ySeparation = b.Y - a.Y;
            double xSeparation = b.X - a.X;

            return ((ySeparation * ySeparation) + (xSeparation * xSeparation));
        }

        public static double Distance(this Point2D a, Point2D b)
        {
            return Math.Sqrt(a.DistanceSq(b));
        }

    }
}