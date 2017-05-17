using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0022 OurRobot { get; set; }
		public State0 (Robot_g0000_i0022 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V6<=OurRobot.V3 && OurRobot.V3>=OurRobot.V2)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(152, 101, 156);
			
/*IntAndFloat(30,-1.0f);*/
if(OurRobot.V2==OurRobot.V6){/*Example();*/}
		}

		public override void DoStateAction()
		{
			
/*CircularTargetFire();*/
while(OurRobot.V5==OurRobot.V6 || OurRobot.V0==OurRobot.V2 && OurRobot.V5!=OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
if(OurRobot.V2!=OurRobot.V5 && OurRobot.V5<OurRobot.V3){/*Example();*/}
if(OurRobot.V0==OurRobot.V3){if(OurRobot.V6!=OurRobot.V2 || OurRobot.V4<=OurRobot.V6){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V0>OurRobot.V6 || OurRobot.V3<=OurRobot.V4){/*CircularTargetFire();*/}
		}

		public override void ExitState()
		{
			
if(OurRobot.V3>OurRobot.V2){if(OurRobot.V3!=OurRobot.V0){if(OurRobot.V0!=OurRobot.V3){/*IntAndFloat();*/}}}
while(OurRobot.V2==OurRobot.V3 || OurRobot.V0<OurRobot.V2){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
if(OurRobot.V5!=OurRobot.V2 && OurRobot.V3<OurRobot.V5){/*IntAndFloat();*/}
if(OurRobot.V4!=OurRobot.V0 || OurRobot.V6>OurRobot.V5 || OurRobot.V2<=OurRobot.V5 || OurRobot.V3==OurRobot.V1){while(OurRobot.V3>OurRobot.V4 && OurRobot.V0>OurRobot.V3){if(OurRobot.V4<OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}}
/*IntAndFloat();*/
while(OurRobot.V5<=OurRobot.V4){if(OurRobot.V0<=OurRobot.V3 && OurRobot.V1>=OurRobot.V6 || OurRobot.V6!=OurRobot.V2 || OurRobot.V0!=OurRobot.V5){if(OurRobot.V1<OurRobot.V5 && OurRobot.V0!=OurRobot.V6 || OurRobot.V0<=OurRobot.V1 && OurRobot.V0<=OurRobot.V4){/*Example();*/}}}
/*Example();*/
/*IntAndFloat();*/
/*CircularTargetFire();*/
while(OurRobot.V0<OurRobot.V3 && OurRobot.V3>=OurRobot.V1 && OurRobot.V2>OurRobot.V0 && OurRobot.V4<OurRobot.V2){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V2>OurRobot.V3){if(OurRobot.V1<OurRobot.V5 && OurRobot.V4==OurRobot.V6){/*IntAndFloat();*/}}
if(OurRobot.V1<=OurRobot.V5){/*IntAndFloat();*/}
		}
	}
}