using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0022 OurRobot { get; set; }
		public State1 (Robot_g0000_i0022 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V4>OurRobot.V1 && OurRobot.V6==OurRobot.V1)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(76, 99, 100);
			
while(OurRobot.V6<=OurRobot.V1 || OurRobot.V5>=OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*IntAndFloat();*/
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V2>=OurRobot.V4){if(OurRobot.V3!=OurRobot.V4 && OurRobot.V5!=OurRobot.V0 || OurRobot.V2>=OurRobot.V0 || OurRobot.V6==OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
/*Example();*/
/*CircularTargetFire();*/
if(OurRobot.V0<=OurRobot.V5 && OurRobot.V0>OurRobot.V5){while(OurRobot.V2==OurRobot.V3){/*IntAndFloat();*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V1<OurRobot.V0){while(OurRobot.V0<OurRobot.V2){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V1<OurRobot.V5 && OurRobot.V0!=OurRobot.V6 || OurRobot.V0<=OurRobot.V1 && OurRobot.V0<=OurRobot.V4){/*Example();*/}
/*Example();*/
/*IntAndFloat();*/
/*CircularTargetFire();*/
while(OurRobot.V0<OurRobot.V3 && OurRobot.V3>=OurRobot.V1 && OurRobot.V2>OurRobot.V0 && OurRobot.V4<OurRobot.V2){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V2>OurRobot.V3){if(OurRobot.V1<OurRobot.V5 && OurRobot.V4==OurRobot.V6){/*IntAndFloat();*/}}
if(OurRobot.V1<=OurRobot.V5){/*IntAndFloat();*/}
/*CircularTargetFire();*/
		}
	}
}