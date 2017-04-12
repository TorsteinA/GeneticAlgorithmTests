using System;
using System.Drawing;
using SeaSharpBot.Helpers;

namespace SeaSharpBot.FSM.States.Bottom
{
    public class ChargeState : State
    {
        private int _moveDirection = 1;

        public ChargeState(SeaSharpBot ourRobot)
        {
            OurRobot = ourRobot;
        }
        
        public override State StateChangeRelevance()
        {
            //Return attackstate when in the right spot
//            if (OurRobot.Enemy.Distance > OurRobot.InnerCircleDiameter/2 && OurRobot.Enemy.Distance < OurRobot.OuterCircleDiameter/2)
//                return new AttackState(OurRobot);
//            else
                return this;
        }

        public override void DoStateAction()
        {
//            Console.WriteLine(" - Charging!");
//            Console.WriteLine("Distance: " + OurRobot.Enemy.Distance);


            var target = new Point((int)(OurRobot.Enemy.Position.X - ((OurRobot.InnerCircleDiameter + OurRobot.OuterCircleDiameter) / 4) * Math.Cos(OurRobot.Enemy.BearingRadians)),
                                            (int)(OurRobot.Enemy.Position.Y - ((OurRobot.InnerCircleDiameter + OurRobot.OuterCircleDiameter) / 4) * Math.Sin(OurRobot.Enemy.BearingRadians)));

            
            // switch directions if we've stopped
            if (Math.Abs(OurRobot.Velocity) < 0.001)
                _moveDirection *= -1;

            // circle our enemy
            OurRobot.SetTurnRight(OurRobot.Enemy.BearingDegrees + 90);
            OurRobot.SetAhead(80 * _moveDirection);



            /*
            var e = new Vector2D(OurRobot.Enemy.Position.X - OurRobot.X, OurRobot.Enemy.Position.Y - OurRobot.Y);
            var distance = OurRobot.Enemy.Distance;
            if (distance > 0)
            {
                e.Normalize();
                if (distance < OurRobot.OuterCircleDiameter/2)
                {
                    e *= 100 * (distance / (OurRobot.OuterCircleDiameter / 2));
                } else {
                    e = e * 100; //Using 100 as maxSpeed for now
                }
                var steer = new Vector2D(e.X - OurRobot.Velocity, e.Y - OurRobot.Velocity);
            }
            
//            OurRobot.TurnRightRadians(Math.Acos(OurRobot.Enemy.Distance /
//                (Math.Sqrt(Math.Pow(OurRobot.Enemy.Distance, 2) + 
//                        Math.Pow(new Vector2D(OurRobot.X, OurRobot.Y).Distance(new Vector2D(OurRobot.Enemy.Position.X, 
//                                /*Replace enemy with intended pos//    OurRobot.Enemy.Position.Y)), 
//                                2)))));

//            OurRobot.SetAhead(e.Length());

            */
        }

        public override void EnterState()
        {
            Console.WriteLine("Entered AttackState");
            OurRobot.BodyColor = Color.Orange;
        }

        public override void ExitState()
        {
            Console.WriteLine("Leaving AttackState");
        }
    }
}