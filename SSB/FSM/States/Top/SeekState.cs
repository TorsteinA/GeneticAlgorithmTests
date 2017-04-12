using System;
using System.Drawing;

namespace SeaSharpBot.FSM.States.Top
{
    public class SeekState : State
    {
        public SeekState(SeaSharpBot ourRobot)
        {
            OurRobot = ourRobot;
        }

        /// <summary>
        /// Use to check if conditions apply to switch state
        /// </summary>
        /// <returns></returns>
        public override State StateChangeRelevance()
        {
            if (Math.Abs(OurRobot.Enemy.Position.X) < 0.0001 && Math.Abs(OurRobot.Enemy.Position.Y) < 0.0001)
                return this;
            else
                return new DestroyState(OurRobot);
        }

        public override void EnterState()
        {
//            Console.WriteLine("Entered SeekState");
            OurRobot.GunColor = Color.Aqua;
            OurRobot.RadarColor = Color.Aqua;
        }

        public override void DoStateAction()
        {
//            Console.WriteLine(" - Seeking");
            OurRobot.TurnRadarRightRadians(Math.PI*2);
            KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);

        }

        public override void ExitState()
        {
//            Console.WriteLine("Leaving SeekState");
        }
    }
}