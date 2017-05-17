using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0035 OurRobot { get; set; }
		public State0 (Robot_g0001_i0035 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V4!=OurRobot.V1)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(85, 34, 189);
			
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V7<=OurRobot.V0 || OurRobot.V1>OurRobot.V3 && OurRobot.V0>OurRobot.V5){if(OurRobot.V3<OurRobot.V0){/*Example();*/}}
if(OurRobot.V2>OurRobot.V0){if(OurRobot.V5<=OurRobot.V2){/*CircularTargetFire();*/}}
/*Example();*/
if(OurRobot.V7>OurRobot.V0){if(OurRobot.V2<=OurRobot.V6){/*IntAndFloat(-1,-1.0f);*/}}
if(OurRobot.V5!=OurRobot.V6 || OurRobot.V1==OurRobot.V2){/*IntAndFloat();*/}
while(OurRobot.V6>=OurRobot.V0){while(OurRobot.V7>=OurRobot.V1 || OurRobot.V6>OurRobot.V2 && OurRobot.V4<=OurRobot.V1){/*IntAndFloat();*/}}
while(OurRobot.V1==OurRobot.V4){/*IntAndFloat();*/}
if(OurRobot.V2>=OurRobot.V4 && OurRobot.V6<=OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
while(OurRobot.V3==OurRobot.V6 || OurRobot.V1!=OurRobot.V6 || OurRobot.V1!=OurRobot.V2 && OurRobot.V6!=OurRobot.V5){/*IntAndFloat();*/}
/*CircularTargetFire();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V3<OurRobot.V6){while(OurRobot.V4==OurRobot.V6){/*Example();*/}}
if(OurRobot.V5<=OurRobot.V4 && OurRobot.V2>OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
		}

		public override void DoStateAction()
		{
			
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V3!=OurRobot.V0 && OurRobot.V6!=OurRobot.V4){while(OurRobot.V1!=OurRobot.V3){/*IntAndFloat();*/}}
/*IntAndFloat();*/
while(OurRobot.V3<=OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
if(OurRobot.V1!=OurRobot.V4 || OurRobot.V4>=OurRobot.V0){/*IntAndFloat();*/}
/*Example();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
		}

		public override void ExitState()
		{
			
if(OurRobot.V4>OurRobot.V6){while(OurRobot.V1<=OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V2>OurRobot.V3){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*Example();*/
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
while(OurRobot.V4>OurRobot.V7 && OurRobot.V1!=OurRobot.V6){/*IntAndFloat();*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V1<OurRobot.V4 && OurRobot.V0>OurRobot.V2 || OurRobot.V4>OurRobot.V7 || OurRobot.V5>OurRobot.V4){while(OurRobot.V7<=OurRobot.V5 || OurRobot.V3>OurRobot.V2){/*IntAndFloat();*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V6==OurRobot.V7 && OurRobot.V7>OurRobot.V0 || OurRobot.V5>OurRobot.V1 && OurRobot.V7<=OurRobot.V5){/*IntAndFloat();*/}
/*IntAndFloat();*/
		}
	}
}