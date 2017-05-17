using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0023 OurRobot { get; set; }
		public State1 (Robot_g0000_i0023 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V4==OurRobot.V0 && OurRobot.V4>=OurRobot.V0 || OurRobot.V7==OurRobot.V2 || OurRobot.V7>=OurRobot.V6)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(162, 107, 218);
			
/*Example();*/
while(OurRobot.V3<=OurRobot.V2){while(OurRobot.V5<OurRobot.V7 || OurRobot.V0>=OurRobot.V1){/*IntAndFloat();*/}}
if(OurRobot.V6<=OurRobot.V7){if(OurRobot.V5>OurRobot.V3 && OurRobot.V4>OurRobot.V0){/*Example();*/}}
while(OurRobot.V4<OurRobot.V5 && OurRobot.V5==OurRobot.V3 && OurRobot.V5!=OurRobot.V6){if(OurRobot.V3<OurRobot.V4){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V2>=OurRobot.V5){/*Example();*/}
while(OurRobot.V6<OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V0<=OurRobot.V2 || OurRobot.V0<=OurRobot.V4){/*IntAndFloat();*/}
		}

		public override void DoStateAction()
		{
			
/*IntAndFloat();*/
while(OurRobot.V4>=OurRobot.V5){while(OurRobot.V1>=OurRobot.V7 || OurRobot.V6!=OurRobot.V4 || OurRobot.V5>OurRobot.V0 || OurRobot.V2==OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
if(OurRobot.V5<=OurRobot.V3){/*CircularTargetFire();*/}
if(OurRobot.V3<=OurRobot.V7){/*IntAndFloat();*/}
while(OurRobot.V2==OurRobot.V3 || OurRobot.V7>=OurRobot.V1){/*IntAndFloat();*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V4<=OurRobot.V6 && OurRobot.V0>=OurRobot.V6 && OurRobot.V1==OurRobot.V6 && OurRobot.V5>=OurRobot.V3){/*Example();*/}
/*CircularTargetFire();*/
if(OurRobot.V4<=OurRobot.V1){/*Example();*/}
if(OurRobot.V0<OurRobot.V4){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V4!=OurRobot.V1){while(OurRobot.V6==OurRobot.V2 || OurRobot.V4!=OurRobot.V2 || OurRobot.V2<=OurRobot.V6 && OurRobot.V4==OurRobot.V2){/*Example();*/}}
/*IntAndFloat();*/
		}
	}
}