using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0048 OurRobot { get; set; }
		public State1 (Robot_g0000_i0048 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V4>=OurRobot.V3 && OurRobot.V4==OurRobot.V3 || OurRobot.V3!=OurRobot.V5 || OurRobot.V6>=OurRobot.V3)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(19, 189, 221);
			
if(OurRobot.V5<=OurRobot.V4 && OurRobot.V1>=OurRobot.V4 && OurRobot.V2==OurRobot.V1 && OurRobot.V5<=OurRobot.V6){while(OurRobot.V1==OurRobot.V4){/*Example();*/}}
if(OurRobot.V4==OurRobot.V2){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
if(OurRobot.V1<OurRobot.V2 || OurRobot.V6<=OurRobot.V0 && OurRobot.V0<=OurRobot.V1 || OurRobot.V4<=OurRobot.V3){while(OurRobot.V1==OurRobot.V6){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
while(OurRobot.V5<=OurRobot.V6 && OurRobot.V2<=OurRobot.V0 && OurRobot.V1<=OurRobot.V3){if(OurRobot.V5==OurRobot.V1 || OurRobot.V2==OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
while(OurRobot.V0==OurRobot.V2){/*Example();*/}
while(OurRobot.V6!=OurRobot.V1){/*Example();*/}
if(OurRobot.V0>=OurRobot.V5 || OurRobot.V1<=OurRobot.V6 && OurRobot.V4>=OurRobot.V2 || OurRobot.V6<=OurRobot.V1){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V6>=OurRobot.V3 && OurRobot.V3>=OurRobot.V6){if(OurRobot.V0==OurRobot.V1 || OurRobot.V4==OurRobot.V0){/*IntAndFloat();*/}}
while(OurRobot.V5==OurRobot.V0){/*Example();*/}
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V1<OurRobot.V5 && OurRobot.V3<OurRobot.V2 || OurRobot.V3>OurRobot.V1){while(OurRobot.V3==OurRobot.V6 && OurRobot.V0>OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*Example();*/
while(OurRobot.V6!=OurRobot.V0 || OurRobot.V2==OurRobot.V1 && OurRobot.V4<=OurRobot.V0){while(OurRobot.V3!=OurRobot.V5){if(OurRobot.V1==OurRobot.V2){/*CircularTargetFire();*/}}}
if(OurRobot.V6!=OurRobot.V2 || OurRobot.V1<=OurRobot.V0){/*IntAndFloat();*/}
if(OurRobot.V4==OurRobot.V3 || OurRobot.V5==OurRobot.V0){/*IntAndFloat();*/}
/*IntAndFloat();*/
if(OurRobot.V2<OurRobot.V4 || OurRobot.V3!=OurRobot.V2){/*IntAndFloat();*/}
/*CircularTargetFire();*/
while(OurRobot.V6<OurRobot.V0){/*IntAndFloat();*/}
if(OurRobot.V5!=OurRobot.V3){while(OurRobot.V0!=OurRobot.V5){if(OurRobot.V6<=OurRobot.V5 || OurRobot.V5<=OurRobot.V0){/*IntAndFloat();*/}}}
if(OurRobot.V6<OurRobot.V1 && OurRobot.V0>=OurRobot.V1){/*IntAndFloat();*/}
/*Example();*/
while(OurRobot.V6<OurRobot.V3 || OurRobot.V5>OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
while(OurRobot.V5==OurRobot.V3){while(OurRobot.V1<=OurRobot.V2 && OurRobot.V0<OurRobot.V1){/*CircularTargetFire();*/}}
		}

		public override void ExitState()
		{
			
/*Example();*/
		}
	}
}