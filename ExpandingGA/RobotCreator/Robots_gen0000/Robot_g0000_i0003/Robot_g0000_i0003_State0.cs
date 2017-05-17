using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0003 OurRobot { get; set; }
		public State0 (Robot_g0000_i0003 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V5!=OurRobot.V2)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(246, 216, 155);
			
if(OurRobot.V2==OurRobot.V1 && OurRobot.V1>OurRobot.V5 || OurRobot.V6>=OurRobot.V0){while(OurRobot.V2>=OurRobot.V3){/*CircularTargetFire();*/}}
while(OurRobot.V5>=OurRobot.V3){/*IntAndFloat(-1,-1.0f);*/}
while(OurRobot.V0==OurRobot.V6){if(OurRobot.V6<OurRobot.V2 || OurRobot.V0>OurRobot.V6){/*IntAndFloat();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V4<=OurRobot.V2){if(OurRobot.V3>=OurRobot.V6 && OurRobot.V1<=OurRobot.V3 || OurRobot.V2<OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*IntAndFloat();*/
/*Example();*/
while(OurRobot.V4!=OurRobot.V5){if(OurRobot.V6<=OurRobot.V2){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V5<=OurRobot.V0){/*IntAndFloat();*/}
/*IntAndFloat();*/
		}

		public override void DoStateAction()
		{
			
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V6>=OurRobot.V1){while(OurRobot.V6!=OurRobot.V3 || OurRobot.V5<OurRobot.V3 && OurRobot.V3!=OurRobot.V0 || OurRobot.V0>OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
if(OurRobot.V3>OurRobot.V6){/*IntAndFloat();*/}
while(OurRobot.V6==OurRobot.V1){if(OurRobot.V3!=OurRobot.V6){/*IntAndFloat();*/}}
while(OurRobot.V1!=OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
if(OurRobot.V4!=OurRobot.V5){while(OurRobot.V1<OurRobot.V4 && OurRobot.V0>OurRobot.V4){/*IntAndFloat();*/}}
		}

		public override void ExitState()
		{
			
while(OurRobot.V6>=OurRobot.V2 && OurRobot.V0!=OurRobot.V6){while(OurRobot.V2>OurRobot.V6 || OurRobot.V4==OurRobot.V0 || OurRobot.V0<=OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
while(OurRobot.V3!=OurRobot.V1){if(OurRobot.V6>OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
while(OurRobot.V6<=OurRobot.V2){while(OurRobot.V5<=OurRobot.V4 || OurRobot.V2>=OurRobot.V0){if(OurRobot.V1>=OurRobot.V6){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*Example();*/
while(OurRobot.V4==OurRobot.V0){/*IntAndFloat();*/}
		}
	}
}