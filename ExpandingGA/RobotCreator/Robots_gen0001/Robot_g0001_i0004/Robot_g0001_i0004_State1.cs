using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0004 OurRobot { get; set; }
		public State1 (Robot_g0001_i0004 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V3!=OurRobot.V7)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(198, 191, 215);
			
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V6>OurRobot.V7){/*IntAndFloat();*/}
if(OurRobot.V4==OurRobot.V3){while(OurRobot.V0>OurRobot.V3){if(OurRobot.V3==OurRobot.V0 && OurRobot.V6>=OurRobot.V7 || OurRobot.V1<OurRobot.V4 && OurRobot.V4==OurRobot.V6){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}}
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V7<=OurRobot.V0 || OurRobot.V4<OurRobot.V6){/*IntAndFloat();*/}
if(OurRobot.V4!=OurRobot.V7){if(OurRobot.V5!=OurRobot.V6 && OurRobot.V1!=OurRobot.V3 || OurRobot.V2>=OurRobot.V5){/*IntAndFloat();*/}}
while(OurRobot.V3<OurRobot.V0){/*IntAndFloat();*/}
/*IntAndFloat();*/
while(OurRobot.V5!=OurRobot.V2){while(OurRobot.V0<=OurRobot.V2 && OurRobot.V1>=OurRobot.V3 || OurRobot.V6!=OurRobot.V4){/*CircularTargetFire();*/}}
while(OurRobot.V6==OurRobot.V4){/*Example();*/}
while(OurRobot.V2<=OurRobot.V6){if(OurRobot.V5>=OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
while(OurRobot.V2>OurRobot.V0){/*Example();*/}
if(OurRobot.V0==OurRobot.V5 && OurRobot.V1>OurRobot.V3){/*IntAndFloat();*/}
while(OurRobot.V4>=OurRobot.V7){while(OurRobot.V5<OurRobot.V4 || OurRobot.V0==OurRobot.V7){if(OurRobot.V1>OurRobot.V3){/*IntAndFloat();*/}}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V1>=OurRobot.V3 || OurRobot.V0>OurRobot.V2){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
		}

		public override void ExitState()
		{
			
/*Example();*/
while(OurRobot.V5==OurRobot.V2){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
if(OurRobot.V5>=OurRobot.V3){/*CircularTargetFire();*/}
if(OurRobot.V6!=OurRobot.V4 || OurRobot.V1>=OurRobot.V5){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V5!=OurRobot.V2 || OurRobot.V3<=OurRobot.V2){while(OurRobot.V6==OurRobot.V2 && OurRobot.V2>=OurRobot.V1 || OurRobot.V2>=OurRobot.V0){/*IntAndFloat();*/}}
/*IntAndFloat();*/
if(OurRobot.V0!=OurRobot.V5){if(OurRobot.V3>=OurRobot.V4){/*CircularTargetFire();*/}}
		}
	}
}