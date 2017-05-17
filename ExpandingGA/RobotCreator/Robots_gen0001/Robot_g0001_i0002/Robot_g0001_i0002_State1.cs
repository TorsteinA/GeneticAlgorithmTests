using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0002 OurRobot { get; set; }
		public State1 (Robot_g0001_i0002 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V2<=OurRobot.V5)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(187, 63, 252);
			
/*IntAndFloat();*/
while(OurRobot.V3<OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
while(OurRobot.V4<=OurRobot.V2 || OurRobot.V6!=OurRobot.V0){if(OurRobot.V5<OurRobot.V1 && OurRobot.V3>=OurRobot.V4 || OurRobot.V5!=OurRobot.V4){/*IntAndFloat();*/}}
/*Example();*/
/*IntAndFloat();*/
while(OurRobot.V5>=OurRobot.V3 || OurRobot.V5>OurRobot.V4){if(OurRobot.V5<OurRobot.V6){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
if(OurRobot.V4!=OurRobot.V6){if(OurRobot.V4==OurRobot.V3 || OurRobot.V1!=OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*IntAndFloat();*/
if(OurRobot.V3<=OurRobot.V5){if(OurRobot.V0>OurRobot.V6){if(OurRobot.V5>=OurRobot.V2 || OurRobot.V2<=OurRobot.V3 || OurRobot.V2>=OurRobot.V5){/*IntAndFloat();*/}}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V1>OurRobot.V0 && OurRobot.V5>=OurRobot.V2 || OurRobot.V1==OurRobot.V4){/*CircularTargetFire();*/}
/*IntAndFloat();*/
if(OurRobot.V4==OurRobot.V6){/*IntAndFloat();*/}
/*CircularTargetFire();*/
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
if(OurRobot.V3>=OurRobot.V1){/*IntAndFloat();*/}
/*IntAndFloat();*/
		}
	}
}