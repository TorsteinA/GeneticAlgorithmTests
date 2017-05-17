using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0013 OurRobot { get; set; }
		public State1 (Robot_g0000_i0013 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V7>=OurRobot.V4)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(230, 193, 22);
			
while(OurRobot.V2==OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
if(OurRobot.V2<OurRobot.V4 || OurRobot.V1>OurRobot.V2){if(OurRobot.V4<=OurRobot.V2 && OurRobot.V5!=OurRobot.V6 || OurRobot.V3>=OurRobot.V5 && OurRobot.V6==OurRobot.V7){if(OurRobot.V0<OurRobot.V2 || OurRobot.V0<OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}}
while(OurRobot.V4>=OurRobot.V1){if(OurRobot.V3>OurRobot.V6 && OurRobot.V7<=OurRobot.V6 || OurRobot.V3<=OurRobot.V4 && OurRobot.V7>=OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
while(OurRobot.V1<OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
		}

		public override void DoStateAction()
		{
			
/*IntAndFloat();*/
if(OurRobot.V1<=OurRobot.V3){/*CircularTargetFire();*/}
if(OurRobot.V3==OurRobot.V6){while(OurRobot.V4<=OurRobot.V5 && OurRobot.V6!=OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
if(OurRobot.V5<=OurRobot.V2){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*Example();*/
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V5!=OurRobot.V1){while(OurRobot.V0!=OurRobot.V1 && OurRobot.V0>=OurRobot.V2){/*IntAndFloat();*/}}
while(OurRobot.V4<OurRobot.V7 && OurRobot.V7>=OurRobot.V6 || OurRobot.V3<=OurRobot.V5 || OurRobot.V6==OurRobot.V1){/*IntAndFloat();*/}
if(OurRobot.V1==OurRobot.V3){while(OurRobot.V6<=OurRobot.V2){/*IntAndFloat();*/}}
if(OurRobot.V3==OurRobot.V0){while(OurRobot.V0==OurRobot.V4 && OurRobot.V7>=OurRobot.V6 || OurRobot.V0>OurRobot.V3 && OurRobot.V6>=OurRobot.V1){/*IntAndFloat();*/}}
if(OurRobot.V4>=OurRobot.V1){while(OurRobot.V2<=OurRobot.V6){if(OurRobot.V3!=OurRobot.V7 || OurRobot.V7>=OurRobot.V6 && OurRobot.V2<=OurRobot.V1 && OurRobot.V2<=OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}}
if(OurRobot.V7>=OurRobot.V0){/*CircularTargetFire();*/}
/*IntAndFloat();*/
if(OurRobot.V1!=OurRobot.V7 && OurRobot.V0!=OurRobot.V4 && OurRobot.V4>OurRobot.V5 && OurRobot.V0==OurRobot.V4){if(OurRobot.V0>OurRobot.V3){if(OurRobot.V1<OurRobot.V5){/*CircularTargetFire();*/}}}
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V1>=OurRobot.V0 && OurRobot.V5<=OurRobot.V4){/*IntAndFloat();*/}
while(OurRobot.V1<OurRobot.V2 || OurRobot.V4==OurRobot.V6){if(OurRobot.V3==OurRobot.V6){/*IntAndFloat();*/}}
		}
	}
}