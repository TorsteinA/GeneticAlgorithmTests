using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using PG4500_2017_Exam1;
using Robocode;
using Robocode.Util;
using Santom;
using Tomtom.Utility;

namespace Tomtom
{
    public class WallAvoidance
    {
        private const double Pi = Math.PI;
        private const double HalfPi = Pi / 2;

        public Hartho_DuelBot Robot { get; set; }
        public Battlefield Battlefield { get; set; }

        #region Directions

        private const double North = 2 * Pi;
        private const double South = Pi;
        private const double East = HalfPi;
        private const double West = Pi + HalfPi;

        #endregion

        public WallAvoidance(Hartho_DuelBot robot)
        {
            Robot = robot;
            Battlefield = Robot.Battlefield;
        }

        //Based on (copied) http://robowiki.net/wiki/Wall_Smoothing/Implementations/Fancy_Stick

        #region WallAvoidance

        private bool ShouldSmooth(double angle, double distanceToWall, double velocity)
        {
            var nextPosition = distanceToWall + Robot.Radius + velocity * Math.Sin(angle);
            if (nextPosition < -Robot.TurnRadius)
            {
                // shortcut, unnecessary code
                return false;
            }
            if (0.0 <= nextPosition)
            {
                // shortcut, unnecessary code
                return true;
            }

            return 0 < nextPosition + Robot.TurnRadius * (Math.Cos(angle) + 1);
        }


        // smooths clockwise against a right wall at x=0
        private double SmoothAngle(double coordinate)
        {
            // [x + 8*sin(a) + r*sin(a+90) + r = 0] solved for a
            if (-0.0001 < coordinate)
            {
                return Pi;
            }
            var rx = Robot.TurnRadius * coordinate;
            var inner = Robot.Velocity.Squared() - coordinate.Squared() - 2.0 * rx;
            var angle = Math.Acos(-(rx + Robot.TurnRadius.Squared() + Robot.Velocity * Math.Sqrt(inner)) /
                                  (Robot.Velocity.Squared() + Robot.TurnRadius.Squared()));
            return angle;
        }

        public double AvoidWalls()
        {
            var stickEnd = Robot.ForwardVector(length: Robot.TurnRadius).VectorToPoint();

            //DEBUG
            Robot.DrawLineAndTarget(Color.AliceBlue, Robot.Position, stickEnd);

            if (stickEnd
                .IsOutOfBounds(Battlefield)) return 0;

            Robot.SetTurnRightRadians(Utils.NormalRelativeAngle(-Robot.TurnRemainingRadians));

            var angle = Robot.HeadingRadians;
            var velocity = Robot.Velocity;
//            var clockwise = !AvoidClockwise();
//            var outputAngle = 0d;

            angle = AvoidClockwise() ? TurnClockwise(angle, velocity) : TurnCounterclockwise(angle, velocity);

            return angle;
        }

        private double TurnCounterclockwise(double angle, double velocity)
        {
            if (angle < South && angle < 0)
            {
                // left wall

                if (ShouldSmooth(South - angle, Battlefield.Left - Robot.X, velocity))
                {
                    angle = Pi - SmoothAngle(Battlefield.Left - Robot.X);
//                        angle = North - Smooth(North - angle, _left - X, velocity);
                }
            }
            else if (angle > South)
            {
                // right wall
                if (ShouldSmooth(North - angle, Robot.X - Battlefield.Right, velocity))
                {
                    angle = SmoothAngle(Robot.X - Battlefield.Right);

//                        angle = South - Smooth(South - angle, X - _right, velocity);
                }
            }
            if (angle < West && angle > East)
            {
                // top wall
                if (ShouldSmooth(East - angle, Robot.Y - Battlefield.Top, velocity))
                {
                    angle = SmoothAngle(Robot.Y - Battlefield.Top);

//                        angle = East - Smooth(East - angle, Y - _top, velocity);
                }
            }
            else if (angle < East || angle > West)
            {
                // bottom wall
                if (ShouldSmooth(West - angle, Battlefield.Bottom - Robot.Y, velocity))
                {
                    angle = SmoothAngle(South - Robot.Y);

//                        angle = West - Smooth(West - angle, _bottom - Y, velocity);
                }
            }
            return angle;
        }

        private double TurnClockwise(double angle, double velocity)
        {
            if (angle > South) //Left wall
            {
                if (ShouldSmooth(angle - South, Battlefield.Left - Robot.X, velocity))
                {
                    angle = SmoothAngle(Battlefield.Left - Robot.X);

//                        angle = Smooth(angle - South, _left - X, velocity) + South;
                }
            }
            else if (angle > 0 && angle < South) //Right wall
            {
                if (ShouldSmooth(angle, Robot.X - Battlefield.Right, velocity))
                {
                    angle = SmoothAngle(Robot.X - Battlefield.Right);

//                        angle = Smooth(angle, X - _right, velocity);
                }
            }
            if (angle > West || angle < East) //Top wall
            {
                if (ShouldSmooth(angle + East, Robot.Y - Battlefield.Top, velocity))
                {
                    angle = SmoothAngle(Robot.Y - Battlefield.Top);
//                        angle = Smooth(angle + East, Y - _top, velocity) - East;
                }
            }
            else if (angle < West && angle > East) //Bottom wall
            {
                if (ShouldSmooth(angle - East, Battlefield.Bottom - Robot.Y, velocity))
                {
                    angle = SmoothAngle(Battlefield.Bottom - Robot.Y);
//                        angle = Smooth(angle - East, _bottom - Y, velocity) + East;
                }
            }
            return angle;
        }

        private bool AvoidClockwise()
        {
            var starboard = Robot.DirectionVector(-Robot.HeadingRadians - HalfPi, Robot.MoveDirection,
                Robot.TurnRadius);
            var port = Robot.DirectionVector(-Robot.HeadingRadians + HalfPi, Robot.MoveDirection, Robot.TurnRadius);
            var starboardLengthBefore = starboard.Length();
            starboard.ClampVector(Battlefield);
            port.ClampVector(Battlefield);
            var starboardLengthAfter = starboard.Length();

            //DEBUG
            Robot.DrawLineAndTarget(Color.LawnGreen, Robot.Position, starboard.VectorToPoint());
            Robot.DrawLineAndTarget(Color.Red, Robot.Position, port.VectorToPoint());


            var starboardComparedToPort = starboard.CompareLength(port);

            if (starboardComparedToPort != 0)
            {
                return starboardComparedToPort > 0;
            }

            var distanceToBoundsPort = CalculateDistanceToBounds((Robot.PositionVector + port).VectorToPoint());
            var distanceToBoundsStarboard =
                CalculateDistanceToBounds((Robot.PositionVector + starboard).VectorToPoint());

            return distanceToBoundsStarboard > distanceToBoundsPort;

            //TODO: if they are of equal length (return -1, 0, or 1), calculate which one is closer to the bounds of the field
        }

        private double CalculateDistanceToBounds(Point2D point)
        {
            var horizontalDistance = point.X > Battlefield.Width / 2 ? Battlefield.Right - point.X : point.X;
            var verticalDistance = point.Y > Battlefield.Top / 2 ? Battlefield.Height - point.Y : point.Y;
            return Math.Min(horizontalDistance, verticalDistance);
        }

        #endregion
    }
}