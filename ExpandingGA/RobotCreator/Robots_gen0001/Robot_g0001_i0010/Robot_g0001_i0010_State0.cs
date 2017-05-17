using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0010 OurRobot { get; set; }
		public State0 (Robot_g0001_i0010 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V0!=OurRobot.V2)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(64, 149, 93);
			
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*Example();*/
/*IntAndFloat(-1,-1.0f);*/
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V1<OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
		}

		public override void DoStateAction()
		{
			
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*CircularTargetFire();*/
/*IntAndFloat();*/
while(OurRobot.V2<OurRobot.V5 || OurRobot.V1<=OurRobot.V5){while(OurRobot.V0>OurRobot.V7){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V1!=OurRobot.V4 || OurRobot.V7>=OurRobot.V4 && OurRobot.V7<OurRobot.V4 || OurRobot.V2<OurRobot.V3){/*IntAndFloat();*/}
if(OurRobot.V7!=OurRobot.V0){while(OurRobot.V1==OurRobot.V4){if(OurRobot.V5>=OurRobot.V1 && OurRobot.V6<OurRobot.V3){/*CircularTargetFire();*/}}}
if(OurRobot.V1>OurRobot.V2 || OurRobot.V4>OurRobot.V6 || OurRobot.V1>=OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
while(OurRobot.V6!=OurRobot.V3){while(OurRobot.V2<=OurRobot.V7 && OurRobot.V6>=OurRobot.V0 && OurRobot.V3==OurRobot.V2){if(OurRobot.V3<OurRobot.V4 && OurRobot.V1!=OurRobot.V7 && OurRobot.V4==OurRobot.V5 && OurRobot.V1<=OurRobot.V3){/*CircularTargetFire();*/}}}
		}

		public override void ExitState()
		{
			
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
while(OurRobot.V5==OurRobot.V7 && OurRobot.V4>=OurRobot.V0){if(OurRobot.V6>OurRobot.V4 && OurRobot.V0>OurRobot.V5){if(OurRobot.V5>=OurRobot.V1 && OurRobot.V3<OurRobot.V1 && OurRobot.V3<OurRobot.V7 || OurRobot.V3<OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}}
/*Example();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*CircularTargetFire();*/
/*CircularTargetFire();*/
/*IntAndFloat();*/
while(OurRobot.V1>OurRobot.V6 || OurRobot.V5>OurRobot.V3){while(OurRobot.V1<OurRobot.V4 || OurRobot.V4!=OurRobot.V2){/*IntAndFloat();*/}}
if(OurRobot.V2>OurRobot.V0 && OurRobot.V7!=OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*IntAndFloat();*/
while(OurRobot.V2>=OurRobot.V0){if(OurRobot.V1!=OurRobot.V0 || OurRobot.V2<=OurRobot.V0){if(OurRobot.V1!=OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}}
/*CircularTargetFire();*/
		}
	}
}