using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0007 OurRobot { get; set; }
		public State0 (Robot_g0000_i0007 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V5<=OurRobot.V6)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(181, 93, 0);
			
/*IntAndFloat(2,-1.0f);*/
/*Example();*/
if(OurRobot.V1==OurRobot.V6){if(OurRobot.V2!=OurRobot.V0 || OurRobot.V6>=OurRobot.V3){/*IntAndFloat();*/}}
/*Example();*/
if(OurRobot.V5!=OurRobot.V7){if(OurRobot.V6>OurRobot.V2 && OurRobot.V6<OurRobot.V2){/*Example();*/}}
while(OurRobot.V4>=OurRobot.V2 && OurRobot.V2>OurRobot.V7 && OurRobot.V2>=OurRobot.V1){/*Example();*/}
/*Example();*/
/*CircularTargetFire();*/
if(OurRobot.V0>=OurRobot.V2){/*IntAndFloat();*/}
if(OurRobot.V6<OurRobot.V2){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*CircularTargetFire();*/
while(OurRobot.V5>OurRobot.V2 || OurRobot.V1<=OurRobot.V5 && OurRobot.V1<=OurRobot.V6){while(OurRobot.V7<OurRobot.V2 || OurRobot.V0>OurRobot.V1 && OurRobot.V2>=OurRobot.V0){/*IntAndFloat();*/}}
/*Example();*/
if(OurRobot.V4>=OurRobot.V0 && OurRobot.V0>=OurRobot.V6 || OurRobot.V0>OurRobot.V6 || OurRobot.V2>=OurRobot.V6){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V1==OurRobot.V0 || OurRobot.V7<OurRobot.V0 && OurRobot.V6<OurRobot.V7 || OurRobot.V5<OurRobot.V6){if(OurRobot.V4<OurRobot.V6 && OurRobot.V1<OurRobot.V6){if(OurRobot.V0!=OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}}
if(OurRobot.V0==OurRobot.V7 || OurRobot.V2<=OurRobot.V7 && OurRobot.V1>OurRobot.V5 || OurRobot.V6==OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
if(OurRobot.V6>OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
		}

		public override void ExitState()
		{
			
if(OurRobot.V1>=OurRobot.V6 && OurRobot.V4!=OurRobot.V1 || OurRobot.V1<OurRobot.V2){/*IntAndFloat();*/}
/*IntAndFloat();*/
if(OurRobot.V3!=OurRobot.V5 || OurRobot.V0!=OurRobot.V7 && OurRobot.V7<=OurRobot.V3 || OurRobot.V5!=OurRobot.V4){/*IntAndFloat();*/}
while(OurRobot.V3>OurRobot.V5 || OurRobot.V3!=OurRobot.V7){while(OurRobot.V5<=OurRobot.V0){if(OurRobot.V3!=OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V7>=OurRobot.V4){/*IntAndFloat();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*Example();*/
while(OurRobot.V4!=OurRobot.V5){if(OurRobot.V5>OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
		}
	}
}