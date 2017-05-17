using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0020 OurRobot { get; set; }
		public State1 (Robot_g0001_i0020 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V1!=OurRobot.V2 && OurRobot.V1>OurRobot.V3)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(198, 161, 39);
			
while(OurRobot.V4>=OurRobot.V0 && OurRobot.V3==OurRobot.V2 && OurRobot.V0>=OurRobot.V2 && OurRobot.V4>OurRobot.V0){if(OurRobot.V3>=OurRobot.V2){if(OurRobot.V1<=OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}}
/*Example();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V3!=OurRobot.V0){if(OurRobot.V0==OurRobot.V1){if(OurRobot.V0<=OurRobot.V3){/*IntAndFloat(-1,-1.0f);*/}}}
while(OurRobot.V0<OurRobot.V3 || OurRobot.V0<=OurRobot.V1){/*Example();*/}
while(OurRobot.V0!=OurRobot.V2){while(OurRobot.V1<=OurRobot.V0 || OurRobot.V4<OurRobot.V2 && OurRobot.V3!=OurRobot.V0){/*IntAndFloat();*/}}
while(OurRobot.V0<=OurRobot.V1 && OurRobot.V3==OurRobot.V4 || OurRobot.V4<OurRobot.V0 || OurRobot.V4!=OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
if(OurRobot.V2<=OurRobot.V3){/*IntAndFloat();*/}
if(OurRobot.V1>=OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V4!=OurRobot.V1){if(OurRobot.V1>OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
		}

		public override void DoStateAction()
		{
			
/*CircularTargetFire();*/
if(OurRobot.V1<OurRobot.V0 && OurRobot.V4<OurRobot.V2){if(OurRobot.V1>=OurRobot.V3 || OurRobot.V3<OurRobot.V0){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
while(OurRobot.V1<=OurRobot.V2 && OurRobot.V4<=OurRobot.V3 || OurRobot.V2==OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*IntAndFloat();*/
if(OurRobot.V0>OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
while(OurRobot.V0==OurRobot.V1){while(OurRobot.V3==OurRobot.V4 || OurRobot.V2>=OurRobot.V4 || OurRobot.V2==OurRobot.V4){if(OurRobot.V1<OurRobot.V3 && OurRobot.V2!=OurRobot.V1){/*IntAndFloat();*/}}}
/*CircularTargetFire();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V4!=OurRobot.V2 && OurRobot.V2>=OurRobot.V0){/*IntAndFloat();*/}
/*IntAndFloat();*/
while(OurRobot.V2!=OurRobot.V3){if(OurRobot.V2<OurRobot.V3){/*IntAndFloat();*/}}
while(OurRobot.V2!=OurRobot.V0 && OurRobot.V1!=OurRobot.V2){/*IntAndFloat();*/}
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
if(OurRobot.V2<OurRobot.V4 || OurRobot.V0>OurRobot.V2 && OurRobot.V4>OurRobot.V0){if(OurRobot.V3==OurRobot.V2){if(OurRobot.V2==OurRobot.V0 || OurRobot.V4>OurRobot.V0){/*CircularTargetFire();*/}}}
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V3==OurRobot.V4 && OurRobot.V0<OurRobot.V1 && OurRobot.V4!=OurRobot.V1){if(OurRobot.V0>=OurRobot.V1 && OurRobot.V2!=OurRobot.V3 || OurRobot.V1>OurRobot.V4 || OurRobot.V3>=OurRobot.V2){/*IntAndFloat();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V1>=OurRobot.V3){while(OurRobot.V3==OurRobot.V1){/*CircularTargetFire();*/}}
/*IntAndFloat();*/
if(OurRobot.V4==OurRobot.V2 || OurRobot.V1<OurRobot.V4 && OurRobot.V4>=OurRobot.V1 && OurRobot.V2<=OurRobot.V1){/*IntAndFloat();*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*CircularTargetFire();*/
/*CircularTargetFire();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V1<=OurRobot.V4){while(OurRobot.V1!=OurRobot.V2){/*IntAndFloat();*/}}
		}
	}
}