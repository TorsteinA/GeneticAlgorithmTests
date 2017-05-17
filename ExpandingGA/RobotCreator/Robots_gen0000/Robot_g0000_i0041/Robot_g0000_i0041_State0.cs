using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0041 OurRobot { get; set; }
		public State0 (Robot_g0000_i0041 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V5>=OurRobot.V2 || OurRobot.V2>OurRobot.V0)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(207, 69, 62);
			
/*CircularTargetFire();*/
while(OurRobot.V4<OurRobot.V6){/*CircularTargetFire();*/}
while(OurRobot.V3!=OurRobot.V1){if(OurRobot.V3<=OurRobot.V5){/*Example();*/}}
/*IntAndFloat(7,-1.0f);*/
while(OurRobot.V4>OurRobot.V0 && OurRobot.V5<OurRobot.V1 || OurRobot.V4==OurRobot.V0 && OurRobot.V6<OurRobot.V2){/*IntAndFloat();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V3>=OurRobot.V0){/*Example();*/}
/*CircularTargetFire();*/
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V3>OurRobot.V2 || OurRobot.V1<=OurRobot.V0 || OurRobot.V6>OurRobot.V1){if(OurRobot.V5==OurRobot.V0){/*Example();*/}}
while(OurRobot.V2<=OurRobot.V4 && OurRobot.V4!=OurRobot.V2){if(OurRobot.V3<=OurRobot.V0 || OurRobot.V6<=OurRobot.V2 || OurRobot.V3<=OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
while(OurRobot.V3>OurRobot.V2 && OurRobot.V4!=OurRobot.V3 && OurRobot.V2<=OurRobot.V3 && OurRobot.V1<OurRobot.V5){while(OurRobot.V2>OurRobot.V5 || OurRobot.V3==OurRobot.V0){/*IntAndFloat();*/}}
if(OurRobot.V4>=OurRobot.V1 || OurRobot.V1==OurRobot.V4){if(OurRobot.V1>=OurRobot.V6 || OurRobot.V4<=OurRobot.V3){/*IntAndFloat();*/}}
if(OurRobot.V5==OurRobot.V6){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
while(OurRobot.V0<OurRobot.V2 && OurRobot.V1>=OurRobot.V5){/*Example();*/}
while(OurRobot.V0==OurRobot.V6){if(OurRobot.V1>OurRobot.V0){if(OurRobot.V4!=OurRobot.V2 || OurRobot.V5==OurRobot.V4){/*IntAndFloat();*/}}}
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V2!=OurRobot.V6){/*IntAndFloat();*/}
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
while(OurRobot.V4<OurRobot.V6){if(OurRobot.V5<OurRobot.V1){if(OurRobot.V4!=OurRobot.V0 && OurRobot.V2>=OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*CircularTargetFire();*/
if(OurRobot.V3==OurRobot.V2){/*IntAndFloat();*/}
if(OurRobot.V1>=OurRobot.V3){/*IntAndFloat();*/}
if(OurRobot.V6<OurRobot.V0){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*Example();*/
while(OurRobot.V5>=OurRobot.V2){/*IntAndFloat();*/}
while(OurRobot.V2<=OurRobot.V0){/*IntAndFloat();*/}
		}
	}
}