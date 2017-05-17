using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0013 OurRobot { get; set; }
		public State0 (Robot_g0001_i0013 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V0<OurRobot.V1)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(138, 70, 203);
			
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
		}

		public override void DoStateAction()
		{
			
/*Example();*/
if(OurRobot.V3!=OurRobot.V6 || OurRobot.V7==OurRobot.V3 || OurRobot.V7<=OurRobot.V2 || OurRobot.V0>OurRobot.V1){/*Example();*/}
if(OurRobot.V7>OurRobot.V2){while(OurRobot.V3!=OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
if(OurRobot.V1!=OurRobot.V7 && OurRobot.V0!=OurRobot.V4 && OurRobot.V4>OurRobot.V5 && OurRobot.V0==OurRobot.V4){if(OurRobot.V0>OurRobot.V3){if(OurRobot.V1<OurRobot.V5){/*CircularTargetFire();*/}}}
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V1>=OurRobot.V0 && OurRobot.V5<=OurRobot.V4){/*IntAndFloat();*/}
while(OurRobot.V1<OurRobot.V2 || OurRobot.V4==OurRobot.V6){if(OurRobot.V3==OurRobot.V6){/*IntAndFloat();*/}}
if(OurRobot.V1>=OurRobot.V0){if(OurRobot.V7!=OurRobot.V3 || OurRobot.V5<=OurRobot.V4 && OurRobot.V1<OurRobot.V0 && OurRobot.V7==OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*IntAndFloat();*/
while(OurRobot.V2>=OurRobot.V1){/*IntAndFloat();*/}
if(OurRobot.V0<OurRobot.V3 || OurRobot.V4!=OurRobot.V0){if(OurRobot.V5!=OurRobot.V1){/*IntAndFloat();*/}}
if(OurRobot.V1<=OurRobot.V6){while(OurRobot.V7<=OurRobot.V5){/*IntAndFloat();*/}}
while(OurRobot.V2<=OurRobot.V1 && OurRobot.V0<OurRobot.V2 && OurRobot.V6==OurRobot.V2){if(OurRobot.V0<OurRobot.V1 || OurRobot.V5>=OurRobot.V7){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
		}

		public override void ExitState()
		{
			
while(OurRobot.V0==OurRobot.V1 && OurRobot.V2==OurRobot.V5){/*IntAndFloat(-4,-1.0f);*/}
while(OurRobot.V0==OurRobot.V6 || OurRobot.V1<=OurRobot.V3){if(OurRobot.V2>=OurRobot.V1 || OurRobot.V3==OurRobot.V7 || OurRobot.V6!=OurRobot.V1 || OurRobot.V6>OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
while(OurRobot.V5<OurRobot.V6 && OurRobot.V3<=OurRobot.V1){/*CircularTargetFire();*/}
/*Example();*/
while(OurRobot.V4!=OurRobot.V7){/*Example();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
		}
	}
}