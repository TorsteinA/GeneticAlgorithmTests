using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0000 OurRobot { get; set; }
		public State0 (Robot_g0001_i0000 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V2!=OurRobot.V1)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(136, 250, 194);
			
while(OurRobot.V0==OurRobot.V4){while(OurRobot.V5!=OurRobot.V2 || OurRobot.V1!=OurRobot.V5){/*CircularTargetFire();*/}}
while(OurRobot.V0<OurRobot.V5 || OurRobot.V1>OurRobot.V0 || OurRobot.V1<=OurRobot.V0){/*IntAndFloat(31,-1.0f);*/}
/*CircularTargetFire();*/
if(OurRobot.V4>=OurRobot.V2){/*Example();*/}
/*IntAndFloat();*/
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V3!=OurRobot.V1 && OurRobot.V0>OurRobot.V1){if(OurRobot.V3>OurRobot.V1 || OurRobot.V3>OurRobot.V5 || OurRobot.V0==OurRobot.V5){/*IntAndFloat();*/}}
if(OurRobot.V4==OurRobot.V3){/*IntAndFloat();*/}
while(OurRobot.V0>=OurRobot.V2 || OurRobot.V3>=OurRobot.V0 && OurRobot.V1==OurRobot.V0){while(OurRobot.V1<OurRobot.V4 || OurRobot.V0<OurRobot.V1 && OurRobot.V2>OurRobot.V1){if(OurRobot.V2<OurRobot.V1 && OurRobot.V5!=OurRobot.V0 || OurRobot.V5!=OurRobot.V1 || OurRobot.V0==OurRobot.V2){/*CircularTargetFire();*/}}}
if(OurRobot.V1==OurRobot.V3){/*IntAndFloat();*/}
/*Example();*/
while(OurRobot.V0<=OurRobot.V4 || OurRobot.V1!=OurRobot.V0 || OurRobot.V0>OurRobot.V2 || OurRobot.V2<OurRobot.V0){/*Example();*/}
/*CircularTargetFire();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
if(OurRobot.V2>=OurRobot.V1){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V2==OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
while(OurRobot.V4==OurRobot.V2){if(OurRobot.V3>=OurRobot.V2){/*IntAndFloat();*/}}
while(OurRobot.V1>=OurRobot.V5 || OurRobot.V4!=OurRobot.V2 && OurRobot.V2!=OurRobot.V1 && OurRobot.V2==OurRobot.V1){while(OurRobot.V0<=OurRobot.V4){if(OurRobot.V1==OurRobot.V0){/*IntAndFloat();*/}}}
if(OurRobot.V3>=OurRobot.V5){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
while(OurRobot.V0!=OurRobot.V3){if(OurRobot.V2==OurRobot.V5 && OurRobot.V4!=OurRobot.V5){if(OurRobot.V2<=OurRobot.V0){/*IntAndFloat();*/}}}
/*IntAndFloat();*/
while(OurRobot.V5!=OurRobot.V4 || OurRobot.V3<OurRobot.V2){while(OurRobot.V0==OurRobot.V5 || OurRobot.V3<OurRobot.V1){/*IntAndFloat();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*CircularTargetFire();*/
		}
	}
}