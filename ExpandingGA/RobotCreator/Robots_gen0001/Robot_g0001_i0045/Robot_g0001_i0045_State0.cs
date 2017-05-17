using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0045 OurRobot { get; set; }
		public State0 (Robot_g0001_i0045 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V0>OurRobot.V3)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(203, 71, 181);
			
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V3<=OurRobot.V1){/*IntAndFloat(-6,-1.0f);*/}
if(OurRobot.V2!=OurRobot.V5){while(OurRobot.V7<OurRobot.V4 && OurRobot.V2!=OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
while(OurRobot.V6==OurRobot.V1){while(OurRobot.V7>=OurRobot.V0 || OurRobot.V2!=OurRobot.V4){if(OurRobot.V4<OurRobot.V7 && OurRobot.V4<=OurRobot.V0){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
/*Example();*/
while(OurRobot.V2>OurRobot.V5 || OurRobot.V2!=OurRobot.V4 || OurRobot.V7!=OurRobot.V4 && OurRobot.V0<=OurRobot.V3){/*IntAndFloat();*/}
		}

		public override void DoStateAction()
		{
			
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*CircularTargetFire();*/
if(OurRobot.V4==OurRobot.V0){/*IntAndFloat();*/}
if(OurRobot.V0>OurRobot.V6 || OurRobot.V7==OurRobot.V2){if(OurRobot.V1<OurRobot.V0 || OurRobot.V5!=OurRobot.V6){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V0!=OurRobot.V1){while(OurRobot.V6!=OurRobot.V7 || OurRobot.V6>=OurRobot.V1 || OurRobot.V3>=OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*IntAndFloat();*/
/*Example();*/
while(OurRobot.V1>OurRobot.V2){while(OurRobot.V1<=OurRobot.V0 && OurRobot.V6>OurRobot.V3){/*IntAndFloat();*/}}
/*CircularTargetFire();*/
if(OurRobot.V6!=OurRobot.V3 || OurRobot.V0==OurRobot.V3){if(OurRobot.V0<OurRobot.V2 && OurRobot.V5>=OurRobot.V4 || OurRobot.V6!=OurRobot.V1 && OurRobot.V3>=OurRobot.V7){if(OurRobot.V2<=OurRobot.V6 || OurRobot.V5==OurRobot.V7 && OurRobot.V6==OurRobot.V3 && OurRobot.V5>OurRobot.V4){/*IntAndFloat();*/}}}
while(OurRobot.V4>OurRobot.V3){if(OurRobot.V5==OurRobot.V0){/*IntAndFloat();*/}}
if(OurRobot.V1<=OurRobot.V3 || OurRobot.V2<OurRobot.V4){/*IntAndFloat();*/}
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*CircularTargetFire();*/
		}
	}
}