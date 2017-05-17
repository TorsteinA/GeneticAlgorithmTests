using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0005 OurRobot { get; set; }
		public State0 (Robot_g0000_i0005 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V0>OurRobot.V6 || OurRobot.V5<=OurRobot.V7 && OurRobot.V6!=OurRobot.V1 || OurRobot.V0<=OurRobot.V2)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(53, 17, 177);
			
/*IntAndFloat(-1,-1.0f);*/
if(OurRobot.V4==OurRobot.V6 || OurRobot.V1>OurRobot.V6){/*IntAndFloat();*/}
/*IntAndFloat();*/
if(OurRobot.V6==OurRobot.V2 || OurRobot.V5>=OurRobot.V4){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*Example();*/
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
		}

		public override void DoStateAction()
		{
			
/*IntAndFloat();*/
while(OurRobot.V6>=OurRobot.V5 && OurRobot.V0==OurRobot.V2 && OurRobot.V4>OurRobot.V6 && OurRobot.V4==OurRobot.V6){if(OurRobot.V3<OurRobot.V2 && OurRobot.V2==OurRobot.V3 || OurRobot.V2!=OurRobot.V1){if(OurRobot.V7<=OurRobot.V4){/*IntAndFloat();*/}}}
if(OurRobot.V5!=OurRobot.V3){/*IntAndFloat();*/}
while(OurRobot.V7==OurRobot.V4 || OurRobot.V3!=OurRobot.V7 && OurRobot.V0<OurRobot.V6 && OurRobot.V5==OurRobot.V0){/*Example();*/}
if(OurRobot.V6<=OurRobot.V7 || OurRobot.V0<=OurRobot.V1 || OurRobot.V4>OurRobot.V7 && OurRobot.V6<OurRobot.V3){while(OurRobot.V0>=OurRobot.V3){/*Example();*/}}
while(OurRobot.V1!=OurRobot.V5){while(OurRobot.V3!=OurRobot.V1){/*IntAndFloat();*/}}
/*IntAndFloat();*/
while(OurRobot.V3>=OurRobot.V1 || OurRobot.V6!=OurRobot.V5 || OurRobot.V3<OurRobot.V2){if(OurRobot.V4<=OurRobot.V0){if(OurRobot.V2<OurRobot.V5){/*CircularTargetFire();*/}}}
if(OurRobot.V5!=OurRobot.V0){/*IntAndFloat();*/}
if(OurRobot.V4==OurRobot.V3 || OurRobot.V6==OurRobot.V4 || OurRobot.V0<OurRobot.V1){while(OurRobot.V0<OurRobot.V7){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
if(OurRobot.V0<=OurRobot.V4 || OurRobot.V3<=OurRobot.V6 || OurRobot.V4!=OurRobot.V0){while(OurRobot.V3==OurRobot.V1 || OurRobot.V2==OurRobot.V3 || OurRobot.V5>=OurRobot.V2 && OurRobot.V6>OurRobot.V0){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
if(OurRobot.V5>OurRobot.V4){while(OurRobot.V0!=OurRobot.V4 || OurRobot.V2<OurRobot.V6){/*Example();*/}}
if(OurRobot.V5!=OurRobot.V0){if(OurRobot.V6<OurRobot.V2 || OurRobot.V1!=OurRobot.V7){/*IntAndFloat();*/}}
while(OurRobot.V1<OurRobot.V3 || OurRobot.V6==OurRobot.V5 || OurRobot.V3<OurRobot.V5){while(OurRobot.V7>OurRobot.V2){/*Example();*/}}
/*CircularTargetFire();*/
if(OurRobot.V6<OurRobot.V7){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
if(OurRobot.V6==OurRobot.V0 || OurRobot.V3==OurRobot.V2 && OurRobot.V5>=OurRobot.V3){/*IntAndFloat();*/}
while(OurRobot.V7>OurRobot.V1){if(OurRobot.V0==OurRobot.V2){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*CircularTargetFire();*/
while(OurRobot.V6>=OurRobot.V2){/*IntAndFloat();*/}
while(OurRobot.V3<=OurRobot.V5){while(OurRobot.V1==OurRobot.V3){if(OurRobot.V4>OurRobot.V0){/*IntAndFloat();*/}}}
while(OurRobot.V7==OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V4<=OurRobot.V6 || OurRobot.V6>OurRobot.V7 && OurRobot.V3<OurRobot.V0 && OurRobot.V5<=OurRobot.V1){while(OurRobot.V3<=OurRobot.V0){/*Example();*/}}
		}
	}
}