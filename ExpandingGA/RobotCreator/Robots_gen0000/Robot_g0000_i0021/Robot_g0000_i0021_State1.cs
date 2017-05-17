using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0021 OurRobot { get; set; }
		public State1 (Robot_g0000_i0021 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V5!=OurRobot.V3 || OurRobot.V3>OurRobot.V5 && OurRobot.V6>OurRobot.V1 || OurRobot.V0>=OurRobot.V1)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(81, 254, 70);
			
if(OurRobot.V5>OurRobot.V3 || OurRobot.V0>=OurRobot.V1 || OurRobot.V4!=OurRobot.V2){/*IntAndFloat();*/}
/*IntAndFloat();*/
while(OurRobot.V6<OurRobot.V5 || OurRobot.V6!=OurRobot.V2){if(OurRobot.V6>OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*IntAndFloat();*/
/*Example();*/
/*Example();*/
if(OurRobot.V5==OurRobot.V6 && OurRobot.V6==OurRobot.V3 && OurRobot.V2==OurRobot.V5){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*CircularTargetFire();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V4>=OurRobot.V5){if(OurRobot.V1==OurRobot.V3){/*IntAndFloat();*/}}
while(OurRobot.V1>=OurRobot.V4){if(OurRobot.V1!=OurRobot.V2 && OurRobot.V6>OurRobot.V4 || OurRobot.V4!=OurRobot.V3 || OurRobot.V6>OurRobot.V2){/*IntAndFloat();*/}}
while(OurRobot.V2==OurRobot.V1){/*Example();*/}
		}

		public override void DoStateAction()
		{
			
/*CircularTargetFire();*/
/*IntAndFloat();*/
/*CircularTargetFire();*/
while(OurRobot.V3!=OurRobot.V1 || OurRobot.V2>OurRobot.V6){/*IntAndFloat();*/}
while(OurRobot.V6!=OurRobot.V1 && OurRobot.V6>=OurRobot.V3){/*IntAndFloat();*/}
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
if(OurRobot.V0!=OurRobot.V2){while(OurRobot.V2!=OurRobot.V1 || OurRobot.V6>=OurRobot.V5){if(OurRobot.V3==OurRobot.V1){/*Example();*/}}}
		}
	}
}