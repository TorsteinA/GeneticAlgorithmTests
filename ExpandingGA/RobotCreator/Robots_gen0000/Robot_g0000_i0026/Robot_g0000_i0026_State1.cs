using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0026 OurRobot { get; set; }
		public State1 (Robot_g0000_i0026 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V3<=OurRobot.V2)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(241, 237, 70);
			
if(OurRobot.V5<=OurRobot.V1 || OurRobot.V0>OurRobot.V1){/*CircularTargetFire();*/}
if(OurRobot.V2<=OurRobot.V6){if(OurRobot.V6>=OurRobot.V2 || OurRobot.V4<OurRobot.V2){/*IntAndFloat();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*CircularTargetFire();*/
if(OurRobot.V2==OurRobot.V4 && OurRobot.V3>OurRobot.V6 && OurRobot.V0<OurRobot.V7 || OurRobot.V0==OurRobot.V5){/*CircularTargetFire();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*Example();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*Example();*/
if(OurRobot.V5>OurRobot.V1){while(OurRobot.V5<OurRobot.V3 && OurRobot.V1!=OurRobot.V3 && OurRobot.V4<=OurRobot.V6 || OurRobot.V3!=OurRobot.V2){/*CircularTargetFire();*/}}
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V3>OurRobot.V1 || OurRobot.V5>OurRobot.V4 || OurRobot.V5<=OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
while(OurRobot.V4>OurRobot.V6){/*IntAndFloat();*/}
while(OurRobot.V0>OurRobot.V3){/*IntAndFloat();*/}
if(OurRobot.V0<OurRobot.V2 && OurRobot.V0<=OurRobot.V1 || OurRobot.V5<=OurRobot.V1 || OurRobot.V0<=OurRobot.V7){while(OurRobot.V0==OurRobot.V3){if(OurRobot.V3<OurRobot.V0){/*IntAndFloat();*/}}}
/*IntAndFloat();*/
while(OurRobot.V2<OurRobot.V4){while(OurRobot.V0!=OurRobot.V5 || OurRobot.V6==OurRobot.V3){if(OurRobot.V5!=OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}}
while(OurRobot.V3>=OurRobot.V7 || OurRobot.V2>=OurRobot.V3){/*IntAndFloat();*/}
if(OurRobot.V0!=OurRobot.V1 || OurRobot.V2!=OurRobot.V6 && OurRobot.V1==OurRobot.V4){while(OurRobot.V5<=OurRobot.V0 || OurRobot.V1==OurRobot.V6){/*CircularTargetFire();*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
		}

		public override void ExitState()
		{
			
/*Example();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
while(OurRobot.V2!=OurRobot.V1 && OurRobot.V0!=OurRobot.V6){while(OurRobot.V0<OurRobot.V4){/*IntAndFloat();*/}}
while(OurRobot.V4>OurRobot.V5 && OurRobot.V6>=OurRobot.V5){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*IntAndFloat();*/
while(OurRobot.V2==OurRobot.V6 && OurRobot.V3!=OurRobot.V0){while(OurRobot.V4>=OurRobot.V7){/*CircularTargetFire();*/}}
if(OurRobot.V0<=OurRobot.V5){/*IntAndFloat();*/}
/*CircularTargetFire();*/
if(OurRobot.V7<=OurRobot.V5){if(OurRobot.V2<=OurRobot.V4){/*IntAndFloat();*/}}
		}
	}
}