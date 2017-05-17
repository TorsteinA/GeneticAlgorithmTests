using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0049 OurRobot { get; set; }
		public State1 (Robot_g0001_i0049 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V3!=OurRobot.V6 || OurRobot.V3!=OurRobot.V5)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(180, 89, 51);
			
/*IntAndFloat();*/
/*Example();*/
if(OurRobot.V1!=OurRobot.V2 || OurRobot.V1<=OurRobot.V0 || OurRobot.V2!=OurRobot.V3){/*Example();*/}
while(OurRobot.V4<=OurRobot.V0 && OurRobot.V2<OurRobot.V1 || OurRobot.V4<OurRobot.V5 && OurRobot.V6!=OurRobot.V0){if(OurRobot.V0==OurRobot.V1 && OurRobot.V4!=OurRobot.V6 && OurRobot.V0>OurRobot.V1 || OurRobot.V1>=OurRobot.V4){/*IntAndFloat();*/}}
if(OurRobot.V0>=OurRobot.V2 || OurRobot.V2==OurRobot.V1 || OurRobot.V5!=OurRobot.V6){/*IntAndFloat();*/}
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V2>=OurRobot.V6){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V5>=OurRobot.V3 || OurRobot.V5>OurRobot.V6){if(OurRobot.V3<OurRobot.V5){if(OurRobot.V1<OurRobot.V4){/*IntAndFloat();*/}}}
/*Example();*/
if(OurRobot.V4<OurRobot.V6 && OurRobot.V6<=OurRobot.V1){if(OurRobot.V0>OurRobot.V6 || OurRobot.V1>OurRobot.V3 || OurRobot.V6==OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
while(OurRobot.V4>OurRobot.V5){/*IntAndFloat();*/}
if(OurRobot.V6>OurRobot.V1){while(OurRobot.V4==OurRobot.V6 || OurRobot.V4<OurRobot.V6 || OurRobot.V2<=OurRobot.V6){/*IntAndFloat();*/}}
while(OurRobot.V2>=OurRobot.V0 && OurRobot.V6<OurRobot.V0 || OurRobot.V1==OurRobot.V4 && OurRobot.V3>=OurRobot.V6){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V6!=OurRobot.V1){/*IntAndFloat();*/}
/*Example();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V6>=OurRobot.V2 && OurRobot.V1<OurRobot.V5){while(OurRobot.V6<OurRobot.V2 && OurRobot.V1==OurRobot.V0){/*IntAndFloat();*/}}
if(OurRobot.V4<OurRobot.V0 && OurRobot.V5<=OurRobot.V6 && OurRobot.V0==OurRobot.V6 && OurRobot.V3==OurRobot.V6){/*CircularTargetFire();*/}
while(OurRobot.V2<OurRobot.V0 || OurRobot.V1!=OurRobot.V0){if(OurRobot.V2>=OurRobot.V0 && OurRobot.V3>OurRobot.V0 && OurRobot.V4>=OurRobot.V3 && OurRobot.V0==OurRobot.V4){/*IntAndFloat();*/}}
/*Example();*/
		}

		public override void ExitState()
		{
			
		}
	}
}