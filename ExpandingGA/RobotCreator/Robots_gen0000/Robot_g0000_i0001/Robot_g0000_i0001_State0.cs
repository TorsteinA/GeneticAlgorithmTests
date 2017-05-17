using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0001 OurRobot { get; set; }
		public State0 (Robot_g0000_i0001 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V3<=OurRobot.V1 && OurRobot.V2<OurRobot.V4 && OurRobot.V2==OurRobot.V0)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(176, 228, 221);
			
while(OurRobot.V1!=OurRobot.V2 || OurRobot.V4>OurRobot.V2){if(OurRobot.V1>=OurRobot.V2 || OurRobot.V2<OurRobot.V1 && OurRobot.V3<OurRobot.V0 && OurRobot.V0>=OurRobot.V3){if(OurRobot.V0!=OurRobot.V2){/*IntAndFloat(-1,-1.0f);*/}}}
/*CircularTargetFire();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V2>OurRobot.V0 || OurRobot.V3>OurRobot.V1 && OurRobot.V4==OurRobot.V0 || OurRobot.V1<OurRobot.V4){/*IntAndFloat();*/}
if(OurRobot.V2>=OurRobot.V3 || OurRobot.V4!=OurRobot.V2){/*CircularTargetFire();*/}
if(OurRobot.V0<OurRobot.V2){while(OurRobot.V1==OurRobot.V2 && OurRobot.V3>OurRobot.V1 || OurRobot.V2<OurRobot.V4 || OurRobot.V3<=OurRobot.V1){/*IntAndFloat();*/}}
if(OurRobot.V1<=OurRobot.V0 && OurRobot.V3>OurRobot.V1){/*CircularTargetFire();*/}
while(OurRobot.V1<OurRobot.V0 || OurRobot.V0>OurRobot.V2){/*IntAndFloat();*/}
/*CircularTargetFire();*/
while(OurRobot.V3!=OurRobot.V0 || OurRobot.V0<OurRobot.V1 || OurRobot.V2<=OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
if(OurRobot.V2!=OurRobot.V0 || OurRobot.V0<=OurRobot.V4){if(OurRobot.V4>OurRobot.V2 || OurRobot.V3!=OurRobot.V4 || OurRobot.V0!=OurRobot.V1){/*IntAndFloat();*/}}
/*IntAndFloat();*/
		}

		public override void DoStateAction()
		{
			
/*Example();*/
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V4>=OurRobot.V2 && OurRobot.V2==OurRobot.V4){if(OurRobot.V1<=OurRobot.V2 || OurRobot.V3==OurRobot.V1){/*IntAndFloat();*/}}
while(OurRobot.V2==OurRobot.V1){while(OurRobot.V0<OurRobot.V4){/*Example();*/}}
if(OurRobot.V0>OurRobot.V1 || OurRobot.V0>OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V1>=OurRobot.V3){while(OurRobot.V2>=OurRobot.V4){/*Example();*/}}
		}

		public override void ExitState()
		{
			
while(OurRobot.V3!=OurRobot.V1){/*Example();*/}
if(OurRobot.V1!=OurRobot.V3){if(OurRobot.V2>OurRobot.V3){/*IntAndFloat();*/}}
if(OurRobot.V0!=OurRobot.V4){/*CircularTargetFire();*/}
/*Example();*/
if(OurRobot.V1<OurRobot.V4){if(OurRobot.V1>=OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
while(OurRobot.V0!=OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
if(OurRobot.V2!=OurRobot.V3){if(OurRobot.V1!=OurRobot.V3 || OurRobot.V1!=OurRobot.V3 && OurRobot.V2<OurRobot.V1){/*IntAndFloat();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V1==OurRobot.V3){/*CircularTargetFire();*/}
		}
	}
}