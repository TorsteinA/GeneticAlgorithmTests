using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robocode.Util;
using Santom;
using Tomtom;

namespace Alvtor_Hartho_15.FSM
{
    public abstract class State
    {
        protected Garics Garics;

        public abstract State StateChangeRelevance();

        public abstract void EnterState();

        public abstract void ExitState();

        public abstract void DoStateAction();

        protected State(Garics garics)
        {
            Garics = garics;
        }

        // Circular Targeting from robocode wiki translated to C#
        public void CircularTargetFire()
        {
            //Console.WriteLine("CircularTargeting!");

            var bulletPower = Math.Min(3.0, Garics.Energy);
            var myPos = new Point2D(Garics.X, Garics.Y);
            var absoluteBearing = Garics.HeadingRadians + Garics.Enemy.BearingRadians;
            var enemyX = Garics.X + Garics.Enemy.Distance * Math.Sin(absoluteBearing);
            var enemyY = Garics.Y + Garics.Enemy.Distance * Math.Cos(absoluteBearing);
            var enemyHeading = Garics.Enemy.HeadingRadians;
            var enemyHeadingChange = enemyHeading - Garics.OldEnemyHeading;
            var enemyVelocity = Garics.Enemy.Velocity;
            Garics.OldEnemyHeading = enemyHeading;

            double deltaTime = 0;
            double battleFieldHeight = Garics.BattleFieldHeight,
                   battleFieldWidth = Garics.BattleFieldWidth;
            var predictedPos = new Point2D(enemyX, enemyY);

            while ((++deltaTime) * (20.0 - 3.0 * bulletPower) <
                  myPos.Distance(predictedPos))
            {
                predictedPos.X += Math.Sin(enemyHeading) * enemyVelocity;
                predictedPos.Y += Math.Cos(enemyHeading) * enemyVelocity;
                enemyHeading += enemyHeadingChange;
                if (predictedPos.X < 18.0
                    || predictedPos.Y < 18.0
                    || predictedPos.X > battleFieldWidth - 18.0
                    || predictedPos.Y > battleFieldHeight - 18.0)
                {

                    predictedPos.X = Math.Min(Math.Max(18.0, predictedPos.X),
                        battleFieldWidth - 18.0);
                    predictedPos.Y = Math.Min(Math.Max(18.0, predictedPos.Y),
                        battleFieldHeight - 18.0);
                    break;
                }
            }
            var theta = Utils.NormalAbsoluteAngle(Math.Atan2(
                predictedPos.X - Garics.X, predictedPos.Y - Garics.Y));

            Garics.TurnGunRightRadians(Utils.NormalRelativeAngle(theta - Garics.GunHeadingRadians));

            //if we finished aiming, shoot 
            if (Math.Abs(Garics.GunTurnRemainingRadians) < 0.0001)
                Garics.Fire(Garics.Enemy.Distance < 60 ? 100 : bulletPower);
        }

        // Width lock from robocode wiki translated to C#
        public void KeepRadarLock(double angleToEnemy)
        {

            //Console.WriteLine("KeepRadarLock");

            // Subtract current radar heading to get the turn required to face the enemy, be sure it is normalized
           // var radarTurn = Utils.NormalRelativeAngle(angleToEnemy - Garics.RadarHeadingRadians);

            // Distance we want to scan from middle of enemy to either side
            // The 36.0 is how many units from the center of the enemy robot it scans.
           // var extraTurn = Math.Min(Math.Atan(40.0 / Garics.Enemy.Distance), Rules.RADAR_TURN_RATE_RADIANS);

            // Adjust the radar turn so it goes that much further in the direction it is going to turn
            // Basically if we were going to turn it left, turn it even more left, if right, turn more right.
            // This allows us to overshoot our enemy so that we get a good sweep that will not slip.
           // radarTurn += (radarTurn < 0 ? -extraTurn : extraTurn);

            //Turn the radar
          //  Garics.TurnRadarRightRadians(radarTurn);

        }
    }
}
