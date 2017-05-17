using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0030 OurRobot { get; set; }
		public State0 (Robot_g0001_i0030 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V2>OurRobot.V1)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(182, 99, 15);
			
/*IntAndFloat(17,-1.0f);*/
/*CircularTargetFire();*/
if(OurRobot.V1<OurRobot.V2 || OurRobot.V1<=OurRobot.V0 && OurRobot.V3<OurRobot.V2){while(OurRobot.V0>OurRobot.V4 && OurRobot.V3>=OurRobot.V1 || OurRobot.V2>OurRobot.V1){/*CircularTargetFire();*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*Example();*/
if(OurRobot.V2<OurRobot.V3){if(OurRobot.V0==OurRobot.V1){/*IntAndFloat();*/}}
while(OurRobot.V2==OurRobot.V3 || OurRobot.V0==OurRobot.V4 && OurRobot.V0>OurRobot.V3){if(OurRobot.V3>=OurRobot.V0 || OurRobot.V1<=OurRobot.V3){/*Example();*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
		}

		public override void DoStateAction()
		{
			
/*CircularTargetFire();*/
while(OurRobot.V1<=OurRobot.V4 || OurRobot.V4<OurRobot.V2 || OurRobot.V0<=OurRobot.V3 || OurRobot.V3==OurRobot.V2){if(OurRobot.V4==OurRobot.V2 || OurRobot.V3==OurRobot.V1 && OurRobot.V4==OurRobot.V2 || OurRobot.V3>=OurRobot.V2){/*CircularTargetFire();*/}}
while(OurRobot.V4<=OurRobot.V2 || OurRobot.V3>OurRobot.V1){while(OurRobot.V2<=OurRobot.V4){/*IntAndFloat();*/}}
/*Example();*/
if(OurRobot.V1>OurRobot.V3){if(OurRobot.V4<OurRobot.V1){if(OurRobot.V4==OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}}
		}

		public override void ExitState()
		{
			
/*CircularTargetFire();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V0==OurRobot.V1){/*IntAndFloat();*/}
if(OurRobot.V4>=OurRobot.V1 && OurRobot.V4>=OurRobot.V1 || OurRobot.V2<=OurRobot.V0){if(OurRobot.V0<OurRobot.V3){/*IntAndFloat();*/}}
/*CircularTargetFire();*/
if(OurRobot.V0>=OurRobot.V1){/*IntAndFloat();*/}
if(OurRobot.V4<OurRobot.V0){/*IntAndFloat();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
if(OurRobot.V3<=OurRobot.V4 && OurRobot.V1>OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
		}
	}
}