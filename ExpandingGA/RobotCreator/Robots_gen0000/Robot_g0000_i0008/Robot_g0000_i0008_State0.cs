using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0008 OurRobot { get; set; }
		public State0 (Robot_g0000_i0008 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V3==OurRobot.V2 || OurRobot.V3>OurRobot.V2)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(104, 195, 119);
			
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V2>=OurRobot.V1){if(OurRobot.V1<=OurRobot.V0 || OurRobot.V2!=OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
if(OurRobot.V4!=OurRobot.V3 && OurRobot.V0>OurRobot.V3 || OurRobot.V2<=OurRobot.V1){/*IntAndFloat(-1,-1.0f);*/}
if(OurRobot.V0==OurRobot.V6 || OurRobot.V4>=OurRobot.V3 || OurRobot.V6!=OurRobot.V3){while(OurRobot.V5>=OurRobot.V2 && OurRobot.V0>OurRobot.V2){/*IntAndFloat();*/}}
if(OurRobot.V4<OurRobot.V1 && OurRobot.V0!=OurRobot.V4){if(OurRobot.V0<OurRobot.V1 && OurRobot.V5>=OurRobot.V6){if(OurRobot.V3!=OurRobot.V0 || OurRobot.V5!=OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V6==OurRobot.V2 && OurRobot.V5>OurRobot.V4){if(OurRobot.V0<=OurRobot.V1){if(OurRobot.V0>=OurRobot.V4 || OurRobot.V6!=OurRobot.V0 && OurRobot.V2<=OurRobot.V5 && OurRobot.V5>OurRobot.V3){/*IntAndFloat();*/}}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V5<OurRobot.V4){/*IntAndFloat();*/}
while(OurRobot.V6>=OurRobot.V3){if(OurRobot.V6<OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
while(OurRobot.V6==OurRobot.V1){/*IntAndFloat();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V3==OurRobot.V1 && OurRobot.V0<OurRobot.V1){while(OurRobot.V0<OurRobot.V3 && OurRobot.V2==OurRobot.V4 && OurRobot.V0!=OurRobot.V5){if(OurRobot.V1==OurRobot.V5){/*IntAndFloat();*/}}}
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V1>OurRobot.V5){if(OurRobot.V1==OurRobot.V3 || OurRobot.V2!=OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
		}

		public override void ExitState()
		{
			
if(OurRobot.V0==OurRobot.V3 && OurRobot.V6>OurRobot.V0 && OurRobot.V2>=OurRobot.V0 || OurRobot.V5!=OurRobot.V0){if(OurRobot.V2<OurRobot.V4 || OurRobot.V4==OurRobot.V3 || OurRobot.V3==OurRobot.V4 || OurRobot.V5<OurRobot.V4){/*Example();*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V1>OurRobot.V2 && OurRobot.V2>OurRobot.V6 || OurRobot.V3!=OurRobot.V6 && OurRobot.V0>=OurRobot.V3){while(OurRobot.V2==OurRobot.V5 || OurRobot.V0>OurRobot.V1){/*IntAndFloat();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
/*CircularTargetFire();*/
		}
	}
}