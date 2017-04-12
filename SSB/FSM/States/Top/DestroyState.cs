using System;
using System.Drawing;

namespace SeaSharpBot.FSM.States.Top
{
    public class DestroyState : State
    {
        private int _radarHold = 0;

        public DestroyState(SeaSharpBot ourRobot)
        {
            OurRobot = ourRobot;
        }
        
        public override State StateChangeRelevance() 
        {
            if (OurRobot.OldEnemy == OurRobot.Enemy && _radarHold > 15)
                return new SeekState(OurRobot);
            else 
                return this;
        }

        public override void DoStateAction()
        {
            /*Console.WriteLine(
                " - Charging! \n  EnemyVelocity: " + 
                OurRobot.Enemy.Velocity + 
                "\n, Enemy Acceleration: " + 
                OurRobot.Enemy.Acceleration + 
                "\n, PositionX: " + 
                OurRobot.Enemy.Position.X + 
                ", Y: " + 
                OurRobot.Enemy.Position.Y +
                "\n, BearingRads" +
                OurRobot.Enemy.BearingRadians +
                "\n, Energy: " +
                OurRobot.Enemy.Energy);*/
            

            /*Gun*/
            CircularTargetFire();
        
            /*Radar*/
            KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);

            //Extra slip protection mechanism for width lock. 
            //Used a radarHoldCounter do deal with bug where radar lock slips and stops radar completely.
            if (Math.Abs(OurRobot.RadarTurnRemaining) < 0.001)
                _radarHold++;
            else
                _radarHold = 0;
            
        }

        public override void EnterState()
        {
            //Console.WriteLine("Entered DestroyState");
            OurRobot.GunColor = Color.Red;
            OurRobot.RadarColor = Color.Red;
            //KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);
        }

        public override void ExitState()
        {
            //Console.WriteLine("Leaving DestroyState");
        }
    }
}