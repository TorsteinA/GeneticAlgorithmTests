using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0000 OurRobot { get; set; }
		public State1 (Robot_g0001_i0000 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V1<=OurRobot.V4 && OurRobot.V4>OurRobot.V1 || OurRobot.V5!=OurRobot.V3 && OurRobot.V5<=OurRobot.V1)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(172, 166, 23);
			
/*Example();*/
if(OurRobot.V5>OurRobot.V1 || OurRobot.V2>=OurRobot.V4 || OurRobot.V1<OurRobot.V2 || OurRobot.V1<OurRobot.V0){while(OurRobot.V0>=OurRobot.V4 && OurRobot.V0<OurRobot.V4 && OurRobot.V0==OurRobot.V3){/*IntAndFloat();*/}}
		}

		public override void DoStateAction()
		{
			
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V0>OurRobot.V2 || OurRobot.V2<OurRobot.V0){/*Example();*/}
/*CircularTargetFire();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
		}
	}
}