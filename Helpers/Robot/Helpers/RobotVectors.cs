using System;
using Alvtor_Hartho_15;
using Tomtom;
using Santom;

namespace Tomtom.Utility
{
    public static class RobotVectors
    {
        private const double HalfPi = Math.PI / 2;
        /// <summary>
        /// Returns a vector in the desired direction, or straight forward if unspecified. The use of nullable types
        /// is for simplicity and being able to set default values.
        /// </summary>
        /// <param name="angle">The angle to turn. Defaults to null, which is converted to robot's ahead.</param>
        /// <param name="direction">Whether to cast the vector forwards or backwards. Default is the robot's direction</param>
        /// <param name="length">How long the vector should be</param>
        /// <returns>The vector</returns>
        public static Vector2D DirectionVector(this Garics robot, double angle, Direction? direction = null, double length = 1)
        {
            direction = direction ?? robot.MoveDirection;
            return robot.PositionVector + Vector2DHelpers.VectorFromAngle(angle + HalfPi) * length *
                   (int) direction.Value;
        }

        public static Vector2D ForwardVector(this Garics robot, double offset = 0, double length = 1)
        {
            var angle = -robot.HeadingRadians + offset;
            return DirectionVector(robot, angle, robot.MoveDirection, length);
        }

    }
}