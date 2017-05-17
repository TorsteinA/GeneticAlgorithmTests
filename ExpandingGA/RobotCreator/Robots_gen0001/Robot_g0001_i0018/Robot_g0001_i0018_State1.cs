using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0018 OurRobot { get; set; }
		public State1 (Robot_g0001_i0018 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V0==OurRobot.V2)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(93, 183, 53);
			
if(OurRobot.V0<=OurRobot.V1){/*Example();*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V2>OurRobot.V6){/*CircularTargetFire();*/}
if(OurRobot.V1<OurRobot.V5){if(OurRobot.V2!=OurRobot.V3){/*IntAndFloat();*/}}
if(OurRobot.V0>OurRobot.V1){/*IntAndFloat();*/}
if(OurRobot.V3<=OurRobot.V6 || OurRobot.V4!=OurRobot.V5 || OurRobot.V2!=OurRobot.V7){/*IntAndFloat();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V5>OurRobot.V2){/*CircularTargetFire();*/}
		}

		public override void DoStateAction()
		{
			
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
while(OurRobot.V6<=OurRobot.V7 && OurRobot.V5>OurRobot.V4 && OurRobot.V3>OurRobot.V6){/*Example();*/}
		}

		public override void ExitState()
		{
			
while(OurRobot.V6>=OurRobot.V2){while(OurRobot.V6<OurRobot.V4){/*IntAndFloat();*/}}
if(OurRobot.V0!=OurRobot.V4 || OurRobot.V6<OurRobot.V1){if(OurRobot.V0==OurRobot.V5){/*IntAndFloat();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V1==OurRobot.V3 && OurRobot.V2>=OurRobot.V5 || OurRobot.V3==OurRobot.V6){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
while(OurRobot.V7>OurRobot.V5){/*Example();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V0>=OurRobot.V7){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*IntAndFloat();*/
while(OurRobot.V0<OurRobot.V7 && OurRobot.V4!=OurRobot.V1 || OurRobot.V1<OurRobot.V2 && OurRobot.V4>=OurRobot.V0){while(OurRobot.V2!=OurRobot.V5 && OurRobot.V2==OurRobot.V4 && OurRobot.V0==OurRobot.V1 || OurRobot.V1!=OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*Example();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
while(OurRobot.V3>=OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
		}
	}
}