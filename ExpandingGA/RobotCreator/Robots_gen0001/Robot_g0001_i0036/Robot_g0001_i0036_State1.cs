using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0036 OurRobot { get; set; }
		public State1 (Robot_g0001_i0036 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V0>OurRobot.V3)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(74, 99, 113);
			
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V5==OurRobot.V0){/*IntAndFloat();*/}
while(OurRobot.V5<=OurRobot.V6 || OurRobot.V2!=OurRobot.V4){/*IntAndFloat();*/}
while(OurRobot.V3!=OurRobot.V0){if(OurRobot.V3>OurRobot.V7){/*IntAndFloat();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*Example();*/
if(OurRobot.V1<=OurRobot.V0 && OurRobot.V4!=OurRobot.V2){while(OurRobot.V5<=OurRobot.V2 || OurRobot.V1<OurRobot.V6 && OurRobot.V7<OurRobot.V3){/*Example();*/}}
		}

		public override void ExitState()
		{
			
while(OurRobot.V3>OurRobot.V4){while(OurRobot.V1==OurRobot.V5){/*Example();*/}}
if(OurRobot.V0==OurRobot.V4){if(OurRobot.V6<OurRobot.V2 || OurRobot.V5>=OurRobot.V4 && OurRobot.V4>OurRobot.V3 && OurRobot.V4<=OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
if(OurRobot.V5==OurRobot.V7){while(OurRobot.V5>OurRobot.V7 || OurRobot.V0>OurRobot.V4){/*IntAndFloat();*/}}
if(OurRobot.V1<OurRobot.V3 || OurRobot.V4==OurRobot.V0){while(OurRobot.V0==OurRobot.V7){if(OurRobot.V1!=OurRobot.V5){/*IntAndFloat();*/}}}
if(OurRobot.V3>=OurRobot.V5 || OurRobot.V4<=OurRobot.V2 && OurRobot.V0!=OurRobot.V2 || OurRobot.V1>OurRobot.V5){while(OurRobot.V6<=OurRobot.V7 || OurRobot.V6==OurRobot.V5 || OurRobot.V2>OurRobot.V1 && OurRobot.V7>=OurRobot.V5){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
if(OurRobot.V5<=OurRobot.V0 && OurRobot.V4<=OurRobot.V5 || OurRobot.V2!=OurRobot.V4 && OurRobot.V0>OurRobot.V3){/*IntAndFloat();*/}
/*Example();*/
if(OurRobot.V0<OurRobot.V2 && OurRobot.V0<OurRobot.V3){/*CircularTargetFire();*/}
while(OurRobot.V4<OurRobot.V6){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*CircularTargetFire();*/
if(OurRobot.V4>OurRobot.V1 || OurRobot.V3==OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*IntAndFloat();*/
		}
	}
}