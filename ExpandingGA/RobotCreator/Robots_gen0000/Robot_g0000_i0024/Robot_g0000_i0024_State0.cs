using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0024 OurRobot { get; set; }
		public State0 (Robot_g0000_i0024 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V6>=OurRobot.V4)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(80, 25, 3);
			
/*IntAndFloat(-1,-1.0f);*/
while(OurRobot.V5>OurRobot.V3 || OurRobot.V6<OurRobot.V5){/*IntAndFloat();*/}
		}

		public override void DoStateAction()
		{
			
/*Example();*/
/*Example();*/
while(OurRobot.V1==OurRobot.V3 && OurRobot.V0!=OurRobot.V4 && OurRobot.V2>=OurRobot.V1 && OurRobot.V4<=OurRobot.V2){if(OurRobot.V6>OurRobot.V0 || OurRobot.V2<=OurRobot.V5){if(OurRobot.V0==OurRobot.V2 || OurRobot.V6>OurRobot.V4){/*Example();*/}}}
/*Example();*/
while(OurRobot.V2<OurRobot.V0 && OurRobot.V5>OurRobot.V3){while(OurRobot.V4>=OurRobot.V6 || OurRobot.V5>OurRobot.V6){if(OurRobot.V1!=OurRobot.V6){/*IntAndFloat();*/}}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
		}

		public override void ExitState()
		{
			
if(OurRobot.V6>OurRobot.V2 || OurRobot.V3>OurRobot.V5){/*CircularTargetFire();*/}
if(OurRobot.V6<OurRobot.V1){while(OurRobot.V2==OurRobot.V5){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V3>=OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
		}
	}
}