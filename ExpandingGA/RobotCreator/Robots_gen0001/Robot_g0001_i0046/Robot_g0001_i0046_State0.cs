using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0046 OurRobot { get; set; }
		public State0 (Robot_g0001_i0046 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V0<=OurRobot.V2)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(19, 204, 226);
			
/*IntAndFloat(-32,-1.0f);*/
/*IntAndFloat();*/
while(OurRobot.V3<OurRobot.V4){while(OurRobot.V6<=OurRobot.V7){/*Example();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
while(OurRobot.V5>=OurRobot.V4){/*Example();*/}
while(OurRobot.V4>OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*Example();*/
		}

		public override void DoStateAction()
		{
			
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V0==OurRobot.V1 && OurRobot.V7<=OurRobot.V6){if(OurRobot.V4!=OurRobot.V6){/*CircularTargetFire();*/}}
/*Example();*/
if(OurRobot.V0!=OurRobot.V7 || OurRobot.V3!=OurRobot.V6 && OurRobot.V5!=OurRobot.V1){/*IntAndFloat();*/}
if(OurRobot.V4<=OurRobot.V7 || OurRobot.V7!=OurRobot.V4 && OurRobot.V1>=OurRobot.V4 || OurRobot.V1==OurRobot.V6){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*Example();*/
if(OurRobot.V4==OurRobot.V1 || OurRobot.V0!=OurRobot.V4){while(OurRobot.V7<=OurRobot.V3){/*IntAndFloat();*/}}
while(OurRobot.V4>OurRobot.V2 && OurRobot.V0<OurRobot.V5){while(OurRobot.V4<OurRobot.V0 || OurRobot.V5>OurRobot.V0 && OurRobot.V5<=OurRobot.V4 || OurRobot.V5>OurRobot.V7){if(OurRobot.V2!=OurRobot.V5 || OurRobot.V2<OurRobot.V4 || OurRobot.V6<=OurRobot.V0){/*IntAndFloat();*/}}}
/*CircularTargetFire();*/
while(OurRobot.V6!=OurRobot.V0){while(OurRobot.V7>OurRobot.V3){/*IntAndFloat();*/}}
/*Example();*/
/*CircularTargetFire();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
/*CircularTargetFire();*/
while(OurRobot.V0>OurRobot.V7){while(OurRobot.V7>OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
		}

		public override void ExitState()
		{
			
while(OurRobot.V7>=OurRobot.V5 || OurRobot.V2<=OurRobot.V7 || OurRobot.V5==OurRobot.V3){/*IntAndFloat();*/}
/*CircularTargetFire();*/
/*Example();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
		}
	}
}