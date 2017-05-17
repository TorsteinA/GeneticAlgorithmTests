using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0008 OurRobot { get; set; }
		public State1 (Robot_g0000_i0008 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V4==OurRobot.V5)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(209, 129, 11);
			
if(OurRobot.V6==OurRobot.V2 && OurRobot.V5>OurRobot.V4){if(OurRobot.V0<=OurRobot.V1){if(OurRobot.V0>=OurRobot.V4 || OurRobot.V6!=OurRobot.V0 && OurRobot.V2<=OurRobot.V5 && OurRobot.V5>OurRobot.V3){/*IntAndFloat();*/}}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V5<OurRobot.V4){/*IntAndFloat();*/}
while(OurRobot.V6>=OurRobot.V3){if(OurRobot.V6<OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
while(OurRobot.V6==OurRobot.V1){/*IntAndFloat();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V3==OurRobot.V1 && OurRobot.V0<OurRobot.V1){while(OurRobot.V0<OurRobot.V3 && OurRobot.V2==OurRobot.V4 && OurRobot.V0!=OurRobot.V5){if(OurRobot.V1==OurRobot.V5){/*IntAndFloat();*/}}}
if(OurRobot.V6>OurRobot.V0 && OurRobot.V2>=OurRobot.V0 || OurRobot.V5!=OurRobot.V0){if(OurRobot.V2<OurRobot.V4 || OurRobot.V4==OurRobot.V3 || OurRobot.V3==OurRobot.V4 || OurRobot.V5<OurRobot.V4){/*Example();*/}}
		}

		public override void DoStateAction()
		{
			
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V2>=OurRobot.V4){/*Example();*/}
while(OurRobot.V3<=OurRobot.V2 && OurRobot.V3<=OurRobot.V0){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*CircularTargetFire();*/
if(OurRobot.V2<=OurRobot.V4 && OurRobot.V1!=OurRobot.V3){/*CircularTargetFire();*/}
if(OurRobot.V3<=OurRobot.V4){/*CircularTargetFire();*/}
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
/*CircularTargetFire();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
		}
	}
}