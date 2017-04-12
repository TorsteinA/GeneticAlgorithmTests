using System;
using System.Drawing;

namespace SeaSharpBot.FSM.States.Bottom {
    internal class AttackState : State {

//        private int _moveDirection = 1; 

        public AttackState(SeaSharpBot ourRobot)
        {
            OurRobot = ourRobot;
        }

        public override State StateChangeRelevance()
        {

            if (OurRobot.Enemy.Distance > OurRobot.OuterCircleDiameter/2)
            {
                return new ChargeState(OurRobot);
            }

            return this;
        }

        public override void EnterState()
        {
            Console.WriteLine("Entered AttackState");
            OurRobot.BodyColor = Color.Red;
        }

        public override void ExitState()
        {
            Console.WriteLine("Left AttackState");
        }

        public override void DoStateAction()
        {
            //TODO Move back and forth in arc around enemy

            //Keep side facing enemy
            //Drive forwards for X time or on wall detection in front. 
            //Drive backwards for X time or on wall detection from back. 



            // always square off against our enemy

//                        OurRobot.TurnRightRadians(OurRobot.Enemy.BearingRadians + Math.PI/2);

            //
            //            // strafe by changing direction every 20 ticks
            //            if (OurRobot.Time % 20 == 0 /*|| WallDetectionFrontDistance() < 100*/) {
            //                _moveDirection *= -1;
            //                OurRobot.SetAhead(150 * _moveDirection);
            //            }
            //

        }
    }
}