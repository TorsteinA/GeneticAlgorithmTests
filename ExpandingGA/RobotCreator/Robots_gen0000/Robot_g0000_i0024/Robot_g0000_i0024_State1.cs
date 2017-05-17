using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0024 OurRobot { get; set; }
		public State1 (Robot_g0000_i0024 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V2<OurRobot.V4)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(86, 227, 131);
			
if(OurRobot.V6<OurRobot.V2){/*IntAndFloat();*/}
while(OurRobot.V2>OurRobot.V3 || OurRobot.V1<OurRobot.V0){/*Example();*/}
while(OurRobot.V0>OurRobot.V1 && OurRobot.V4!=OurRobot.V0 && OurRobot.V5<=OurRobot.V2 && OurRobot.V1<OurRobot.V4){if(OurRobot.V1!=OurRobot.V6 || OurRobot.V4>=OurRobot.V5){/*IntAndFloat();*/}}
while(OurRobot.V2!=OurRobot.V1){if(OurRobot.V5>OurRobot.V4 && OurRobot.V1<OurRobot.V6 || OurRobot.V3==OurRobot.V4){/*Example();*/}}
/*IntAndFloat();*/
/*CircularTargetFire();*/
/*CircularTargetFire();*/
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V2!=OurRobot.V6){while(OurRobot.V5>=OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*Example();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
while(OurRobot.V5>=OurRobot.V3 || OurRobot.V3<=OurRobot.V2){while(OurRobot.V2==OurRobot.V6){/*IntAndFloat();*/}}
/*IntAndFloat();*/
while(OurRobot.V5!=OurRobot.V6 && OurRobot.V4<OurRobot.V0){if(OurRobot.V0<OurRobot.V6 || OurRobot.V4==OurRobot.V5 || OurRobot.V6<=OurRobot.V5){/*IntAndFloat();*/}}
while(OurRobot.V1>=OurRobot.V5){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*CircularTargetFire();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
		}

		public override void ExitState()
		{
			
while(OurRobot.V3==OurRobot.V4 || OurRobot.V1!=OurRobot.V6 || OurRobot.V3<OurRobot.V5){/*IntAndFloat();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
if(OurRobot.V3!=OurRobot.V1 || OurRobot.V0<=OurRobot.V3){/*CircularTargetFire();*/}
while(OurRobot.V0<OurRobot.V3 || OurRobot.V3<=OurRobot.V4){/*IntAndFloat();*/}
/*CircularTargetFire();*/
while(OurRobot.V1==OurRobot.V6){/*Example();*/}
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V6!=OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
if(OurRobot.V4>=OurRobot.V0 || OurRobot.V2>OurRobot.V3){while(OurRobot.V5==OurRobot.V4){/*IntAndFloat();*/}}
		}
	}
}