using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0033 OurRobot { get; set; }
		public State0 (Robot_g0000_i0033 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V5<OurRobot.V6)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(173, 115, 166);
			
/*CircularTargetFire();*/
while(OurRobot.V7>=OurRobot.V2 || OurRobot.V4>OurRobot.V5){/*IntAndFloat(-1,-1.0f);*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V1>OurRobot.V6){while(OurRobot.V5<=OurRobot.V0 || OurRobot.V7<OurRobot.V5 && OurRobot.V0!=OurRobot.V1 || OurRobot.V5==OurRobot.V6){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V7>=OurRobot.V6 || OurRobot.V1>OurRobot.V5 && OurRobot.V5>=OurRobot.V4 && OurRobot.V6<=OurRobot.V0){/*IntAndFloat();*/}
if(OurRobot.V5>OurRobot.V4 && OurRobot.V5>OurRobot.V7){while(OurRobot.V0<=OurRobot.V3 || OurRobot.V6<OurRobot.V7 && OurRobot.V4<=OurRobot.V3 && OurRobot.V5==OurRobot.V6){if(OurRobot.V4<OurRobot.V6 || OurRobot.V3<OurRobot.V1){/*Example();*/}}}
if(OurRobot.V2==OurRobot.V4){if(OurRobot.V1==OurRobot.V2 && OurRobot.V4!=OurRobot.V2){/*CircularTargetFire();*/}}
		}

		public override void DoStateAction()
		{
			
/*IntAndFloat();*/
while(OurRobot.V4<=OurRobot.V0 && OurRobot.V1!=OurRobot.V7){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
while(OurRobot.V3!=OurRobot.V6){while(OurRobot.V3!=OurRobot.V6 || OurRobot.V2<=OurRobot.V1 || OurRobot.V5<OurRobot.V2 || OurRobot.V5>OurRobot.V6){/*IntAndFloat();*/}}
while(OurRobot.V3==OurRobot.V5){while(OurRobot.V4!=OurRobot.V6){if(OurRobot.V6!=OurRobot.V5 && OurRobot.V3>=OurRobot.V1 && OurRobot.V7<=OurRobot.V5){/*IntAndFloat();*/}}}
while(OurRobot.V2>OurRobot.V0 || OurRobot.V5>=OurRobot.V2){/*IntAndFloat();*/}
if(OurRobot.V4>OurRobot.V3 || OurRobot.V6>=OurRobot.V3){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
/*CircularTargetFire();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
		}
	}
}