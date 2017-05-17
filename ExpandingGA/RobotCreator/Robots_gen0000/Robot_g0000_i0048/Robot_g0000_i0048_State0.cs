using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0048 OurRobot { get; set; }
		public State0 (Robot_g0000_i0048 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V0<OurRobot.V4)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(58, 3, 98);
			
/*IntAndFloat(-8,-1.0f);*/
/*IntAndFloat();*/
/*CircularTargetFire();*/
while(OurRobot.V4!=OurRobot.V3 || OurRobot.V3==OurRobot.V5 || OurRobot.V4>OurRobot.V2){/*IntAndFloat();*/}
/*IntAndFloat();*/
if(OurRobot.V3>=OurRobot.V4){if(OurRobot.V2>OurRobot.V3 && OurRobot.V2<=OurRobot.V4){/*IntAndFloat();*/}}
		}

		public override void DoStateAction()
		{
			
/*IntAndFloat();*/
/*Example();*/
/*Example();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V0==OurRobot.V1 && OurRobot.V3!=OurRobot.V1 && OurRobot.V4>=OurRobot.V0 || OurRobot.V5<OurRobot.V6){/*Example();*/}
while(OurRobot.V3>=OurRobot.V2){/*IntAndFloat();*/}
/*CircularTargetFire();*/
/*IntAndFloat();*/
if(OurRobot.V3>OurRobot.V1 || OurRobot.V4==OurRobot.V6){/*Example();*/}
while(OurRobot.V4>=OurRobot.V3){if(OurRobot.V5<=OurRobot.V0 || OurRobot.V5>OurRobot.V1 && OurRobot.V6<=OurRobot.V2){if(OurRobot.V2<OurRobot.V5 && OurRobot.V4<=OurRobot.V6 && OurRobot.V3!=OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}}
while(OurRobot.V4>=OurRobot.V5){if(OurRobot.V0>=OurRobot.V3){if(OurRobot.V3<OurRobot.V2 || OurRobot.V3>OurRobot.V1){/*IntAndFloat();*/}}}
/*IntAndFloat();*/
while(OurRobot.V3!=OurRobot.V4){/*IntAndFloat();*/}
while(OurRobot.V3>OurRobot.V4 || OurRobot.V6!=OurRobot.V0 || OurRobot.V2==OurRobot.V1 && OurRobot.V4<=OurRobot.V0){while(OurRobot.V3!=OurRobot.V5){if(OurRobot.V1==OurRobot.V2){/*CircularTargetFire();*/}}}
if(OurRobot.V6!=OurRobot.V2 || OurRobot.V1<=OurRobot.V0){/*IntAndFloat();*/}
if(OurRobot.V4==OurRobot.V3 || OurRobot.V5==OurRobot.V0){/*IntAndFloat();*/}
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
while(OurRobot.V1>OurRobot.V4){while(OurRobot.V1==OurRobot.V6 && OurRobot.V0!=OurRobot.V3){if(OurRobot.V4>=OurRobot.V2 || OurRobot.V6<=OurRobot.V1){/*IntAndFloat();*/}}}
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V6>=OurRobot.V3 && OurRobot.V3>=OurRobot.V6){if(OurRobot.V0==OurRobot.V1 || OurRobot.V4==OurRobot.V0){/*IntAndFloat();*/}}
while(OurRobot.V5==OurRobot.V0){/*Example();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V6>=OurRobot.V3 && OurRobot.V1<OurRobot.V5){if(OurRobot.V5==OurRobot.V4){/*Example();*/}}
if(OurRobot.V5>OurRobot.V2){/*IntAndFloat();*/}
while(OurRobot.V5!=OurRobot.V2){/*IntAndFloat();*/}
/*Example();*/
while(OurRobot.V4!=OurRobot.V5 && OurRobot.V3>OurRobot.V5 && OurRobot.V6<=OurRobot.V3 && OurRobot.V1<=OurRobot.V0){while(OurRobot.V0<OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*CircularTargetFire();*/
		}
	}
}