using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0031 OurRobot { get; set; }
		public State0 (Robot_g0000_i0031 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V3<=OurRobot.V7)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(1, 239, 126);
			
while(OurRobot.V2<OurRobot.V0 && OurRobot.V6<OurRobot.V3){if(OurRobot.V7!=OurRobot.V6){/*Example();*/}}
while(OurRobot.V3<=OurRobot.V7 || OurRobot.V7!=OurRobot.V0 && OurRobot.V4>OurRobot.V5 || OurRobot.V4>OurRobot.V2){/*IntAndFloat(-1,-1.0f);*/}
/*IntAndFloat();*/
if(OurRobot.V0<OurRobot.V3 || OurRobot.V2<=OurRobot.V4){while(OurRobot.V2!=OurRobot.V5 && OurRobot.V1<=OurRobot.V2 || OurRobot.V6<OurRobot.V0 && OurRobot.V7==OurRobot.V0){/*Example();*/}}
/*CircularTargetFire();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V1!=OurRobot.V0){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*CircularTargetFire();*/
/*IntAndFloat();*/
while(OurRobot.V3<OurRobot.V7){if(OurRobot.V2>OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V4<=OurRobot.V7){while(OurRobot.V6==OurRobot.V5){/*IntAndFloat();*/}}
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V5!=OurRobot.V3 || OurRobot.V4<OurRobot.V6){/*IntAndFloat();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V0<=OurRobot.V6 && OurRobot.V5<=OurRobot.V2){if(OurRobot.V3<=OurRobot.V6 || OurRobot.V0==OurRobot.V1){if(OurRobot.V0>=OurRobot.V7){/*IntAndFloat();*/}}}
/*CircularTargetFire();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*CircularTargetFire();*/
while(OurRobot.V3==OurRobot.V5 && OurRobot.V6>=OurRobot.V3){/*CircularTargetFire();*/}
while(OurRobot.V4==OurRobot.V2 || OurRobot.V7>=OurRobot.V1 && OurRobot.V7==OurRobot.V1 || OurRobot.V0>=OurRobot.V3){if(OurRobot.V4==OurRobot.V1){/*IntAndFloat();*/}}
while(OurRobot.V0!=OurRobot.V6){while(OurRobot.V4>OurRobot.V5 && OurRobot.V6<=OurRobot.V7){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*Example();*/
		}

		public override void ExitState()
		{
			
while(OurRobot.V5>=OurRobot.V7 && OurRobot.V3>OurRobot.V2){/*IntAndFloat();*/}
/*IntAndFloat();*/
if(OurRobot.V0<OurRobot.V4){/*IntAndFloat();*/}
while(OurRobot.V3<OurRobot.V6){while(OurRobot.V0==OurRobot.V4 && OurRobot.V4>=OurRobot.V2 && OurRobot.V1!=OurRobot.V3 && OurRobot.V6>=OurRobot.V3){/*CircularTargetFire();*/}}
while(OurRobot.V5>OurRobot.V7 || OurRobot.V1<OurRobot.V6 || OurRobot.V3<OurRobot.V7){if(OurRobot.V0<OurRobot.V2 || OurRobot.V1==OurRobot.V6){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*CircularTargetFire();*/
while(OurRobot.V6<=OurRobot.V1 || OurRobot.V3!=OurRobot.V1 || OurRobot.V6<OurRobot.V1 || OurRobot.V3>OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V4==OurRobot.V6 || OurRobot.V3!=OurRobot.V7){if(OurRobot.V0!=OurRobot.V4){/*IntAndFloat();*/}}
		}
	}
}