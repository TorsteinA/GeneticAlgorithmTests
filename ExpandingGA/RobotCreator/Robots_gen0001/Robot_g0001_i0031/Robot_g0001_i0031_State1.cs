using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0031 OurRobot { get; set; }
		public State1 (Robot_g0001_i0031 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V7>OurRobot.V4 && OurRobot.V0>=OurRobot.V4)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(111, 37, 20);
			
/*IntAndFloat();*/
/*CircularTargetFire();*/
/*IntAndFloat();*/
while(OurRobot.V3<OurRobot.V7){if(OurRobot.V2>OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*IntAndFloat();*/
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V5==OurRobot.V2 && OurRobot.V7>OurRobot.V1 && OurRobot.V2>=OurRobot.V5){if(OurRobot.V0>OurRobot.V1 && OurRobot.V7==OurRobot.V6){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
while(OurRobot.V5>OurRobot.V4 || OurRobot.V2<=OurRobot.V6 && OurRobot.V4>OurRobot.V6){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V3>=OurRobot.V2){/*IntAndFloat();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V4==OurRobot.V6 || OurRobot.V3!=OurRobot.V7){if(OurRobot.V0!=OurRobot.V4){/*IntAndFloat();*/}}
while(OurRobot.V2>OurRobot.V4){/*Example();*/}
		}
	}
}