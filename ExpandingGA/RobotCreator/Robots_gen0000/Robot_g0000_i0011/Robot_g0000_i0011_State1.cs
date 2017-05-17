using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0011 OurRobot { get; set; }
		public State1 (Robot_g0000_i0011 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V0==OurRobot.V4 || OurRobot.V0>OurRobot.V1)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(11, 40, 92);
			
/*IntAndFloat();*/
while(OurRobot.V3==OurRobot.V5){if(OurRobot.V3<OurRobot.V5){/*IntAndFloat();*/}}
/*CircularTargetFire();*/
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
/*Example();*/
/*IntAndFloat();*/
		}

		public override void DoStateAction()
		{
			
/*CircularTargetFire();*/
if(OurRobot.V0==OurRobot.V3){/*IntAndFloat();*/}
if(OurRobot.V0<=OurRobot.V3 && OurRobot.V0>=OurRobot.V3 || OurRobot.V1>OurRobot.V4 || OurRobot.V0>OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V0!=OurRobot.V4){if(OurRobot.V2==OurRobot.V4 || OurRobot.V4>OurRobot.V3){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*CircularTargetFire();*/
while(OurRobot.V3==OurRobot.V0){while(OurRobot.V2<OurRobot.V5){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V5==OurRobot.V0){while(OurRobot.V4<OurRobot.V2){if(OurRobot.V1!=OurRobot.V0){/*CircularTargetFire();*/}}}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V2<=OurRobot.V3 || OurRobot.V4<OurRobot.V1){if(OurRobot.V4==OurRobot.V3){if(OurRobot.V1<=OurRobot.V0 || OurRobot.V3<OurRobot.V5){/*IntAndFloat();*/}}}
while(OurRobot.V0>OurRobot.V5 && OurRobot.V2<OurRobot.V5){/*IntAndFloat();*/}
/*CircularTargetFire();*/
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V4<=OurRobot.V5 || OurRobot.V4<OurRobot.V3 || OurRobot.V4>OurRobot.V2){if(OurRobot.V3==OurRobot.V0 || OurRobot.V0<=OurRobot.V1){/*Example();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V0>=OurRobot.V2 || OurRobot.V3==OurRobot.V1 || OurRobot.V1<=OurRobot.V3){if(OurRobot.V0>OurRobot.V1 && OurRobot.V4<OurRobot.V5 && OurRobot.V3==OurRobot.V4){/*Example();*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V1>=OurRobot.V0){/*IntAndFloat();*/}
/*Example();*/
while(OurRobot.V4<OurRobot.V1){/*Example();*/}
/*IntAndFloat();*/
/*Example();*/
		}
	}
}