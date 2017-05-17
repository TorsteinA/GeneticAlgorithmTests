using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0025 OurRobot { get; set; }
		public State0 (Robot_g0000_i0025 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V2<=OurRobot.V4)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(186, 85, 68);
			
while(OurRobot.V5>=OurRobot.V2 && OurRobot.V4<=OurRobot.V6){/*Example();*/}
/*IntAndFloat(-5,-1.0f);*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V7<=OurRobot.V1){/*IntAndFloat();*/}
/*CircularTargetFire();*/
while(OurRobot.V7!=OurRobot.V2){/*Example();*/}
if(OurRobot.V4<OurRobot.V7 || OurRobot.V5==OurRobot.V2 || OurRobot.V6!=OurRobot.V0){if(OurRobot.V7<OurRobot.V1){/*IntAndFloat();*/}}
while(OurRobot.V4>OurRobot.V2 || OurRobot.V6>OurRobot.V0 && OurRobot.V5<OurRobot.V1){while(OurRobot.V7>OurRobot.V4){/*IntAndFloat();*/}}
		}

		public override void DoStateAction()
		{
			
/*Example();*/
if(OurRobot.V7>OurRobot.V2){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
		}

		public override void ExitState()
		{
			
while(OurRobot.V1<=OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
while(OurRobot.V5>OurRobot.V2 && OurRobot.V2>=OurRobot.V3){if(OurRobot.V6==OurRobot.V4){/*IntAndFloat();*/}}
if(OurRobot.V2<OurRobot.V3){while(OurRobot.V5>OurRobot.V6){/*IntAndFloat();*/}}
while(OurRobot.V7>OurRobot.V2){while(OurRobot.V6!=OurRobot.V1){if(OurRobot.V1>OurRobot.V5){/*IntAndFloat();*/}}}
/*Example();*/
/*Example();*/
while(OurRobot.V0>=OurRobot.V1){/*IntAndFloat();*/}
		}
	}
}