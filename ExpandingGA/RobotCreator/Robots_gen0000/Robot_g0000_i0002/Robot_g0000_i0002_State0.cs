using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0002 OurRobot { get; set; }
		public State0 (Robot_g0000_i0002 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V6>=OurRobot.V4)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(252, 87, 38);
			
if(OurRobot.V0>OurRobot.V5){while(OurRobot.V6<OurRobot.V5 && OurRobot.V0<OurRobot.V3 && OurRobot.V0>OurRobot.V4 && OurRobot.V6==OurRobot.V2){/*IntAndFloat(7,-1.0f);*/}}
while(OurRobot.V0<=OurRobot.V3){if(OurRobot.V5!=OurRobot.V4 && OurRobot.V1>=OurRobot.V4 && OurRobot.V0==OurRobot.V5 || OurRobot.V2==OurRobot.V0){if(OurRobot.V3<=OurRobot.V4 && OurRobot.V0>OurRobot.V4){/*IntAndFloat();*/}}}
while(OurRobot.V2>OurRobot.V5 || OurRobot.V3!=OurRobot.V4 || OurRobot.V5!=OurRobot.V1){/*Example();*/}
while(OurRobot.V1!=OurRobot.V3){while(OurRobot.V5<OurRobot.V1 || OurRobot.V6<OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
while(OurRobot.V3<OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V2<OurRobot.V5){while(OurRobot.V1<OurRobot.V6 || OurRobot.V4==OurRobot.V6){/*CircularTargetFire();*/}}
while(OurRobot.V5>=OurRobot.V4 && OurRobot.V2>OurRobot.V3 && OurRobot.V0<=OurRobot.V5 || OurRobot.V1<OurRobot.V6){if(OurRobot.V0>OurRobot.V6 || OurRobot.V3==OurRobot.V5){if(OurRobot.V3<OurRobot.V0 && OurRobot.V3!=OurRobot.V1){/*Example();*/}}}
/*IntAndFloat();*/
while(OurRobot.V2>=OurRobot.V3 && OurRobot.V4>OurRobot.V6){if(OurRobot.V3>OurRobot.V1){/*IntAndFloat();*/}}
while(OurRobot.V6<OurRobot.V3 && OurRobot.V0==OurRobot.V4){/*IntAndFloat();*/}
/*Example();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
if(OurRobot.V0<=OurRobot.V1){/*IntAndFloat();*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V5<=OurRobot.V4){/*CircularTargetFire();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V4==OurRobot.V6){/*IntAndFloat();*/}
/*CircularTargetFire();*/
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V2<=OurRobot.V6 || OurRobot.V2>=OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*Example();*/
/*Example();*/
/*Example();*/
		}
	}
}