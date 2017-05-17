using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0032 OurRobot { get; set; }
		public State0 (Robot_g0000_i0032 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V3>OurRobot.V0)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(238, 138, 21);
			
while(OurRobot.V3<=OurRobot.V2 && OurRobot.V2==OurRobot.V1 || OurRobot.V3>=OurRobot.V1 || OurRobot.V1<=OurRobot.V0){while(OurRobot.V2==OurRobot.V1 && OurRobot.V1>=OurRobot.V2 || OurRobot.V1<OurRobot.V3){/*IntAndFloat(-1,-1.0f);*/}}
/*Example();*/
/*CircularTargetFire();*/
while(OurRobot.V0<OurRobot.V3 && OurRobot.V4>=OurRobot.V0 && OurRobot.V4>=OurRobot.V2 || OurRobot.V2!=OurRobot.V4){if(OurRobot.V3<=OurRobot.V0){/*Example();*/}}
while(OurRobot.V3!=OurRobot.V0){if(OurRobot.V2>OurRobot.V3 && OurRobot.V2<=OurRobot.V3){/*IntAndFloat();*/}}
while(OurRobot.V3>OurRobot.V4 || OurRobot.V3==OurRobot.V4){/*IntAndFloat();*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V1<=OurRobot.V0 || OurRobot.V0>=OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*Example();*/
		}

		public override void DoStateAction()
		{
			
/*IntAndFloat();*/
while(OurRobot.V4<=OurRobot.V0 || OurRobot.V0==OurRobot.V1 || OurRobot.V1<=OurRobot.V0){/*CircularTargetFire();*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V0>=OurRobot.V2 || OurRobot.V2<OurRobot.V1 && OurRobot.V0<=OurRobot.V2 || OurRobot.V0<=OurRobot.V2){/*IntAndFloat();*/}
while(OurRobot.V2<=OurRobot.V1){/*IntAndFloat();*/}
if(OurRobot.V4!=OurRobot.V2){/*Example();*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V1!=OurRobot.V2 && OurRobot.V1<=OurRobot.V4 && OurRobot.V0>OurRobot.V2){while(OurRobot.V0>OurRobot.V2){/*Example();*/}}
/*Example();*/
/*IntAndFloat();*/
if(OurRobot.V3>OurRobot.V4 || OurRobot.V2>=OurRobot.V0){while(OurRobot.V1==OurRobot.V3){/*IntAndFloat();*/}}
while(OurRobot.V3==OurRobot.V4 && OurRobot.V4<=OurRobot.V2 && OurRobot.V3>OurRobot.V2 && OurRobot.V2!=OurRobot.V4){if(OurRobot.V2<OurRobot.V1){/*IntAndFloat();*/}}
while(OurRobot.V2>=OurRobot.V4){while(OurRobot.V4<OurRobot.V3){/*IntAndFloat();*/}}
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
if(OurRobot.V2==OurRobot.V4 && OurRobot.V4<OurRobot.V3 || OurRobot.V3>=OurRobot.V4 || OurRobot.V0!=OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*Example();*/
		}
	}
}