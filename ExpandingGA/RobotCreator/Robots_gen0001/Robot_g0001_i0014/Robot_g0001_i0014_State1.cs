using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0014 OurRobot { get; set; }
		public State1 (Robot_g0001_i0014 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V3>=OurRobot.V0)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(75, 255, 31);
			
if(OurRobot.V0>=OurRobot.V3){/*IntAndFloat();*/}
while(OurRobot.V4<OurRobot.V1){if(OurRobot.V0>=OurRobot.V3 || OurRobot.V5!=OurRobot.V2){/*Example();*/}}
/*Example();*/
if(OurRobot.V0<=OurRobot.V3 || OurRobot.V5>=OurRobot.V3 && OurRobot.V2<=OurRobot.V1){while(OurRobot.V0==OurRobot.V5){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V5<OurRobot.V2 && OurRobot.V5<=OurRobot.V2 || OurRobot.V0>=OurRobot.V4){if(OurRobot.V1>OurRobot.V0 && OurRobot.V0==OurRobot.V4){/*Example();*/}}
while(OurRobot.V1>=OurRobot.V5){while(OurRobot.V2<OurRobot.V3 && OurRobot.V3<OurRobot.V1 || OurRobot.V1<=OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
if(OurRobot.V5<OurRobot.V1 || OurRobot.V1!=OurRobot.V4 || OurRobot.V4!=OurRobot.V0){if(OurRobot.V0==OurRobot.V2){/*IntAndFloat();*/}}
if(OurRobot.V0>=OurRobot.V3 && OurRobot.V2>OurRobot.V3){if(OurRobot.V4<OurRobot.V5 || OurRobot.V5==OurRobot.V2 && OurRobot.V5!=OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
if(OurRobot.V1>OurRobot.V0){if(OurRobot.V1<=OurRobot.V0 && OurRobot.V5==OurRobot.V3 || OurRobot.V3>=OurRobot.V4 || OurRobot.V0>=OurRobot.V4){/*IntAndFloat();*/}}
/*IntAndFloat();*/
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V2==OurRobot.V0 && OurRobot.V3<OurRobot.V1 && OurRobot.V2>=OurRobot.V1 || OurRobot.V4==OurRobot.V0){/*CircularTargetFire();*/}
if(OurRobot.V2>=OurRobot.V4){if(OurRobot.V2<OurRobot.V0 && OurRobot.V3>=OurRobot.V0){/*IntAndFloat();*/}}
/*IntAndFloat();*/
while(OurRobot.V3!=OurRobot.V4 || OurRobot.V4!=OurRobot.V2 || OurRobot.V4>OurRobot.V3){while(OurRobot.V3!=OurRobot.V4 || OurRobot.V0<OurRobot.V5){if(OurRobot.V3>OurRobot.V2 && OurRobot.V2<OurRobot.V4 || OurRobot.V2!=OurRobot.V1 && OurRobot.V3<OurRobot.V4){/*CircularTargetFire();*/}}}
if(OurRobot.V5>OurRobot.V0){if(OurRobot.V2<OurRobot.V1){/*Example();*/}}
/*IntAndFloat();*/
while(OurRobot.V1>=OurRobot.V0 || OurRobot.V2!=OurRobot.V4 && OurRobot.V2==OurRobot.V0){/*CircularTargetFire();*/}
if(OurRobot.V1<OurRobot.V2 && OurRobot.V1<=OurRobot.V5){/*IntAndFloat();*/}
if(OurRobot.V0!=OurRobot.V3){while(OurRobot.V5!=OurRobot.V4 || OurRobot.V1!=OurRobot.V3 || OurRobot.V0!=OurRobot.V1){/*IntAndFloat();*/}}
while(OurRobot.V3>=OurRobot.V2 && OurRobot.V2>OurRobot.V5){if(OurRobot.V2>OurRobot.V1){if(OurRobot.V1!=OurRobot.V2){/*CircularTargetFire();*/}}}
while(OurRobot.V1!=OurRobot.V3 || OurRobot.V0==OurRobot.V5 || OurRobot.V0>OurRobot.V4 && OurRobot.V1>=OurRobot.V0){while(OurRobot.V0>=OurRobot.V3){if(OurRobot.V3<=OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*CircularTargetFire();*/
/*IntAndFloat();*/
if(OurRobot.V3!=OurRobot.V0){if(OurRobot.V4>=OurRobot.V5 || OurRobot.V0>OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
if(OurRobot.V4<OurRobot.V0){/*Example();*/}
		}

		public override void ExitState()
		{
			
while(OurRobot.V2==OurRobot.V5 && OurRobot.V5!=OurRobot.V0 && OurRobot.V0<OurRobot.V1 || OurRobot.V5>OurRobot.V4){/*IntAndFloat();*/}
/*Example();*/
		}
	}
}