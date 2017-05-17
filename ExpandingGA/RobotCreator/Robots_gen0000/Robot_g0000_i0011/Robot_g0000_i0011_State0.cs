using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0011 OurRobot { get; set; }
		public State0 (Robot_g0000_i0011 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V5>OurRobot.V0)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(128, 133, 10);
			
if(OurRobot.V3<=OurRobot.V4 && OurRobot.V4>OurRobot.V3 && OurRobot.V1>OurRobot.V0 && OurRobot.V3!=OurRobot.V2){if(OurRobot.V4!=OurRobot.V2){/*Example();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V0>=OurRobot.V1){if(OurRobot.V1!=OurRobot.V3 && OurRobot.V5!=OurRobot.V2 && OurRobot.V0<OurRobot.V1){/*IntAndFloat(-11,-1.0f);*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V2>OurRobot.V1 && OurRobot.V0>=OurRobot.V4){if(OurRobot.V2>=OurRobot.V3){/*IntAndFloat();*/}}
if(OurRobot.V1==OurRobot.V0 && OurRobot.V1>=OurRobot.V3){while(OurRobot.V0>=OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*IntAndFloat();*/
/*CircularTargetFire();*/
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V0<OurRobot.V3){/*IntAndFloat();*/}
if(OurRobot.V4>OurRobot.V3 && OurRobot.V2<=OurRobot.V1 || OurRobot.V4>=OurRobot.V5 && OurRobot.V0!=OurRobot.V5){if(OurRobot.V3<OurRobot.V4){/*IntAndFloat();*/}}
while(OurRobot.V5!=OurRobot.V4){if(OurRobot.V1>OurRobot.V0){/*IntAndFloat();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*Example();*/
while(OurRobot.V1==OurRobot.V3){/*IntAndFloat();*/}
		}

		public override void ExitState()
		{
			
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
/*CircularTargetFire();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V0<=OurRobot.V5){while(OurRobot.V2>OurRobot.V1){/*IntAndFloat();*/}}
while(OurRobot.V2>=OurRobot.V0){while(OurRobot.V2!=OurRobot.V1){/*Example();*/}}
if(OurRobot.V2<OurRobot.V3 && OurRobot.V5>OurRobot.V3 && OurRobot.V2<OurRobot.V1){if(OurRobot.V3>OurRobot.V0){/*IntAndFloat();*/}}
if(OurRobot.V0==OurRobot.V3 || OurRobot.V0>OurRobot.V5){while(OurRobot.V2>=OurRobot.V0 && OurRobot.V0>=OurRobot.V5 || OurRobot.V4<OurRobot.V2 || OurRobot.V2<OurRobot.V5){/*Example();*/}}
/*CircularTargetFire();*/
		}
	}
}