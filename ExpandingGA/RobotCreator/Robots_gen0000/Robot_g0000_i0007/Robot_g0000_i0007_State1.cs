using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0007 OurRobot { get; set; }
		public State1 (Robot_g0000_i0007 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V1!=OurRobot.V0)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(47, 180, 141);
			
/*Example();*/
while(OurRobot.V1<=OurRobot.V5 && OurRobot.V1<=OurRobot.V6){while(OurRobot.V7<OurRobot.V2 || OurRobot.V0>OurRobot.V1 && OurRobot.V2>=OurRobot.V0){/*IntAndFloat();*/}}
/*Example();*/
if(OurRobot.V4>=OurRobot.V0 && OurRobot.V0>=OurRobot.V6 || OurRobot.V0>OurRobot.V6 || OurRobot.V2>=OurRobot.V6){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V1==OurRobot.V4){while(OurRobot.V3>OurRobot.V5 || OurRobot.V0>=OurRobot.V2 || OurRobot.V6<OurRobot.V2){/*CircularTargetFire();*/}}
if(OurRobot.V0>OurRobot.V1){while(OurRobot.V6!=OurRobot.V0){if(OurRobot.V4<OurRobot.V5){/*Example();*/}}}
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V1==OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*CircularTargetFire();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V6>OurRobot.V5){if(OurRobot.V3<=OurRobot.V0 && OurRobot.V0==OurRobot.V7 || OurRobot.V4<OurRobot.V3){if(OurRobot.V6<OurRobot.V4){/*CircularTargetFire();*/}}}
/*IntAndFloat();*/
if(OurRobot.V2<=OurRobot.V3){/*IntAndFloat();*/}
while(OurRobot.V0>OurRobot.V3 && OurRobot.V3!=OurRobot.V7){/*IntAndFloat();*/}
/*CircularTargetFire();*/
/*IntAndFloat();*/
if(OurRobot.V4<=OurRobot.V7 || OurRobot.V4==OurRobot.V2 && OurRobot.V1!=OurRobot.V6 && OurRobot.V6<OurRobot.V4){while(OurRobot.V4!=OurRobot.V0 || OurRobot.V5<=OurRobot.V0 && OurRobot.V6==OurRobot.V3){if(OurRobot.V3>OurRobot.V6 || OurRobot.V6!=OurRobot.V4){/*IntAndFloat();*/}}}
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V2>=OurRobot.V4 || OurRobot.V3<OurRobot.V7){/*IntAndFloat();*/}
while(OurRobot.V1==OurRobot.V4 && OurRobot.V6<=OurRobot.V5){if(OurRobot.V3<OurRobot.V2){if(OurRobot.V7<OurRobot.V0){/*CircularTargetFire();*/}}}
if(OurRobot.V1==OurRobot.V4 && OurRobot.V7<=OurRobot.V0){/*IntAndFloat();*/}
while(OurRobot.V7==OurRobot.V2 || OurRobot.V1<OurRobot.V3){/*IntAndFloat();*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V2!=OurRobot.V1){while(OurRobot.V2>OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
		}
	}
}