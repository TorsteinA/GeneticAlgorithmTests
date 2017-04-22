using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleSetup.Robocode;
using Robocode;
using Santom;

namespace Tomtom
{
	static class EnemyDataHelpers
	{
		public static void PopulateData(this EnemyData data, ScannedRobotEvent e)
		{
			var point = new Point2D();
			data.SetEnemyData(e, point);
		}
		
		public static Vector2D ForwardVector(this EnemyData data, double length = 1)
		{
			return data.Position.PointToVector() +
			       Vector2DHelpers.VectorFromAngle(-data.HeadingRadians + Math.PI / 2) * length;
		}

		public static Vector2D RightVector(this EnemyData data, double length = 1)
		{
			return data.Position.PointToVector() + Vector2DHelpers.VectorFromAngle(-data.HeadingRadians) * length;
		}
	}
}
