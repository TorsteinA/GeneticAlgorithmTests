using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0046 OurRobot { get; set; }
		public State1 (Robot_g0000_i0046 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V0==OurRobot.V7 && OurRobot.V3<=OurRobot.V0)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(238, 211, 44);
			
/*IntAndFloat();*/
while(OurRobot.V4>=OurRobot.V5 || OurRobot.V6>=OurRobot.V1 && OurRobot.V3==OurRobot.V7 && OurRobot.V7<OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
while(OurRobot.V2>=OurRobot.V1){while(OurRobot.V5>OurRobot.V0 && OurRobot.V1>OurRobot.V3 && OurRobot.V5<OurRobot.V7 || OurRobot.V5>=OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
while(OurRobot.V7>OurRobot.V3 && OurRobot.V7<OurRobot.V4){while(OurRobot.V7==OurRobot.V4){/*CircularTargetFire();*/}}
/*IntAndFloat();*/
while(OurRobot.V6<=OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
if(OurRobot.V2!=OurRobot.V5){/*IntAndFloat();*/}
		}

		public override void DoStateAction()
		{
			
/*CircularTargetFire();*/
/*CircularTargetFire();*/
if(OurRobot.V7==OurRobot.V0){if(OurRobot.V5>OurRobot.V0 && OurRobot.V5<=OurRobot.V4 || OurRobot.V5>OurRobot.V7 && OurRobot.V0<=OurRobot.V6){/*IntAndFloat();*/}}
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
if(OurRobot.V3!=OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*CircularTargetFire();*/
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V2<OurRobot.V6 && OurRobot.V6<=OurRobot.V4 || OurRobot.V2>OurRobot.V7 && OurRobot.V4!=OurRobot.V7){if(OurRobot.V5>=OurRobot.V4){if(OurRobot.V1>=OurRobot.V7){/*IntAndFloat();*/}}}
if(OurRobot.V3==OurRobot.V5){/*IntAndFloat();*/}
/*IntAndFloat();*/
if(OurRobot.V3<OurRobot.V0 && OurRobot.V5!=OurRobot.V1 && OurRobot.V3>OurRobot.V0 || OurRobot.V0<=OurRobot.V6){if(OurRobot.V4<=OurRobot.V2 || OurRobot.V5!=OurRobot.V4 && OurRobot.V7<=OurRobot.V4 || OurRobot.V7>OurRobot.V2){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
while(OurRobot.V4<=OurRobot.V2 && OurRobot.V7<OurRobot.V6){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*IntAndFloat();*/
if(OurRobot.V6>OurRobot.V0){if(OurRobot.V3!=OurRobot.V7 && OurRobot.V0>OurRobot.V1){/*IntAndFloat();*/}}
/*CircularTargetFire();*/
		}
	}
}