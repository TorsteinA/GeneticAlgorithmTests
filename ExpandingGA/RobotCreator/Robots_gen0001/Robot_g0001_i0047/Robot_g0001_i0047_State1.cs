using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0047 OurRobot { get; set; }
		public State1 (Robot_g0001_i0047 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V1>=OurRobot.V0)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(23, 228, 23);
			
while(OurRobot.V0<OurRobot.V1 || OurRobot.V1!=OurRobot.V0){while(OurRobot.V0!=OurRobot.V2){/*IntAndFloat();*/}}
while(OurRobot.V0>OurRobot.V3){while(OurRobot.V1==OurRobot.V0 || OurRobot.V1<OurRobot.V3 && OurRobot.V5<OurRobot.V4){/*CircularTargetFire();*/}}
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
		}

		public override void DoStateAction()
		{
			
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*Example();*/
/*IntAndFloat();*/
if(OurRobot.V1!=OurRobot.V2){if(OurRobot.V1>OurRobot.V5){/*IntAndFloat();*/}}
/*IntAndFloat();*/
while(OurRobot.V1==OurRobot.V2 || OurRobot.V1==OurRobot.V4){/*IntAndFloat();*/}
/*CircularTargetFire();*/
while(OurRobot.V1==OurRobot.V3){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V0<=OurRobot.V5){/*IntAndFloat();*/}
if(OurRobot.V2>=OurRobot.V0){if(OurRobot.V2<=OurRobot.V1 && OurRobot.V1<OurRobot.V3){/*IntAndFloat();*/}}
while(OurRobot.V5>OurRobot.V4 || OurRobot.V5>OurRobot.V4 || OurRobot.V0>OurRobot.V4){/*IntAndFloat();*/}
while(OurRobot.V4>=OurRobot.V5){/*Example();*/}
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
		}
	}
}