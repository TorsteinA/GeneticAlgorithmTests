using System.Drawing;
using PG4500_2017_Exam1;
using Robocode;
using Santom;

namespace Tomtom.Utility
{
    public static class DebugDrawer
    {
        /// <summary>
        /// Method to draw half-transparent robot indicator box (size somewhat bigger than a robot) covering enemy.
        /// </summary>
        public static void DrawRobotIndicator(this Robot robot, Color drawColor, Point2D target)
        {
            // Set color to a semi-transparent one.
            var halfTransparent = Color.FromArgb(128, drawColor);
            // Draw rectangle at target.
            robot.Graphics.FillRectangle(new SolidBrush(halfTransparent), (int) (target.X - 26.5), (int) (target.Y - 26.5),
                54, 54);
        }

        /// <summary>
        /// Method to draw half-transparent targeting-line (from start to end) & targeting-box (the size of a robot)
        /// on the Battlefield. The idea is to use this for visual debugging: Set start point to own robot's position,
        /// and end point to where you mean the bullet to go. Then see if this really is where the bullet is heading:
        /// 1) If the targeting-box is off the spot you wanted it, you got a bug in your target prediction code.
        /// 2) If the targeting-box is on the spot, but the bullet is off the line (and center of the box), you
        ///    got a bug in your "gun turning and firing" code.
        /// </summary>
        public static void DrawLineAndTarget(this Robot robot, Color drawColor, Point2D start, Point2D end)
        {
            // Set color to a semi-transparent one.
            var halfTransparent = Color.FromArgb(128, drawColor);
            // Draw line and rectangle.
            robot.Graphics.DrawLine(new Pen(halfTransparent), (int) start.X, (int) start.Y, (int) end.X, (int) end.Y);
            robot.Graphics.FillRectangle(new SolidBrush(halfTransparent), (int) (end.X - 17.5), (int) (end.Y - 17.5), 36, 36);
        }

        /// <summary>
        /// Method to draw the battlefield bounds (i.e. the battlefield bounds - robot radius/2).
        /// </summary>
        public static void DrawBattlefieldEffectiveBounds(this Hartho_DuelBot robot, Color drawColor)
        {
            // Set color to a semi-transparent one.
            var halfTransparent = Color.FromArgb(160, drawColor);
            // Draw outlines of the field.
            robot.Graphics.DrawLine(new Pen(halfTransparent), (int) robot.Battlefield.TopLeft.X, (int) robot.Battlefield.TopLeft.Y, (int) robot.Battlefield.TopRight.X, (int) robot.Battlefield.TopRight.Y);
            robot.Graphics.DrawLine(new Pen(halfTransparent), (int) robot.Battlefield.TopLeft.X, (int) robot.Battlefield.TopLeft.Y, (int) robot.Battlefield.BottomLeft.X, (int) robot.Battlefield.BottomLeft.Y);
            robot.Graphics.DrawLine(new Pen(halfTransparent), (int) robot.Battlefield.BottomLeft.X, (int) robot.Battlefield.BottomLeft.Y, (int) robot.Battlefield.BottomRight.X, (int) robot.Battlefield.BottomRight.Y);
            robot.Graphics.DrawLine(new Pen(halfTransparent), (int) robot.Battlefield.BottomRight.X, (int) robot.Battlefield.BottomRight.Y, (int) robot.Battlefield.TopRight.X, (int) robot.Battlefield.TopRight.Y);

        }

    }
}