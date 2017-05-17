using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0017 OurRobot { get; set; }
		public State0 (Robot_g0001_i0017 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V4<OurRobot.V6 || OurRobot.V0!=OurRobot.V6 && OurRobot.V0>=OurRobot.V3 || OurRobot.V4==OurRobot.V1)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(139, 204, 73);
			
if(OurRobot.V5>=OurRobot.V3){/*CircularTargetFire();*/}
while(OurRobot.V0!=OurRobot.V6 || OurRobot.V1>OurRobot.V5){while(OurRobot.V6==OurRobot.V5){/*Example();*/}}
/*IntAndFloat(31,-1.0f);*/
/*CircularTargetFire();*/
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V5<=OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
while(OurRobot.V1<=OurRobot.V3){if(OurRobot.V0<=OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*CircularTargetFire();*/
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
		}
	}
}