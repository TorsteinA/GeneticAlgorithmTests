using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0006 OurRobot { get; set; }
		public State0 (Robot_g0001_i0006 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V1<=OurRobot.V3 && OurRobot.V0!=OurRobot.V1 && OurRobot.V1>OurRobot.V2 || OurRobot.V1<=OurRobot.V4)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(106, 3, 106);
			
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*CircularTargetFire();*/
/*Example();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat(25,-1.0f);*/
/*IntAndFloat();*/
while(OurRobot.V2<OurRobot.V5 || OurRobot.V0!=OurRobot.V4 || OurRobot.V2>=OurRobot.V0 || OurRobot.V1>OurRobot.V5){/*CircularTargetFire();*/}
		}

		public override void DoStateAction()
		{
			
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
		}
	}
}