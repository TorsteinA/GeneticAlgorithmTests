using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0040 OurRobot { get; set; }
		public State1 (Robot_g0000_i0040 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V1!=OurRobot.V4)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(186, 98, 150);
			
/*IntAndFloat();*/
if(OurRobot.V0>=OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
if(OurRobot.V6!=OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*Example();*/
while(OurRobot.V2>=OurRobot.V0 && OurRobot.V2<=OurRobot.V4 || OurRobot.V4==OurRobot.V1){/*IntAndFloat();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
if(OurRobot.V1!=OurRobot.V3 && OurRobot.V6!=OurRobot.V4){if(OurRobot.V6<=OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*IntAndFloat();*/
if(OurRobot.V2>=OurRobot.V6){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
		}

		public override void DoStateAction()
		{
			
/*IntAndFloat();*/
/*CircularTargetFire();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*Example();*/
while(OurRobot.V2<OurRobot.V1 && OurRobot.V6>=OurRobot.V2 || OurRobot.V4!=OurRobot.V2 || OurRobot.V4>=OurRobot.V2){if(OurRobot.V3<=OurRobot.V1){/*IntAndFloat();*/}}
if(OurRobot.V6<OurRobot.V2 && OurRobot.V3<=OurRobot.V0){/*IntAndFloat();*/}
if(OurRobot.V5!=OurRobot.V1 || OurRobot.V0<=OurRobot.V2){while(OurRobot.V4<OurRobot.V0){/*CircularTargetFire();*/}}
while(OurRobot.V0>OurRobot.V3 || OurRobot.V3==OurRobot.V6 || OurRobot.V5>=OurRobot.V1){while(OurRobot.V1>OurRobot.V6){if(OurRobot.V6>OurRobot.V2 || OurRobot.V1<OurRobot.V0 && OurRobot.V1<=OurRobot.V3){/*IntAndFloat();*/}}}
/*Example();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V0==OurRobot.V3){/*Example();*/}
		}

		public override void ExitState()
		{
			
/*CircularTargetFire();*/
if(OurRobot.V6<=OurRobot.V5 && OurRobot.V0!=OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
while(OurRobot.V5<OurRobot.V1){/*Example();*/}
if(OurRobot.V5<=OurRobot.V1 || OurRobot.V4<=OurRobot.V6 && OurRobot.V1==OurRobot.V3){/*IntAndFloat();*/}
if(OurRobot.V6>OurRobot.V0 || OurRobot.V1==OurRobot.V6){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
		}
	}
}