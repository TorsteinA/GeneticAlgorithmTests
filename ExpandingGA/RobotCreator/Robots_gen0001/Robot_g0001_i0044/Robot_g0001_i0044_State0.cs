using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0044 OurRobot { get; set; }
		public State0 (Robot_g0001_i0044 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V1!=OurRobot.V4 || OurRobot.V2==OurRobot.V5 && OurRobot.V0!=OurRobot.V4)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(198, 230, 128);
			
/*IntAndFloat(14,-1.0f);*/
/*CircularTargetFire();*/
/*IntAndFloat();*/
while(OurRobot.V1!=OurRobot.V2 && OurRobot.V3<=OurRobot.V2 || OurRobot.V4!=OurRobot.V2){if(OurRobot.V0<=OurRobot.V6 && OurRobot.V2<=OurRobot.V0){/*IntAndFloat();*/}}
/*CircularTargetFire();*/
while(OurRobot.V0<OurRobot.V6){/*Example();*/}
/*CircularTargetFire();*/
while(OurRobot.V2<OurRobot.V0 || OurRobot.V3>=OurRobot.V0 && OurRobot.V1<=OurRobot.V4){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V2==OurRobot.V6){/*IntAndFloat();*/}
while(OurRobot.V0==OurRobot.V4 || OurRobot.V3>OurRobot.V0 && OurRobot.V5>OurRobot.V4 || OurRobot.V6<OurRobot.V5){while(OurRobot.V5==OurRobot.V1 || OurRobot.V5==OurRobot.V3){/*IntAndFloat();*/}}
		}

		public override void DoStateAction()
		{
			
/*IntAndFloat();*/
/*Example();*/
if(OurRobot.V4<OurRobot.V1){if(OurRobot.V0!=OurRobot.V6){if(OurRobot.V5>=OurRobot.V2 || OurRobot.V5>=OurRobot.V0){/*IntAndFloat();*/}}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V3<=OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
while(OurRobot.V0==OurRobot.V4 && OurRobot.V4==OurRobot.V0){while(OurRobot.V3!=OurRobot.V6){/*IntAndFloat();*/}}
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
/*CircularTargetFire();*/
while(OurRobot.V1==OurRobot.V4){while(OurRobot.V0==OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
if(OurRobot.V2<OurRobot.V3 || OurRobot.V1>OurRobot.V3 || OurRobot.V2>=OurRobot.V6 && OurRobot.V0<OurRobot.V5){/*IntAndFloat();*/}
/*IntAndFloat();*/
while(OurRobot.V4<=OurRobot.V2 && OurRobot.V0>OurRobot.V6 || OurRobot.V2>OurRobot.V3 && OurRobot.V0==OurRobot.V6){/*IntAndFloat();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V2!=OurRobot.V3 && OurRobot.V0<OurRobot.V6){/*IntAndFloat();*/}
/*IntAndFloat();*/
if(OurRobot.V6>OurRobot.V2){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
if(OurRobot.V4>OurRobot.V2){if(OurRobot.V4<=OurRobot.V3 && OurRobot.V0<OurRobot.V5){/*IntAndFloat();*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V6!=OurRobot.V2){while(OurRobot.V6<=OurRobot.V1 || OurRobot.V6==OurRobot.V2 && OurRobot.V6<OurRobot.V1){if(OurRobot.V2<=OurRobot.V6){/*IntAndFloat();*/}}}
/*IntAndFloat();*/
/*CircularTargetFire();*/
		}
	}
}