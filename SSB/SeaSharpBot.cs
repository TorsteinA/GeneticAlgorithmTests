using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using Robocode;
using Robocode.Util;
using SeaSharpBot.FSM;
using SeaSharpBot.FSM.States;
using SeaSharpBot.FSM.States.Bottom;
using SeaSharpBot.FSM.States.Top;
using SeaSharpBot.Helpers;

namespace SeaSharpBot
{
	public class SeaSharpBot : AdvancedRobot
	{
		#region Fields

		// Properties
	    internal EnemyData Enemy { get; set; }
        internal EnemyData OldEnemy;
        internal double OldEnemyHeading;
        public float InnerCircleDiameter = 400;
        public float OuterCircleDiameter = 600;
        
	    private StateManagerScript _stateManagerTop, _stateManagerBottom;

#endregion Fields
		
        #region SystemFunctions
		/// <summary>
		///     This method is called as soon as the match is loaded
		/// </summary>
		public override void Run() 
        {
            Console.WriteLine("Run");
            Enemy = new EnemyData();
            _stateManagerTop = new StateManagerScript(new SeekState(this));
            _stateManagerBottom = new StateManagerScript(new WanderState(this));
            
            while (true) {
                _stateManagerTop.FrameCheck();
                _stateManagerBottom.FrameCheck();
                Execute();
                OldEnemy = Enemy;
            }
        }

		/// <summary>
		///     What happends when our radar find another robot.
		/// </summary>
		/// <param name="e">Scanned Robot</param>
		public override void OnScannedRobot(ScannedRobotEvent e)
		{
            // Absolute angle towards target
		    var angleToEnemy = HeadingRadians + e.BearingRadians;
            
            //Update enemy data
            var enemyX = (int) (X + Math.Sin(angleToEnemy)*e.Distance);
            var enemyY = (int)(Y + Math.Cos(angleToEnemy) * e.Distance);
            Enemy.SetEnemyData(e, new Point2D(enemyX, enemyY));
		}
        

#endregion SystemFunctions
        
        #region Debugging Methods

        // Paint a filled square on top of the last scanned robot
        public override void OnPaint(IGraphics graphics) {
            var color1 = Color.ForestGreen;
            var color2 = Color.Firebrick;
            var color3 = Color.Gold;
            var color4 = Color.MidnightBlue;


            //Create a pen for drawing with
            var pen1 = new Pen(color1, 10f);
            var pen2 = new Pen(color3, 10f);

            var brush1 = new SolidBrush(color2);
            var brush2 = new SolidBrush(color4);

            //Create points
            Point enemyPoint = new Point((int) Enemy.Position.X, (int) Enemy.Position.Y), 
                  selfPoint = new Point((int) X, (int) Y),
                  intendedPoint = new Point((int) (Enemy.Position.X - ((InnerCircleDiameter + OuterCircleDiameter) / 4) * Math.Cos(Enemy.BearingRadians)), 
                                            (int) (Enemy.Position.Y - ((InnerCircleDiameter + OuterCircleDiameter) / 4) * Math.Sin(Enemy.BearingRadians)));


            
            // Draw a line from our robot to the scanned robot
            graphics.DrawLine(pen2, enemyPoint, selfPoint);

            // Draw a line from our robot to the intended point
            graphics.DrawLine(pen2, intendedPoint, selfPoint);

            // Draw a line from the intended point to the enemy robot
            graphics.DrawLine(pen2, intendedPoint, enemyPoint);

            
            graphics.DrawArc(pen1, 
                (float)Enemy.Position.X -InnerCircleDiameter/2, 
                (float)Enemy.Position.Y -InnerCircleDiameter/2, 
                InnerCircleDiameter, 
                InnerCircleDiameter, 
                0, 
                360);

            graphics.DrawArc(pen1, 
                (float) Enemy.Position.X-OuterCircleDiameter/2, 
                (float) Enemy.Position.Y-OuterCircleDiameter/2, 
                OuterCircleDiameter, 
                OuterCircleDiameter, 
                0, 
                360);


            // Draw a filled square on top of the scanned robot that covers it
            graphics.FillRectangle(brush1, enemyPoint.X - 20, enemyPoint.Y - 20, 40, 40);

            // Draw a filled square on the spot I want to charge towards
            graphics.FillRectangle(brush2, intendedPoint.X - 20, intendedPoint.Y - 20, 40, 40);


        }

#endregion Debugging Methods
    }
}