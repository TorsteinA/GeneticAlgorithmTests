using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0020 OurRobot { get; set; }
		public State0 (Robot_g0000_i0020 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V2>OurRobot.V1 && OurRobot.V2>OurRobot.V3)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(197, 218, 128);
			
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V1<=OurRobot.V4 || OurRobot.V4>=OurRobot.V1 && OurRobot.V1<OurRobot.V4 || OurRobot.V1==OurRobot.V2){/*IntAndFloat();*/}
/*IntAndFloat();*/
while(OurRobot.V1<=OurRobot.V4){while(OurRobot.V1!=OurRobot.V2){/*IntAndFloat();*/}}
while(OurRobot.V2!=OurRobot.V1){while(OurRobot.V3>=OurRobot.V4 || OurRobot.V1!=OurRobot.V2){/*IntAndFloat();*/}}
		}

		public override void ExitState()
		{
			
while(OurRobot.V3==OurRobot.V2){if(OurRobot.V4!=OurRobot.V3 || OurRobot.V3<=OurRobot.V0 || OurRobot.V0>=OurRobot.V2 && OurRobot.V2>OurRobot.V0){/*CircularTargetFire();*/}}
while(OurRobot.V1==OurRobot.V0 && OurRobot.V4<=OurRobot.V0 && OurRobot.V1>=OurRobot.V2){/*IntAndFloat();*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
		}
	}
}