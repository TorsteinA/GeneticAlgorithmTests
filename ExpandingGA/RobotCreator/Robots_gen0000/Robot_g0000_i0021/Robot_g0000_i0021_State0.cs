using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0021 OurRobot { get; set; }
		public State0 (Robot_g0000_i0021 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V4>=OurRobot.V5)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(46, 156, 148);
			
if(OurRobot.V2>=OurRobot.V4 || OurRobot.V6<OurRobot.V4){if(OurRobot.V3==OurRobot.V6){if(OurRobot.V6>OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}}
/*IntAndFloat(-11,-1.0f);*/
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V5>=OurRobot.V3 && OurRobot.V0<OurRobot.V4){/*IntAndFloat();*/}
if(OurRobot.V5==OurRobot.V0 || OurRobot.V0<OurRobot.V1 || OurRobot.V1<=OurRobot.V4 && OurRobot.V0>OurRobot.V3){/*IntAndFloat();*/}
while(OurRobot.V6>OurRobot.V2){/*IntAndFloat();*/}
while(OurRobot.V6<OurRobot.V4 && OurRobot.V1>OurRobot.V6){while(OurRobot.V5!=OurRobot.V0){if(OurRobot.V2<=OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}}
/*CircularTargetFire();*/
/*Example();*/
/*IntAndFloat();*/
if(OurRobot.V0==OurRobot.V1 && OurRobot.V3<OurRobot.V6 || OurRobot.V0>OurRobot.V1){/*IntAndFloat();*/}
/*IntAndFloat();*/
while(OurRobot.V4!=OurRobot.V6 || OurRobot.V0>OurRobot.V1 || OurRobot.V5<OurRobot.V1 && OurRobot.V2!=OurRobot.V6){/*IntAndFloat();*/}
while(OurRobot.V6<OurRobot.V5 || OurRobot.V6>=OurRobot.V2 || OurRobot.V6!=OurRobot.V1 && OurRobot.V6>=OurRobot.V3){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
/*CircularTargetFire();*/
		}
	}
}