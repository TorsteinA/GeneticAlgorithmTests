using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0030 OurRobot { get; set; }
		public State1 (Robot_g0000_i0030 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V4<OurRobot.V3 || OurRobot.V1<OurRobot.V2)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(16, 150, 169);
			
if(OurRobot.V2>=OurRobot.V3 || OurRobot.V4<OurRobot.V0 && OurRobot.V1>=OurRobot.V4){if(OurRobot.V1>OurRobot.V0 && OurRobot.V0!=OurRobot.V1 || OurRobot.V1>OurRobot.V0){/*CircularTargetFire();*/}}
		}

		public override void DoStateAction()
		{
			
/*IntAndFloat();*/
if(OurRobot.V3<OurRobot.V0 && OurRobot.V2>OurRobot.V4 && OurRobot.V2!=OurRobot.V0){/*IntAndFloat();*/}
		}

		public override void ExitState()
		{
			
if(OurRobot.V0>=OurRobot.V2 && OurRobot.V0==OurRobot.V1 && OurRobot.V0<OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
		}
	}
}