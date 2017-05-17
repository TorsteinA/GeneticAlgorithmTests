using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0003 OurRobot { get; set; }
		public State1 (Robot_g0001_i0003 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V4>OurRobot.V6 && OurRobot.V0>OurRobot.V1)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(64, 154, 127);
			
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V1<OurRobot.V4 && OurRobot.V1>=OurRobot.V2 && OurRobot.V1<OurRobot.V2 || OurRobot.V3>OurRobot.V0){if(OurRobot.V0!=OurRobot.V3 && OurRobot.V1==OurRobot.V6 && OurRobot.V1==OurRobot.V4 && OurRobot.V0<=OurRobot.V4){/*Example();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V6>=OurRobot.V5){while(OurRobot.V1>=OurRobot.V4){/*CircularTargetFire();*/}}
/*CircularTargetFire();*/
		}

		public override void DoStateAction()
		{
			
/*IntAndFloat();*/
/*CircularTargetFire();*/
/*CircularTargetFire();*/
		}

		public override void ExitState()
		{
			
while(OurRobot.V1==OurRobot.V0){/*IntAndFloat();*/}
if(OurRobot.V3<=OurRobot.V6 || OurRobot.V0>OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
		}
	}
}