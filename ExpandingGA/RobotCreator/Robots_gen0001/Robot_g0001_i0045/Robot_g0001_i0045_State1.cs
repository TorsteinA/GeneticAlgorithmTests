using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0045 OurRobot { get; set; }
		public State1 (Robot_g0001_i0045 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V2==OurRobot.V0 || OurRobot.V4<OurRobot.V0 || OurRobot.V2>=OurRobot.V4)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(28, 30, 92);
			
/*Example();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V4>OurRobot.V0 || OurRobot.V1<OurRobot.V4 || OurRobot.V6==OurRobot.V4){/*IntAndFloat();*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V6<=OurRobot.V0){if(OurRobot.V5>=OurRobot.V2 || OurRobot.V6==OurRobot.V0 && OurRobot.V6!=OurRobot.V5 || OurRobot.V7>=OurRobot.V2){/*IntAndFloat();*/}}
		}

		public override void DoStateAction()
		{
			
/*CircularTargetFire();*/
if(OurRobot.V6!=OurRobot.V3 || OurRobot.V0==OurRobot.V3){if(OurRobot.V0<OurRobot.V2 && OurRobot.V5>=OurRobot.V4 || OurRobot.V6!=OurRobot.V1 && OurRobot.V3>=OurRobot.V7){if(OurRobot.V2<=OurRobot.V6 || OurRobot.V5==OurRobot.V7 && OurRobot.V6==OurRobot.V3 && OurRobot.V5>OurRobot.V4){/*IntAndFloat();*/}}}
while(OurRobot.V4>OurRobot.V3){if(OurRobot.V5==OurRobot.V0){/*IntAndFloat();*/}}
if(OurRobot.V1<=OurRobot.V3 || OurRobot.V2<OurRobot.V4){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V2>OurRobot.V3){if(OurRobot.V0==OurRobot.V6){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V0>OurRobot.V2 || OurRobot.V3==OurRobot.V0){while(OurRobot.V2!=OurRobot.V4 || OurRobot.V5==OurRobot.V2 || OurRobot.V4<OurRobot.V3 || OurRobot.V2<OurRobot.V4){if(OurRobot.V3<=OurRobot.V0 && OurRobot.V6>OurRobot.V3 || OurRobot.V5>=OurRobot.V6 || OurRobot.V4>OurRobot.V5){/*CircularTargetFire();*/}}}
		}

		public override void ExitState()
		{
			
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V6>=OurRobot.V0 || OurRobot.V0!=OurRobot.V5 && OurRobot.V3!=OurRobot.V0 || OurRobot.V5!=OurRobot.V1){/*IntAndFloat();*/}
if(OurRobot.V7==OurRobot.V3){/*IntAndFloat();*/}
if(OurRobot.V5>=OurRobot.V0 || OurRobot.V4>OurRobot.V7 || OurRobot.V0<=OurRobot.V2){if(OurRobot.V4<OurRobot.V1){/*Example();*/}}
		}
	}
}