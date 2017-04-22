using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PG4500_2017_Exam1;
using Tomtom;
using Robocode;
using Santom;

namespace Tomtom
{
	static class UtilsVector
	{
		public static Vector2D RotateVector(this Vector2D vector, double radians)
		{
			var cos = Math.Cos(radians);
			var sin = Math.Sin(radians);
			return new Vector2D(cos * vector.X - sin * vector.Y, sin * vector.Y + cos * vector.X);
		}	

		public static Point2D FindTargetPosition(this Hartho_DuelBot robot, ScannedRobotEvent e)
		{
			var angle = robot.HeadingRadians + e.BearingRadians;

			//TODO this takes a lot of negatives. Find out what's going on.
			return new Point2D(robot.PositionVector - Vector2DHelpers.VectorFromAngle(-angle - Math.PI/2, e.Distance));
		}
	}
}
