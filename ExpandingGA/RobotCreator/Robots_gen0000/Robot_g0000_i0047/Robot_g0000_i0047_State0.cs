using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0047 OurRobot { get; set; }
		public State0 (Robot_g0000_i0047 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V2==OurRobot.V0 && OurRobot.V2<OurRobot.V1 && OurRobot.V3>OurRobot.V1 || OurRobot.V2>=OurRobot.V1)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(175, 16, 64);
			
/*IntAndFloat(-1,-1.0f);*/
/*Example();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V3<OurRobot.V1){if(OurRobot.V0==OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V3>=OurRobot.V0){if(OurRobot.V4!=OurRobot.V5){/*IntAndFloat();*/}}
if(OurRobot.V0!=OurRobot.V1 && OurRobot.V2<=OurRobot.V1 && OurRobot.V0>OurRobot.V3){if(OurRobot.V4>OurRobot.V3 || OurRobot.V5==OurRobot.V4 && OurRobot.V3>OurRobot.V2){/*IntAndFloat();*/}}
while(OurRobot.V4<OurRobot.V5){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*IntAndFloat();*/
while(OurRobot.V1>OurRobot.V2 && OurRobot.V5>OurRobot.V3){while(OurRobot.V0<=OurRobot.V3 || OurRobot.V0>=OurRobot.V4){/*IntAndFloat();*/}}
/*Example();*/
if(OurRobot.V2>OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*Example();*/
/*IntAndFloat();*/
if(OurRobot.V1!=OurRobot.V2){if(OurRobot.V1>OurRobot.V5){/*IntAndFloat();*/}}
/*IntAndFloat();*/
while(OurRobot.V1==OurRobot.V2 || OurRobot.V1==OurRobot.V4){/*IntAndFloat();*/}
/*CircularTargetFire();*/
while(OurRobot.V1==OurRobot.V3){/*IntAndFloat();*/}
		}

		public override void ExitState()
		{
			
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
		}
	}
}