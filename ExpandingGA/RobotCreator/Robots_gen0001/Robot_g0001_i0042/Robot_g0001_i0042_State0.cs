using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0042 OurRobot { get; set; }
		public State0 (Robot_g0001_i0042 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V4>OurRobot.V3)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(138, 139, 38);
			
/*IntAndFloat(-23,-1.0f);*/
while(OurRobot.V2>=OurRobot.V0 && OurRobot.V3<=OurRobot.V1 || OurRobot.V3>=OurRobot.V0){/*IntAndFloat();*/}
while(OurRobot.V6>OurRobot.V7 && OurRobot.V5<=OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
while(OurRobot.V3>OurRobot.V5){/*IntAndFloat();*/}
/*IntAndFloat();*/
if(OurRobot.V4<OurRobot.V7){while(OurRobot.V4!=OurRobot.V7 && OurRobot.V7==OurRobot.V1 || OurRobot.V7!=OurRobot.V1 && OurRobot.V4<OurRobot.V3){if(OurRobot.V6<=OurRobot.V1){/*IntAndFloat();*/}}}
/*IntAndFloat();*/
while(OurRobot.V1<=OurRobot.V0 && OurRobot.V4<=OurRobot.V3){while(OurRobot.V0<=OurRobot.V7){/*IntAndFloat();*/}}
if(OurRobot.V6==OurRobot.V3 && OurRobot.V7<OurRobot.V5){if(OurRobot.V3!=OurRobot.V6){/*IntAndFloat();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V3>=OurRobot.V6){/*IntAndFloat();*/}
if(OurRobot.V4==OurRobot.V7 || OurRobot.V1>=OurRobot.V4 && OurRobot.V4!=OurRobot.V2 || OurRobot.V1!=OurRobot.V5){if(OurRobot.V6==OurRobot.V5 || OurRobot.V4<OurRobot.V3){if(OurRobot.V5>=OurRobot.V6 && OurRobot.V6!=OurRobot.V4 || OurRobot.V6>=OurRobot.V4 && OurRobot.V0>OurRobot.V6){/*CircularTargetFire();*/}}}
if(OurRobot.V3!=OurRobot.V4 && OurRobot.V5<OurRobot.V7 || OurRobot.V2<=OurRobot.V4){while(OurRobot.V3>=OurRobot.V7 && OurRobot.V4!=OurRobot.V3 || OurRobot.V6>OurRobot.V3){/*IntAndFloat();*/}}
while(OurRobot.V5==OurRobot.V0 && OurRobot.V6>=OurRobot.V4){while(OurRobot.V6!=OurRobot.V1 || OurRobot.V5==OurRobot.V1){/*IntAndFloat();*/}}
		}

		public override void DoStateAction()
		{
			
/*CircularTargetFire();*/
if(OurRobot.V6!=OurRobot.V3 || OurRobot.V6!=OurRobot.V0){while(OurRobot.V3!=OurRobot.V2){/*IntAndFloat();*/}}
/*Example();*/
if(OurRobot.V4<=OurRobot.V7){if(OurRobot.V7>OurRobot.V6){if(OurRobot.V0>OurRobot.V3 && OurRobot.V4<=OurRobot.V0){/*IntAndFloat();*/}}}
while(OurRobot.V6>OurRobot.V7){while(OurRobot.V5!=OurRobot.V2){if(OurRobot.V2<=OurRobot.V5){/*IntAndFloat();*/}}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V7<=OurRobot.V2){while(OurRobot.V5==OurRobot.V7){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V1<=OurRobot.V4){/*IntAndFloat();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V3>=OurRobot.V7){while(OurRobot.V3>OurRobot.V5 && OurRobot.V0<OurRobot.V4){/*IntAndFloat();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V1!=OurRobot.V4 && OurRobot.V0<OurRobot.V2 && OurRobot.V5==OurRobot.V0 || OurRobot.V4>=OurRobot.V1){/*IntAndFloat();*/}
		}

		public override void ExitState()
		{
			
if(OurRobot.V6>=OurRobot.V1 && OurRobot.V7<=OurRobot.V3 && OurRobot.V0!=OurRobot.V6){if(OurRobot.V7>=OurRobot.V2 || OurRobot.V1==OurRobot.V0){/*IntAndFloat();*/}}
if(OurRobot.V4==OurRobot.V0){if(OurRobot.V0<=OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
while(OurRobot.V1>=OurRobot.V5){while(OurRobot.V5==OurRobot.V1){/*IntAndFloat();*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V5<OurRobot.V6 && OurRobot.V0>OurRobot.V2 || OurRobot.V1<OurRobot.V7){/*CircularTargetFire();*/}
/*IntAndFloat();*/
if(OurRobot.V4!=OurRobot.V5 && OurRobot.V5>OurRobot.V0 && OurRobot.V0>OurRobot.V3){while(OurRobot.V7==OurRobot.V1 && OurRobot.V2<=OurRobot.V7 || OurRobot.V0!=OurRobot.V2){if(OurRobot.V2<=OurRobot.V1 || OurRobot.V4!=OurRobot.V7 || OurRobot.V4<=OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}}
if(OurRobot.V0<=OurRobot.V3){while(OurRobot.V1>=OurRobot.V4 && OurRobot.V7>OurRobot.V6){if(OurRobot.V6==OurRobot.V5 || OurRobot.V1<=OurRobot.V3){/*IntAndFloat();*/}}}
		}
	}
}