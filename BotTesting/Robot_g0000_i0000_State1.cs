using System.Drawing;
using Alvtor_Hartho_15.FSM;

namespace Alvtor_Hartho_15
{
    public class State1 : State
    {
        public BotZero OurRobot { get; set; }

        public State1(BotZero ourRobot) : base(ourRobot)
        {
            OurRobot = ourRobot;
        }

        public override State StateChangeRelevance()
        {
            if (OurRobot.V4 < OurRobot.V0 || OurRobot.V1 <= OurRobot.V0)
                return new State0(OurRobot);

            return this;
        }

        public override void EnterState()
        {
            OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(72, 100, 60);

/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
            if (OurRobot.V1 > OurRobot.V4)
            {
                if (OurRobot.V0 < OurRobot.V1 && OurRobot.V1 >= OurRobot.V7)
                {
/*IntAndFloat();*/
                }
            }
/*CircularTargetFire();*/
        }

        public override void DoStateAction()
        {
/*IntAndFloat();*/
/*IntAndFloat();*/
/*CircularTargetFire();*/
            if (OurRobot.V6 > OurRobot.V7)
            {
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
            }
/*CircularTargetFire();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*Example();*/
            if (OurRobot.V7 > OurRobot.V0)
            {
                if (OurRobot.V1 == OurRobot.V2 || OurRobot.V5 >= OurRobot.V2 || OurRobot.V3 <= OurRobot.V7)
                {
                    if (OurRobot.V7 < OurRobot.V4)
                    {
/*IntAndFloat();*/
                    }
                }
            }
            if (OurRobot.V4 < OurRobot.V5)
            {
                if (OurRobot.V4 > OurRobot.V0 || OurRobot.V2 > OurRobot.V7 && OurRobot.V0 != OurRobot.V1 ||
                       OurRobot.V3 == OurRobot.V2)
                {
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
                }
            }
            if (OurRobot.V7 >= OurRobot.V2 || OurRobot.V2 >= OurRobot.V4)
            {
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
            }
/*CircularTargetFire();*/
        }

        public override void ExitState()
        {
            if (OurRobot.V7 != OurRobot.V1)
            {
                if (OurRobot.V1 <= OurRobot.V3)
                {
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
                }
            }
/*CircularTargetFire();*/
            if (OurRobot.V0 > OurRobot.V4)
            {
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
            }
            if (OurRobot.V1 >= OurRobot.V2 || OurRobot.V3 >= OurRobot.V7)
            {
                if (OurRobot.V6 < OurRobot.V5 && OurRobot.V7 >= OurRobot.V0)
                {
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
                }
            }
/*IntAndFloat();*/
            if (OurRobot.V6 == OurRobot.V3 || OurRobot.V5 != OurRobot.V2 || OurRobot.V2 <= OurRobot.V6)
            {
                if (OurRobot.V5 >= OurRobot.V4 || OurRobot.V2 > OurRobot.V0)
                {
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
                }
            }
        }
    }
}