using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0025 OurRobot { get; set; }
		public State1 (Robot_g0000_i0025 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V6<OurRobot.V2 || OurRobot.V3<=OurRobot.V2)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(168, 230, 212);
			
/*Example();*/
if(OurRobot.V2==OurRobot.V1 || OurRobot.V2<=OurRobot.V5){if(OurRobot.V1<OurRobot.V3){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V6==OurRobot.V1 || OurRobot.V6<OurRobot.V7){if(OurRobot.V4==OurRobot.V6 || OurRobot.V2<=OurRobot.V6 && OurRobot.V2==OurRobot.V1 && OurRobot.V5>OurRobot.V7){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*Example();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V0!=OurRobot.V6 && OurRobot.V1<=OurRobot.V0){if(OurRobot.V4==OurRobot.V7){/*CircularTargetFire();*/}}
while(OurRobot.V4<OurRobot.V0 || OurRobot.V0<OurRobot.V2 || OurRobot.V6==OurRobot.V2 && OurRobot.V1>OurRobot.V3){while(OurRobot.V2>=OurRobot.V3){if(OurRobot.V6==OurRobot.V4){/*IntAndFloat();*/}}}
if(OurRobot.V2<OurRobot.V3){while(OurRobot.V5>OurRobot.V6){/*IntAndFloat();*/}}
while(OurRobot.V7>OurRobot.V2){while(OurRobot.V6!=OurRobot.V1){if(OurRobot.V1>OurRobot.V5){/*IntAndFloat();*/}}}
/*Example();*/
/*Example();*/
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V0<=OurRobot.V5 && OurRobot.V4!=OurRobot.V1 && OurRobot.V2<OurRobot.V1){while(OurRobot.V7<OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V4<=OurRobot.V5 && OurRobot.V5<OurRobot.V1){if(OurRobot.V5!=OurRobot.V3){/*IntAndFloat();*/}}
if(OurRobot.V1<OurRobot.V5 || OurRobot.V6>OurRobot.V1){while(OurRobot.V6>OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*IntAndFloat();*/
if(OurRobot.V4!=OurRobot.V0){/*Example();*/}
/*IntAndFloat();*/
while(OurRobot.V0<OurRobot.V5){/*IntAndFloat();*/}
/*Example();*/
while(OurRobot.V3==OurRobot.V5){while(OurRobot.V0<=OurRobot.V4){/*IntAndFloat();*/}}
while(OurRobot.V3>OurRobot.V2){/*CircularTargetFire();*/}
while(OurRobot.V6>OurRobot.V3 && OurRobot.V3!=OurRobot.V4 && OurRobot.V2==OurRobot.V1 || OurRobot.V6<=OurRobot.V2){/*IntAndFloat();*/}
		}

		public override void ExitState()
		{
			
if(OurRobot.V1!=OurRobot.V7 && OurRobot.V6!=OurRobot.V3 && OurRobot.V2<OurRobot.V0){/*IntAndFloat();*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*CircularTargetFire();*/
/*IntAndFloat();*/
/*CircularTargetFire();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V0>OurRobot.V1){/*Example();*/}
while(OurRobot.V3<OurRobot.V1){/*IntAndFloat();*/}
		}
	}
}