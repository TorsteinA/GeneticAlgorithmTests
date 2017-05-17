using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0041 OurRobot { get; set; }
		public State1 (Robot_g0000_i0041 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V1==OurRobot.V2)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(0, 172, 255);
			
while(OurRobot.V3>=OurRobot.V0){/*Example();*/}
while(OurRobot.V6!=OurRobot.V3 && OurRobot.V4<=OurRobot.V2 && OurRobot.V5>OurRobot.V1 || OurRobot.V1>OurRobot.V5){while(OurRobot.V4>OurRobot.V6){/*IntAndFloat();*/}}
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V0!=OurRobot.V2){/*IntAndFloat();*/}
/*IntAndFloat();*/
while(OurRobot.V5<OurRobot.V2 || OurRobot.V4>OurRobot.V3 || OurRobot.V6>OurRobot.V3){while(OurRobot.V0==OurRobot.V6){if(OurRobot.V1>OurRobot.V0){/*IntAndFloat();*/}}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*Example();*/
/*IntAndFloat();*/
if(OurRobot.V0<OurRobot.V4 && OurRobot.V1<=OurRobot.V0 || OurRobot.V6<=OurRobot.V1){if(OurRobot.V0>OurRobot.V3 || OurRobot.V5<OurRobot.V6){if(OurRobot.V4>OurRobot.V5){/*IntAndFloat();*/}}}
while(OurRobot.V6<OurRobot.V3){while(OurRobot.V1<=OurRobot.V0 && OurRobot.V3==OurRobot.V4){/*IntAndFloat();*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V6<=OurRobot.V4 && OurRobot.V5<OurRobot.V0){/*IntAndFloat();*/}
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
while(OurRobot.V4==OurRobot.V6 || OurRobot.V3>=OurRobot.V1 && OurRobot.V6>=OurRobot.V1){if(OurRobot.V5<=OurRobot.V0){/*Example();*/}}
while(OurRobot.V3<OurRobot.V5){while(OurRobot.V0<=OurRobot.V2){/*IntAndFloat();*/}}
while(OurRobot.V6<OurRobot.V3){while(OurRobot.V5<=OurRobot.V1 || OurRobot.V1<OurRobot.V0 || OurRobot.V4==OurRobot.V6 && OurRobot.V1>OurRobot.V0){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*IntAndFloat();*/
if(OurRobot.V5==OurRobot.V2){/*IntAndFloat();*/}
if(OurRobot.V3==OurRobot.V0){while(OurRobot.V0==OurRobot.V6){/*IntAndFloat();*/}}
if(OurRobot.V3>OurRobot.V0 && OurRobot.V0>=OurRobot.V6 && OurRobot.V0==OurRobot.V6){if(OurRobot.V2==OurRobot.V4){/*IntAndFloat();*/}}
if(OurRobot.V3>=OurRobot.V0){/*Example();*/}
if(OurRobot.V5==OurRobot.V0){/*Example();*/}
while(OurRobot.V2<=OurRobot.V4 && OurRobot.V4!=OurRobot.V2){if(OurRobot.V3<=OurRobot.V0 || OurRobot.V6<=OurRobot.V2 || OurRobot.V3<=OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
while(OurRobot.V3>OurRobot.V2 && OurRobot.V4!=OurRobot.V3 && OurRobot.V2<=OurRobot.V3 && OurRobot.V1<OurRobot.V5){while(OurRobot.V2>OurRobot.V5 || OurRobot.V3==OurRobot.V0){/*IntAndFloat();*/}}
		}
	}
}