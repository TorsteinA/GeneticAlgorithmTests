using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleSetup.Robocode;
using Robocode.Util;
using Santom;
using Tomtom.Utility;

namespace Tomtom
{
	static class Vector2DHelpers
	{
		private const double HalfPi = +Math.PI / 2;

		/// <summary>
		/// Creates a vector from an angle. Defaults to creating a normalized vector
		/// </summary>
		/// <param name="angle">The angle of the vector</param>
		/// <param name="length">The length of the vector. Defaults to 1</param>
		/// <returns>The desired vector</returns>
		public static Vector2D VectorFromAngle(double angle, double length = 1)
		{
			return new Vector2D(Math.Cos(angle), Math.Sin(angle)) * length;
		}

		/// <summary>
		/// Calculates the angle between two vectors
		/// </summary>
		/// <param name="v1">Vector 1</param>
		/// <param name="v2">Vector 2</param>
		/// <returns></returns>
		public static double Angle(this Vector2D v1, Vector2D v2)
		{
			return Math.Atan2(v2.Y, v2.X) - Math.Atan2(v1.Y, v1.X);
//		    return Math.Acos(v1.Normalized().Dot(v2.Normalized()));
		}

		public static double AngleFromWorldYAxis(this Vector2D vector)
		{
			return Math.Atan2(vector.Y, vector.X) + HalfPi;// - Math.Atan2(v2.Y, v2.X);
		}

		/// <summary>
		/// Creates a new Vector2D with the normalized values of the input vector.
		/// Reworked version of Santom's method
		/// </summary>
		/// <returns>A new Vector2D; the normalized version of the original vector.</returns>
		public static Vector2D Normalized(this Vector2D v)
		{
			if (v.IsZero() || v.LengthSq() == 1) return v;
		
			var vectorLength = v.Length();
			v.X /= vectorLength;
			v.Y /= vectorLength;

			return v;
		}

		/// <summary>
		/// Takes a vector and returns the point value
		/// </summary>
		/// <param name="vector">Vector</param>
		/// <returns></returns>
		public static Point2D VectorToPoint(this Vector2D vector)
		{
			return new Point2D(vector);
		}

	    /// <summary>
	    /// Clamps a vector within specified parameters.
	    /// </summary>
	    /// <param name="vector">The vector to be changed</param>
	    /// <param name="minX">Min X value</param>
	    /// <param name="maxX">Max X value</param>
	    /// <param name="minY">Min Y value</param>
	    /// <param name="maxY">Max Y value</param>
	    public static void ClampVector(this Vector2D vector, double minX, double maxX, double minY, double maxY)
	    {
	        vector.X = vector.X.Clamp(minX, maxX);
	        vector.Y = vector.Y.Clamp(minY, maxY);
	    }

	    /// <summary>
	    /// Clamps a vector within specified battlefield parameters.
	    /// </summary>
	    /// <param name="vector">The vector to be changed</param>
	    /// <param name="battlefield">the battlefield within which to clamp the vector</param>
	    public static void ClampVector(this Vector2D vector, Battlefield battlefield)
	    {
	        vector.X = vector.X.Clamp(battlefield.Left, battlefield.Right);
	        vector.Y = vector.Y.Clamp(battlefield.Bottom, battlefield.Top);
	    }

	    /// <summary>
	    /// Creates a new vector, clamped to specified parameters.
	    /// </summary>
	    /// <param name="vector">The vector to be changed</param>
	    /// <param name="minX">Min X value</param>
	    /// <param name="maxX">Max X value</param>
	    /// <param name="minY">Min Y value</param>
	    /// <param name="maxY">Max Y value</param>
	    /// <returns>A new Vector2D, clamped</returns>
	    public static Vector2D ClampedVector(this Vector2D vector, double minX, double maxX, double minY, double maxY)
	    {
	        double x = vector.X, y = vector.Y;
	        return new Vector2D(x.Clamp(minX, maxX), y.Clamp(minY, maxY));
	    }

	    public static bool IsLongerOrOfEqualLength(this Vector2D v1, Vector2D v2)
	    {
	        return v1.LengthSq() >= v2.LengthSq();
	    }

	    public static double CompareLength(this Vector2D v1, Vector2D v2)
	    {
	        return v1.LengthSq() - v2.LengthSq();
	    }
	}
}
