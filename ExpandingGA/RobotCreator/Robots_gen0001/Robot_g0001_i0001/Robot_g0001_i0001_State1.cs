using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0001 OurRobot { get; set; }
		public State1 (Robot_g0001_i0001 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V2>=OurRobot.V3)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(160, 13, 121);
			
if(OurRobot.V0<OurRobot.V1){/*CircularTargetFire();*/}
while(OurRobot.V2>OurRobot.V3 || OurRobot.V2<OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
while(OurRobot.V0>OurRobot.V3 || OurRobot.V2>OurRobot.V4 || OurRobot.V3!=OurRobot.V0 || OurRobot.V0<OurRobot.V1){/*CircularTargetFire();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
		}

		public override void DoStateAction()
		{
			
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V2>OurRobot.V3){/*IntAndFloat();*/}
/*IntAndFloat();*/
while(OurRobot.V4<=OurRobot.V3 || OurRobot.V0==OurRobot.V1){if(OurRobot.V4==OurRobot.V3){/*CircularTargetFire();*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V0>OurRobot.V3){/*IntAndFloat();*/}
/*Example();*/
while(OurRobot.V4>=OurRobot.V1 || OurRobot.V0!=OurRobot.V2 && OurRobot.V3==OurRobot.V2){/*IntAndFloat();*/}
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
if(OurRobot.V2==OurRobot.V4 || OurRobot.V0<=OurRobot.V1){if(OurRobot.V0==OurRobot.V1){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
while(OurRobot.V0!=OurRobot.V1 && OurRobot.V4!=OurRobot.V3 || OurRobot.V4<=OurRobot.V3 || OurRobot.V0==OurRobot.V2){if(OurRobot.V0>=OurRobot.V3 && OurRobot.V0<OurRobot.V3 || OurRobot.V4<OurRobot.V2 || OurRobot.V4==OurRobot.V2){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
while(OurRobot.V2!=OurRobot.V1){while(OurRobot.V4<=OurRobot.V3){/*IntAndFloat();*/}}
		}
	}
}