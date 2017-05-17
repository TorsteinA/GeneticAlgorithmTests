using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0004 OurRobot { get; set; }
		public State0 (Robot_g0001_i0004 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V6<=OurRobot.V1 || OurRobot.V3>OurRobot.V2 || OurRobot.V3<=OurRobot.V5 && OurRobot.V3<=OurRobot.V2)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(48, 70, 215);
			
if(OurRobot.V6==OurRobot.V3 && OurRobot.V4==OurRobot.V1){if(OurRobot.V7!=OurRobot.V0){if(OurRobot.V3<OurRobot.V6){/*IntAndFloat(-19,-1.0f);*/}}}
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V1>OurRobot.V2){/*CircularTargetFire();*/}
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V1!=OurRobot.V3 || OurRobot.V5<=OurRobot.V3 || OurRobot.V3==OurRobot.V0 || OurRobot.V4>=OurRobot.V0){while(OurRobot.V6<=OurRobot.V4 || OurRobot.V1==OurRobot.V7 || OurRobot.V6!=OurRobot.V3){/*CircularTargetFire();*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
		}

		public override void DoStateAction()
		{
			
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V6<OurRobot.V2){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
if(OurRobot.V3==OurRobot.V7){/*IntAndFloat();*/}
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
if(OurRobot.V3>=OurRobot.V6){/*IntAndFloat();*/}
		}
	}
}