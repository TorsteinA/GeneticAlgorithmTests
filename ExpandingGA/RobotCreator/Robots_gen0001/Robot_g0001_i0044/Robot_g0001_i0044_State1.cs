using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0044 OurRobot { get; set; }
		public State1 (Robot_g0001_i0044 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V6<=OurRobot.V2)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(63, 199, 214);
			
while(OurRobot.V4==OurRobot.V6){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
while(OurRobot.V5<OurRobot.V0 || OurRobot.V5<=OurRobot.V6){if(OurRobot.V4!=OurRobot.V5 && OurRobot.V3>OurRobot.V6){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*CircularTargetFire();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V3>=OurRobot.V5 || OurRobot.V5>=OurRobot.V0 || OurRobot.V0>OurRobot.V6){while(OurRobot.V6!=OurRobot.V3 && OurRobot.V3==OurRobot.V5){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
if(OurRobot.V1>=OurRobot.V5 && OurRobot.V5!=OurRobot.V3 || OurRobot.V3!=OurRobot.V0){while(OurRobot.V5>=OurRobot.V4){/*Example();*/}}
while(OurRobot.V0>=OurRobot.V1){/*IntAndFloat();*/}
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V6>OurRobot.V1){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*CircularTargetFire();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V6==OurRobot.V1 && OurRobot.V1>OurRobot.V5){while(OurRobot.V6<=OurRobot.V0){/*IntAndFloat();*/}}
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
		}
	}
}