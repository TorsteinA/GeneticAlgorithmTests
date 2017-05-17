using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0035 OurRobot { get; set; }
		public State1 (Robot_g0000_i0035 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V4!=OurRobot.V3 && OurRobot.V4>=OurRobot.V2 || OurRobot.V3==OurRobot.V0)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(169, 75, 21);
			
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V0>OurRobot.V1 && OurRobot.V1==OurRobot.V7){while(OurRobot.V7>=OurRobot.V0 || OurRobot.V2!=OurRobot.V3 || OurRobot.V3<OurRobot.V7 && OurRobot.V1>OurRobot.V6){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
if(OurRobot.V3>=OurRobot.V5){/*IntAndFloat();*/}
if(OurRobot.V6<OurRobot.V5 || OurRobot.V5>=OurRobot.V7 || OurRobot.V4==OurRobot.V0){while(OurRobot.V2>=OurRobot.V6){/*IntAndFloat();*/}}
/*CircularTargetFire();*/
/*IntAndFloat();*/
if(OurRobot.V4>OurRobot.V2){while(OurRobot.V4<OurRobot.V3 || OurRobot.V0>OurRobot.V3 || OurRobot.V7>=OurRobot.V3 || OurRobot.V0<OurRobot.V1){if(OurRobot.V1>=OurRobot.V2 && OurRobot.V7!=OurRobot.V6 || OurRobot.V1<=OurRobot.V7){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}}
while(OurRobot.V6<OurRobot.V1){if(OurRobot.V6<OurRobot.V5){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
while(OurRobot.V4==OurRobot.V7 && OurRobot.V5==OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*Example();*/
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
		}
	}
}