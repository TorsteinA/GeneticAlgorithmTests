using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0012 OurRobot { get; set; }
		public State0 (Robot_g0000_i0012 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V4<=OurRobot.V1)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(238, 148, 209);
			
		}

		public override void DoStateAction()
		{
			
/*CircularTargetFire();*/
while(OurRobot.V4<OurRobot.V3 || OurRobot.V2!=OurRobot.V4 && OurRobot.V4<OurRobot.V5){while(OurRobot.V2==OurRobot.V0){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
while(OurRobot.V5>OurRobot.V2){if(OurRobot.V6>OurRobot.V0){if(OurRobot.V6>=OurRobot.V4 || OurRobot.V4!=OurRobot.V5){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}}
if(OurRobot.V2!=OurRobot.V5){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*Example();*/
if(OurRobot.V3!=OurRobot.V5 && OurRobot.V0!=OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
		}
	}
}