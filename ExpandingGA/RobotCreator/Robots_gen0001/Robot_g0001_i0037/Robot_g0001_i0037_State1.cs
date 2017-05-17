using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0037 OurRobot { get; set; }
		public State1 (Robot_g0001_i0037 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V0<OurRobot.V4)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(236, 193, 160);
			
/*IntAndFloat(-10,-1.0f);*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V5>OurRobot.V4 || OurRobot.V0<=OurRobot.V1 && OurRobot.V2>OurRobot.V5){while(OurRobot.V5<OurRobot.V1 || OurRobot.V0==OurRobot.V6){/*CircularTargetFire();*/}}
/*IntAndFloat();*/
while(OurRobot.V1<=OurRobot.V6 && OurRobot.V4<=OurRobot.V1 || OurRobot.V1!=OurRobot.V5){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*CircularTargetFire();*/
while(OurRobot.V4!=OurRobot.V0){if(OurRobot.V2<=OurRobot.V1){/*IntAndFloat();*/}}
if(OurRobot.V6==OurRobot.V3 || OurRobot.V6<OurRobot.V1 || OurRobot.V3>OurRobot.V0 || OurRobot.V2>=OurRobot.V6){while(OurRobot.V3>=OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*Example();*/
/*Example();*/
		}

		public override void DoStateAction()
		{
			
/*IntAndFloat();*/
/*Example();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V6!=OurRobot.V3 || OurRobot.V3<=OurRobot.V0 || OurRobot.V4<OurRobot.V2 && OurRobot.V6<=OurRobot.V1){if(OurRobot.V2<=OurRobot.V6){/*CircularTargetFire();*/}}
while(OurRobot.V3!=OurRobot.V4){if(OurRobot.V6>OurRobot.V2 && OurRobot.V3<OurRobot.V6){/*CircularTargetFire();*/}}
while(OurRobot.V2<OurRobot.V5){/*IntAndFloat();*/}
while(OurRobot.V5>=OurRobot.V4 || OurRobot.V4>=OurRobot.V3){while(OurRobot.V5<=OurRobot.V4 && OurRobot.V3>OurRobot.V1){/*IntAndFloat();*/}}
/*Example();*/
/*IntAndFloat();*/
while(OurRobot.V0<=OurRobot.V2 && OurRobot.V6>=OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
if(OurRobot.V6==OurRobot.V3 || OurRobot.V6>OurRobot.V3 || OurRobot.V0>=OurRobot.V4 || OurRobot.V0==OurRobot.V6){/*IntAndFloat();*/}
while(OurRobot.V5!=OurRobot.V4 || OurRobot.V3<OurRobot.V6){/*IntAndFloat();*/}
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
while(OurRobot.V6>OurRobot.V0){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
while(OurRobot.V3>OurRobot.V4){while(OurRobot.V6==OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
while(OurRobot.V1>=OurRobot.V4){if(OurRobot.V5<=OurRobot.V3){/*IntAndFloat();*/}}
if(OurRobot.V0<OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*IntAndFloat();*/
		}
	}
}