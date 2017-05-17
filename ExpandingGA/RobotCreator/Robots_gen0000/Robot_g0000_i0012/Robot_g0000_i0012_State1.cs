using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0012 OurRobot { get; set; }
		public State1 (Robot_g0000_i0012 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V1>OurRobot.V4 || OurRobot.V0>=OurRobot.V2 && OurRobot.V5>=OurRobot.V3)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(71, 180, 233);
			
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V3<=OurRobot.V2){/*IntAndFloat(23,-1.0f);*/}
while(OurRobot.V0<OurRobot.V6){while(OurRobot.V2!=OurRobot.V1 && OurRobot.V4==OurRobot.V6){/*IntAndFloat();*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V1!=OurRobot.V3 || OurRobot.V4>=OurRobot.V5){/*IntAndFloat();*/}
while(OurRobot.V0!=OurRobot.V3 && OurRobot.V6==OurRobot.V5){/*Example();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
		}

		public override void DoStateAction()
		{
			
/*Example();*/
while(OurRobot.V5>OurRobot.V6 || OurRobot.V6!=OurRobot.V5 || OurRobot.V5>OurRobot.V6){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V1==OurRobot.V3 && OurRobot.V5<OurRobot.V4){/*IntAndFloat();*/}
if(OurRobot.V5<=OurRobot.V0){if(OurRobot.V6<OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
if(OurRobot.V2==OurRobot.V1 || OurRobot.V5<OurRobot.V3 || OurRobot.V0==OurRobot.V1 || OurRobot.V3==OurRobot.V0){while(OurRobot.V0>OurRobot.V1){if(OurRobot.V0==OurRobot.V1){/*Example();*/}}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V6>OurRobot.V3){/*CircularTargetFire();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
while(OurRobot.V4==OurRobot.V5){/*Example();*/}
while(OurRobot.V1<=OurRobot.V4 && OurRobot.V3==OurRobot.V2){while(OurRobot.V5<OurRobot.V6){/*IntAndFloat();*/}}
if(OurRobot.V0!=OurRobot.V3 || OurRobot.V1<OurRobot.V6){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
while(OurRobot.V4<OurRobot.V5 || OurRobot.V6!=OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
if(OurRobot.V2<OurRobot.V3 || OurRobot.V3==OurRobot.V2 || OurRobot.V6!=OurRobot.V4 || OurRobot.V2>=OurRobot.V3){/*CircularTargetFire();*/}
while(OurRobot.V3>OurRobot.V6){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
if(OurRobot.V6>OurRobot.V2 && OurRobot.V6<=OurRobot.V0){/*IntAndFloat();*/}
if(OurRobot.V4>OurRobot.V0 && OurRobot.V2==OurRobot.V6 && OurRobot.V2<=OurRobot.V6){/*IntAndFloat();*/}
/*IntAndFloat();*/
while(OurRobot.V4<=OurRobot.V5){if(OurRobot.V4>=OurRobot.V0){if(OurRobot.V4>=OurRobot.V1){/*IntAndFloat();*/}}}
		}
	}
}