using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0049 OurRobot { get; set; }
		public State0 (Robot_g0001_i0049 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V0>OurRobot.V6 || OurRobot.V5<=OurRobot.V0)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(39, 30, 161);
			
if(OurRobot.V6<=OurRobot.V5){/*IntAndFloat(24,-1.0f);*/}
if(OurRobot.V6!=OurRobot.V3 && OurRobot.V5<=OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*IntAndFloat();*/
while(OurRobot.V2!=OurRobot.V1 || OurRobot.V1==OurRobot.V0 || OurRobot.V0!=OurRobot.V3 && OurRobot.V2<=OurRobot.V6){while(OurRobot.V3<OurRobot.V4){/*CircularTargetFire();*/}}
if(OurRobot.V5<=OurRobot.V6 || OurRobot.V3!=OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
while(OurRobot.V2<OurRobot.V4){while(OurRobot.V4==OurRobot.V5 || OurRobot.V5<=OurRobot.V6 || OurRobot.V1==OurRobot.V6 && OurRobot.V5<=OurRobot.V2){if(OurRobot.V3!=OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}}
		}

		public override void DoStateAction()
		{
			
/*Example();*/
/*Example();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V5==OurRobot.V1 || OurRobot.V6<=OurRobot.V1 || OurRobot.V3>=OurRobot.V6){/*IntAndFloat();*/}
while(OurRobot.V2==OurRobot.V6 && OurRobot.V4<=OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
while(OurRobot.V3<OurRobot.V1 && OurRobot.V6>=OurRobot.V3){if(OurRobot.V1>=OurRobot.V0 && OurRobot.V4<=OurRobot.V6 && OurRobot.V6!=OurRobot.V1 && OurRobot.V5<=OurRobot.V4){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V1<=OurRobot.V3 && OurRobot.V4==OurRobot.V0 && OurRobot.V4<OurRobot.V6){while(OurRobot.V0>OurRobot.V4){/*IntAndFloat();*/}}
while(OurRobot.V1<=OurRobot.V0){/*IntAndFloat();*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V5>=OurRobot.V3 || OurRobot.V5>OurRobot.V6){if(OurRobot.V3<OurRobot.V5){if(OurRobot.V1<OurRobot.V4){/*IntAndFloat();*/}}}
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
if(OurRobot.V6<=OurRobot.V5 && OurRobot.V2<=OurRobot.V5 || OurRobot.V5>OurRobot.V6 || OurRobot.V1!=OurRobot.V2){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*Example();*/
/*CircularTargetFire();*/
while(OurRobot.V5==OurRobot.V3 && OurRobot.V5==OurRobot.V0){/*IntAndFloat();*/}
while(OurRobot.V5>OurRobot.V1 && OurRobot.V4>=OurRobot.V0){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
		}
	}
}