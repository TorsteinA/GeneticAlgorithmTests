using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0006 OurRobot { get; set; }
		public State1 (Robot_g0001_i0006 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V3<OurRobot.V5)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(40, 126, 157);
			
if(OurRobot.V3>OurRobot.V5){/*CircularTargetFire();*/}
/*IntAndFloat();*/
/*Example();*/
while(OurRobot.V5!=OurRobot.V4 || OurRobot.V0<=OurRobot.V1){if(OurRobot.V5<=OurRobot.V3 && OurRobot.V0>=OurRobot.V5){if(OurRobot.V1==OurRobot.V5 && OurRobot.V4<OurRobot.V1){/*IntAndFloat();*/}}}
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V5==OurRobot.V3 && OurRobot.V5!=OurRobot.V4){while(OurRobot.V0!=OurRobot.V2){if(OurRobot.V1<=OurRobot.V3 || OurRobot.V3==OurRobot.V0){/*IntAndFloat();*/}}}
/*IntAndFloat();*/
if(OurRobot.V0<OurRobot.V1){if(OurRobot.V2>OurRobot.V0 && OurRobot.V2<=OurRobot.V5){/*IntAndFloat();*/}}
if(OurRobot.V5>OurRobot.V2 && OurRobot.V1>OurRobot.V2){while(OurRobot.V5>=OurRobot.V3 || OurRobot.V0<OurRobot.V5){/*IntAndFloat();*/}}
/*Example();*/
if(OurRobot.V1==OurRobot.V2 && OurRobot.V3>OurRobot.V0){/*CircularTargetFire();*/}
while(OurRobot.V4<=OurRobot.V5 || OurRobot.V1>OurRobot.V2){/*IntAndFloat();*/}
while(OurRobot.V4<OurRobot.V5){if(OurRobot.V1==OurRobot.V3 || OurRobot.V5>OurRobot.V0){if(OurRobot.V1==OurRobot.V5 && OurRobot.V4==OurRobot.V5){/*IntAndFloat();*/}}}
/*IntAndFloat();*/
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V0==OurRobot.V2){/*IntAndFloat();*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V5==OurRobot.V1 && OurRobot.V5>=OurRobot.V0 || OurRobot.V0>=OurRobot.V4 && OurRobot.V4>OurRobot.V2){/*CircularTargetFire();*/}
if(OurRobot.V0>=OurRobot.V4 || OurRobot.V1>=OurRobot.V3){while(OurRobot.V2>=OurRobot.V0){if(OurRobot.V1<OurRobot.V2){/*IntAndFloat();*/}}}
		}

		public override void ExitState()
		{
			
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V5>=OurRobot.V1 || OurRobot.V3==OurRobot.V2){while(OurRobot.V1<=OurRobot.V5){/*IntAndFloat();*/}}
/*IntAndFloat();*/
while(OurRobot.V4>OurRobot.V2){/*Example();*/}
/*Example();*/
/*CircularTargetFire();*/
while(OurRobot.V5<=OurRobot.V4){/*Example();*/}
if(OurRobot.V2<OurRobot.V4 || OurRobot.V0>=OurRobot.V3 || OurRobot.V1>=OurRobot.V0 || OurRobot.V4<OurRobot.V1){while(OurRobot.V0<=OurRobot.V5 && OurRobot.V3>=OurRobot.V0 && OurRobot.V2<OurRobot.V3 && OurRobot.V0!=OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
if(OurRobot.V0!=OurRobot.V2 && OurRobot.V2==OurRobot.V0){if(OurRobot.V2<OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*IntAndFloat();*/
while(OurRobot.V5>OurRobot.V1 || OurRobot.V5==OurRobot.V2 || OurRobot.V1==OurRobot.V4){while(OurRobot.V2==OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*IntAndFloat();*/
		}
	}
}