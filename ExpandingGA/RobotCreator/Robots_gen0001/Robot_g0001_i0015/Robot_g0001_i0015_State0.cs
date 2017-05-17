using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0015 OurRobot { get; set; }
		public State0 (Robot_g0001_i0015 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V2==OurRobot.V4 && OurRobot.V5!=OurRobot.V2 && OurRobot.V4==OurRobot.V3 || OurRobot.V3!=OurRobot.V1)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(122, 40, 135);
			
if(OurRobot.V5==OurRobot.V2){/*IntAndFloat(20,-1.0f);*/}
while(OurRobot.V2>OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
if(OurRobot.V0<=OurRobot.V2 && OurRobot.V2<=OurRobot.V4 || OurRobot.V1<=OurRobot.V3 && OurRobot.V5==OurRobot.V1){/*IntAndFloat();*/}
if(OurRobot.V3>OurRobot.V5 || OurRobot.V0==OurRobot.V2){while(OurRobot.V5>OurRobot.V3){/*IntAndFloat();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V4<=OurRobot.V0){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V0==OurRobot.V3 && OurRobot.V1==OurRobot.V0 || OurRobot.V0>=OurRobot.V4 && OurRobot.V0<=OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
while(OurRobot.V3>=OurRobot.V2){if(OurRobot.V4<OurRobot.V0 && OurRobot.V0==OurRobot.V2 && OurRobot.V0==OurRobot.V3 && OurRobot.V3>OurRobot.V0){/*IntAndFloat();*/}}
if(OurRobot.V5>OurRobot.V1 || OurRobot.V1>OurRobot.V4){while(OurRobot.V1<OurRobot.V2){if(OurRobot.V0>=OurRobot.V5 || OurRobot.V5<=OurRobot.V1 && OurRobot.V2!=OurRobot.V1){/*IntAndFloat();*/}}}
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V0>=OurRobot.V3 || OurRobot.V4<OurRobot.V3 || OurRobot.V3>=OurRobot.V1 && OurRobot.V3>=OurRobot.V0){/*Example();*/}
/*IntAndFloat();*/
while(OurRobot.V1==OurRobot.V5 && OurRobot.V0>OurRobot.V5){/*IntAndFloat();*/}
/*IntAndFloat();*/
while(OurRobot.V0!=OurRobot.V4){while(OurRobot.V2<=OurRobot.V0){/*CircularTargetFire();*/}}
/*IntAndFloat();*/
while(OurRobot.V1<OurRobot.V3){/*IntAndFloat();*/}
		}

		public override void ExitState()
		{
			
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V0!=OurRobot.V4){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V4>OurRobot.V5){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*CircularTargetFire();*/
/*IntAndFloat();*/
if(OurRobot.V0<=OurRobot.V1 && OurRobot.V1==OurRobot.V5){if(OurRobot.V4>OurRobot.V1 || OurRobot.V2<=OurRobot.V1){/*IntAndFloat();*/}}
		}
	}
}