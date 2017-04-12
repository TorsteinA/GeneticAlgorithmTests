using System;
using Robocode;
using Robocode.Util;
using SeaSharpBot.Helpers;

namespace SeaSharpBot.FSM.States
{
	public abstract class State
	{
		protected SeaSharpBot OurRobot;

		public abstract State StateChangeRelevance();

	    public abstract void EnterState();

	    public abstract void ExitState();

		public abstract void DoStateAction();
        
        // Circular Targeting from robocode wiki translated to C#
        public void CircularTargetFire() {
            //Console.WriteLine("CircularTargeting!");

            var bulletPower = Math.Min(3.0, OurRobot.Energy);
            var myPos = new Point2D(OurRobot.X, OurRobot.Y);
            var absoluteBearing = OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians;
            var enemyX = OurRobot.X + OurRobot.Enemy.Distance * Math.Sin(absoluteBearing);
            var enemyY = OurRobot.Y + OurRobot.Enemy.Distance * Math.Cos(absoluteBearing);
            var enemyHeading = OurRobot.Enemy.HeadingRadians;
            var enemyHeadingChange = enemyHeading - OurRobot.OldEnemyHeading;
            var enemyVelocity = OurRobot.Enemy.Velocity;
            OurRobot.OldEnemyHeading = enemyHeading;

            double deltaTime = 0;
            double battleFieldHeight = OurRobot.BattleFieldHeight,
                   battleFieldWidth = OurRobot.BattleFieldWidth;
            var predictedPos = new Point2D(enemyX, enemyY);

            while ((++deltaTime) * (20.0 - 3.0 * bulletPower) <
                  myPos.Distance(predictedPos)) {
                predictedPos.X += Math.Sin(enemyHeading) * enemyVelocity;
                predictedPos.Y += Math.Cos(enemyHeading) * enemyVelocity;
                enemyHeading += enemyHeadingChange;
                if (   predictedPos.X < 18.0
                    || predictedPos.Y < 18.0
                    || predictedPos.X > battleFieldWidth - 18.0
                    || predictedPos.Y > battleFieldHeight - 18.0) {

                    predictedPos.X = Math.Min(Math.Max(18.0, predictedPos.X),
                        battleFieldWidth - 18.0);
                    predictedPos.Y = Math.Min(Math.Max(18.0, predictedPos.Y),
                        battleFieldHeight - 18.0);
                    break;
                }
            }
            var theta = Utils.NormalAbsoluteAngle(Math.Atan2(
                predictedPos.X - OurRobot.X, predictedPos.Y - OurRobot.Y));
            
            OurRobot.TurnGunRightRadians(Utils.NormalRelativeAngle(theta - OurRobot.GunHeadingRadians));

            //if we finished aiming, shoot 
            if (Math.Abs(OurRobot.GunTurnRemainingRadians) < 0.0001)
                OurRobot.Fire(OurRobot.Enemy.Distance < 60 ? 100 : bulletPower);
        }
        
        // Width lock from robocode wiki translated to C#
        public void KeepRadarLock(double angleToEnemy) {

            //Console.WriteLine("KeepRadarLock");

            // Subtract current radar heading to get the turn required to face the enemy, be sure it is normalized
            var radarTurn = Utils.NormalRelativeAngle(angleToEnemy - OurRobot.RadarHeadingRadians);

            // Distance we want to scan from middle of enemy to either side
            // The 36.0 is how many units from the center of the enemy robot it scans.
            var extraTurn = Math.Min(Math.Atan(40.0 / OurRobot.Enemy.Distance), Rules.RADAR_TURN_RATE_RADIANS);

            // Adjust the radar turn so it goes that much further in the direction it is going to turn
            // Basically if we were going to turn it left, turn it even more left, if right, turn more right.
            // This allows us to overshoot our enemy so that we get a good sweep that will not slip.
            radarTurn += (radarTurn < 0 ? -extraTurn : extraTurn);

            //Turn the radar
            OurRobot.TurnRadarRightRadians(radarTurn);
            
        }
   }
}