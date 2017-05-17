using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0036 OurRobot { get; set; }
		public State0 (Robot_g0001_i0036 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V7!=OurRobot.V1 && OurRobot.V6!=OurRobot.V0)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(178, 223, 12);
			
while(OurRobot.V0>=OurRobot.V4){/*IntAndFloat(-1,-1.0f);*/}
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V0>OurRobot.V5){/*CircularTargetFire();*/}
/*Example();*/
if(OurRobot.V1>OurRobot.V4 || OurRobot.V3!=OurRobot.V1 || OurRobot.V2<=OurRobot.V4){if(OurRobot.V2<OurRobot.V4 || OurRobot.V0<=OurRobot.V7){if(OurRobot.V3!=OurRobot.V1 && OurRobot.V7==OurRobot.V1 && OurRobot.V4<=OurRobot.V5){/*IntAndFloat();*/}}}
/*CircularTargetFire();*/
while(OurRobot.V4>=OurRobot.V7 || OurRobot.V2>OurRobot.V0 && OurRobot.V4!=OurRobot.V1){if(OurRobot.V0<=OurRobot.V5 || OurRobot.V0==OurRobot.V4 && OurRobot.V3>OurRobot.V4 || OurRobot.V7<OurRobot.V4){if(OurRobot.V2>=OurRobot.V0){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}}
if(OurRobot.V1!=OurRobot.V3 && OurRobot.V5!=OurRobot.V4){if(OurRobot.V1<=OurRobot.V2){if(OurRobot.V5<=OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}}
/*Example();*/
if(OurRobot.V1<=OurRobot.V0 && OurRobot.V4!=OurRobot.V2){while(OurRobot.V5<=OurRobot.V2 || OurRobot.V1<OurRobot.V6 && OurRobot.V7<OurRobot.V3){/*Example();*/}}
while(OurRobot.V6<OurRobot.V0 && OurRobot.V7==OurRobot.V5 || OurRobot.V3==OurRobot.V5){while(OurRobot.V4>=OurRobot.V1){/*IntAndFloat();*/}}
while(OurRobot.V2==OurRobot.V1 || OurRobot.V6<=OurRobot.V3){if(OurRobot.V2==OurRobot.V6){/*Example();*/}}
/*Example();*/
		}

		public override void ExitState()
		{
			
		}
	}
}