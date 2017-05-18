using System.Drawing;
using Alvtor_Hartho_15.FSM;

namespace Alvtor_Hartho_15
{
    public class State0 : State
    {
        public BotZero OurRobot { get; set; }

        public State0(BotZero ourRobot) : base(ourRobot)
        {
            OurRobot.BodyColor = Color.LavenderBlush;
            OurRobot = ourRobot;
        }

        public override State StateChangeRelevance()
        {
            if (OurRobot.V1 <= OurRobot.V6 || OurRobot.V5 == OurRobot.V1)
                return new State1(OurRobot);

            return this;
        }

        public override void EnterState()
        {
            OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(102, 66, 199);

/*IntAndFloat(8,-1.0f);*/
/*IntAndFloat();*/
            if (OurRobot.V2 >= OurRobot.V5)
            {
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
            }
            while (OurRobot.V6 >= OurRobot.V1)
            {
                while (OurRobot.V0 > OurRobot.V4)
                {
/*IntAndFloat();*/
                }
            }
            while (OurRobot.V1 > OurRobot.V5 && OurRobot.V7 == OurRobot.V6)
            {
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
            }
            while (OurRobot.V3 < OurRobot.V0 && OurRobot.V3 > OurRobot.V5 && OurRobot.V2 == OurRobot.V7 ||
                   OurRobot.V2 <= OurRobot.V1)
            {
/*CircularTargetFire();*/
            }
/*IntAndFloat();*/
            if (OurRobot.V1 == OurRobot.V4 && OurRobot.V1 < OurRobot.V4)
            {
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
            }
            while (OurRobot.V4 > OurRobot.V0 || OurRobot.V3 == OurRobot.V6)
            {
                while (OurRobot.V5 > OurRobot.V1 || OurRobot.V5 == OurRobot.V1)
                {
/*IntAndFloat();*/
                }
            }
/*IntAndFloat();*/
            if (OurRobot.V1 >= OurRobot.V7)
            {
                while (OurRobot.V0 <= OurRobot.V2 || OurRobot.V5 > OurRobot.V3 || OurRobot.V1 != OurRobot.V3 ||
                       OurRobot.V3 < OurRobot.V4)
                {
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
                }
            }
            while (OurRobot.V6 <= OurRobot.V2)
            {
/*Example();*/
            }
        }

        public override void DoStateAction()
        {
/*IntAndFloat();*/
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
            while (OurRobot.V5 == OurRobot.V3 || OurRobot.V4 >= OurRobot.V1 && OurRobot.V6 < OurRobot.V1 ||
                   OurRobot.V6 != OurRobot.V7)
            {
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
            }
/*Example();*/
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
            while (OurRobot.V3 > OurRobot.V7)
            {
                if (OurRobot.V5 != OurRobot.V7)
                {
/*Example();*/
                }
            }
            while (OurRobot.V7 >= OurRobot.V3)
            {
/*CircularTargetFire();*/
            }
/*CircularTargetFire();*/
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
            if (OurRobot.V7 == OurRobot.V5 && OurRobot.V5 == OurRobot.V7 || OurRobot.V5 < OurRobot.V2)
            {
/*CircularTargetFire();*/
            }
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
        }

        public override void ExitState()
        {
/*IntAndFloat();*/
            while (OurRobot.V7 <= OurRobot.V0)
            {
/*Example();*/
            }
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
            while (OurRobot.V2 == OurRobot.V6)
            {
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
            }
            if (OurRobot.V5 > OurRobot.V0 || OurRobot.V6 == OurRobot.V0)
            {
                if (OurRobot.V5 < OurRobot.V4 && OurRobot.V3 < OurRobot.V5)
                {
                    if (OurRobot.V7 < OurRobot.V3)
                    {
/*IntAndFloat();*/
                    }
                }
            }
            while (OurRobot.V6 != OurRobot.V5)
            {
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
            }
            while (OurRobot.V4 <= OurRobot.V6)
            {
                while (OurRobot.V1 <= OurRobot.V5 && OurRobot.V3 > OurRobot.V2 ||
                       OurRobot.V6 >= OurRobot.V3 && OurRobot.V1 != OurRobot.V0)
                {
/*IntAndFloat();*/
                }
            }
/*Example();*/
            while (OurRobot.V2 != OurRobot.V1 || OurRobot.V1 != OurRobot.V6 || OurRobot.V3 >= OurRobot.V1)
            {
                if (OurRobot.V7 > OurRobot.V3 || OurRobot.V5 <= OurRobot.V3 || OurRobot.V1 > OurRobot.V5 ||
                    OurRobot.V6 >= OurRobot.V0)
                {
/*IntAndFloat();*/
                }
            }
        }
    }
}