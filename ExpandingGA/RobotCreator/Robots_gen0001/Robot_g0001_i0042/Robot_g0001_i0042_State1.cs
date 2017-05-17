using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0042 OurRobot { get; set; }
		public State1 (Robot_g0001_i0042 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V3<=OurRobot.V6)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(51, 53, 232);
			
while(OurRobot.V0<=OurRobot.V7){while(OurRobot.V0!=OurRobot.V3 || OurRobot.V2==OurRobot.V1 && OurRobot.V0>=OurRobot.V7 || OurRobot.V2==OurRobot.V6){/*IntAndFloat();*/}}
if(OurRobot.V3>=OurRobot.V6){/*IntAndFloat();*/}
if(OurRobot.V4==OurRobot.V7 || OurRobot.V1>=OurRobot.V4 && OurRobot.V4!=OurRobot.V2 || OurRobot.V1!=OurRobot.V5){if(OurRobot.V6==OurRobot.V5 || OurRobot.V4<OurRobot.V3){if(OurRobot.V5>=OurRobot.V6 && OurRobot.V6!=OurRobot.V4 || OurRobot.V6>=OurRobot.V4 && OurRobot.V0>OurRobot.V6){/*CircularTargetFire();*/}}}
if(OurRobot.V3!=OurRobot.V4 && OurRobot.V5<OurRobot.V7 || OurRobot.V2<=OurRobot.V4){while(OurRobot.V3>=OurRobot.V7 && OurRobot.V4!=OurRobot.V3 || OurRobot.V6>OurRobot.V3){/*IntAndFloat();*/}}
while(OurRobot.V5==OurRobot.V0 && OurRobot.V6>=OurRobot.V4){while(OurRobot.V6!=OurRobot.V1 || OurRobot.V5==OurRobot.V1){/*IntAndFloat();*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V5<OurRobot.V6 && OurRobot.V0>OurRobot.V2 || OurRobot.V1<OurRobot.V7){/*CircularTargetFire();*/}
/*IntAndFloat();*/
if(OurRobot.V4!=OurRobot.V5 && OurRobot.V5>OurRobot.V0 && OurRobot.V0>OurRobot.V3){while(OurRobot.V7==OurRobot.V1 && OurRobot.V2<=OurRobot.V7 || OurRobot.V0!=OurRobot.V2){if(OurRobot.V2<=OurRobot.V1 || OurRobot.V4!=OurRobot.V7 || OurRobot.V4<=OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}}
if(OurRobot.V0<=OurRobot.V3){while(OurRobot.V1>=OurRobot.V4 && OurRobot.V7>OurRobot.V6){if(OurRobot.V6==OurRobot.V5 || OurRobot.V1<=OurRobot.V3){/*IntAndFloat();*/}}}
/*IntAndFloat();*/
if(OurRobot.V1>=OurRobot.V4 || OurRobot.V4>OurRobot.V5 && OurRobot.V4==OurRobot.V1 && OurRobot.V0>OurRobot.V2){while(OurRobot.V3<OurRobot.V0){if(OurRobot.V6!=OurRobot.V3 || OurRobot.V6!=OurRobot.V0){/*Example();*/}}}
		}

		public override void DoStateAction()
		{
			
/*IntAndFloat();*/
/*CircularTargetFire();*/
/*Example();*/
/*Example();*/
/*IntAndFloat();*/
while(OurRobot.V3>OurRobot.V5 && OurRobot.V0<OurRobot.V4){while(OurRobot.V2==OurRobot.V7 && OurRobot.V5==OurRobot.V6 || OurRobot.V7!=OurRobot.V5){/*IntAndFloat();*/}}
while(OurRobot.V2>OurRobot.V0 || OurRobot.V7==OurRobot.V5 && OurRobot.V6>=OurRobot.V2){if(OurRobot.V1!=OurRobot.V2){/*IntAndFloat();*/}}
if(OurRobot.V0>=OurRobot.V7){while(OurRobot.V4>=OurRobot.V6){if(OurRobot.V4>=OurRobot.V5 && OurRobot.V7>OurRobot.V3 && OurRobot.V6==OurRobot.V1 || OurRobot.V6!=OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}}
while(OurRobot.V0>OurRobot.V5){/*IntAndFloat();*/}
		}

		public override void ExitState()
		{
			
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V7==OurRobot.V1 && OurRobot.V2<=OurRobot.V7 || OurRobot.V0!=OurRobot.V2){if(OurRobot.V2<=OurRobot.V1 || OurRobot.V4!=OurRobot.V7 || OurRobot.V4<=OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
if(OurRobot.V0<=OurRobot.V3){while(OurRobot.V1>=OurRobot.V4 && OurRobot.V7>OurRobot.V6){if(OurRobot.V6==OurRobot.V5 || OurRobot.V1<=OurRobot.V3){/*IntAndFloat();*/}}}
/*IntAndFloat();*/
if(OurRobot.V1>=OurRobot.V4 || OurRobot.V4>OurRobot.V5 && OurRobot.V4==OurRobot.V1 && OurRobot.V0>OurRobot.V2){while(OurRobot.V3<OurRobot.V0){if(OurRobot.V6!=OurRobot.V3 || OurRobot.V6!=OurRobot.V0){/*Example();*/}}}
		}
	}
}