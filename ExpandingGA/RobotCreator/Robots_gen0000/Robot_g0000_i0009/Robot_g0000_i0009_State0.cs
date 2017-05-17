using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0009 OurRobot { get; set; }
		public State0 (Robot_g0000_i0009 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V1!=OurRobot.V3)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(114, 216, 245);
			
if(OurRobot.V0>=OurRobot.V1 && OurRobot.V5>=OurRobot.V4 || OurRobot.V1!=OurRobot.V5){/*IntAndFloat(-1,-1.0f);*/}
/*Example();*/
/*IntAndFloat();*/
/*Example();*/
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V2<OurRobot.V4 && OurRobot.V4==OurRobot.V3 && OurRobot.V5==OurRobot.V3 || OurRobot.V0<OurRobot.V5){/*IntAndFloat();*/}
if(OurRobot.V3==OurRobot.V2){/*CircularTargetFire();*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V1==OurRobot.V2 || OurRobot.V4<OurRobot.V5 || OurRobot.V2<OurRobot.V5){while(OurRobot.V1<=OurRobot.V2){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V1>=OurRobot.V2){/*Example();*/}
/*Example();*/
if(OurRobot.V4<OurRobot.V5){if(OurRobot.V2==OurRobot.V1){/*IntAndFloat();*/}}
if(OurRobot.V0>=OurRobot.V4){if(OurRobot.V0==OurRobot.V3 && OurRobot.V5!=OurRobot.V2){if(OurRobot.V5>=OurRobot.V2){/*IntAndFloat();*/}}}
		}

		public override void ExitState()
		{
			
if(OurRobot.V4>OurRobot.V5 && OurRobot.V5>=OurRobot.V3){if(OurRobot.V3<=OurRobot.V4 && OurRobot.V2>=OurRobot.V0){/*CircularTargetFire();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V1<OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
while(OurRobot.V2!=OurRobot.V1 || OurRobot.V1!=OurRobot.V4){while(OurRobot.V1>OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V2<OurRobot.V3){if(OurRobot.V0>OurRobot.V2){/*IntAndFloat();*/}}
while(OurRobot.V0!=OurRobot.V3){/*IntAndFloat();*/}
/*IntAndFloat();*/
if(OurRobot.V3!=OurRobot.V2 || OurRobot.V2==OurRobot.V1 || OurRobot.V0!=OurRobot.V1 || OurRobot.V2<OurRobot.V3){/*IntAndFloat();*/}
/*IntAndFloat();*/
		}
	}
}