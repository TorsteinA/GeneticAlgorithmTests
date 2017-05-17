using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0019 OurRobot { get; set; }
		public State0 (Robot_g0001_i0019 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V0==OurRobot.V1)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(147, 218, 183);
			
/*CircularTargetFire();*/
		}

		public override void DoStateAction()
		{
			
/*Example();*/
/*IntAndFloat();*/
if(OurRobot.V2<OurRobot.V0 || OurRobot.V3<OurRobot.V5 && OurRobot.V5<=OurRobot.V4 || OurRobot.V2==OurRobot.V1){while(OurRobot.V3<OurRobot.V2){if(OurRobot.V3>=OurRobot.V1 || OurRobot.V5>OurRobot.V2 || OurRobot.V1>=OurRobot.V5){/*CircularTargetFire();*/}}}
while(OurRobot.V4>OurRobot.V0 && OurRobot.V3>OurRobot.V5){/*IntAndFloat();*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V5<=OurRobot.V0 || OurRobot.V0<=OurRobot.V1 && OurRobot.V1<OurRobot.V4 && OurRobot.V1>=OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
		}

		public override void ExitState()
		{
			
/*IntAndFloat(1,-1.0f);*/
while(OurRobot.V1!=OurRobot.V2 && OurRobot.V1<=OurRobot.V3){while(OurRobot.V1==OurRobot.V2){if(OurRobot.V1<OurRobot.V3){/*CircularTargetFire();*/}}}
while(OurRobot.V0>OurRobot.V2){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
if(OurRobot.V5<OurRobot.V0 || OurRobot.V3==OurRobot.V5 || OurRobot.V1<=OurRobot.V2 && OurRobot.V0>=OurRobot.V1){while(OurRobot.V2==OurRobot.V1){/*IntAndFloat();*/}}
/*IntAndFloat();*/
		}
	}
}