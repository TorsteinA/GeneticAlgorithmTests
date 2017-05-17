using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0028 OurRobot { get; set; }
		public State0 (Robot_g0000_i0028 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V3>=OurRobot.V0 || OurRobot.V2>=OurRobot.V4)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(59, 35, 24);
			
/*Example();*/
if(OurRobot.V1<=OurRobot.V2){if(OurRobot.V1!=OurRobot.V4){/*IntAndFloat(-1,-1.0f);*/}}
/*CircularTargetFire();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V0>=OurRobot.V5){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V3!=OurRobot.V0 && OurRobot.V1<OurRobot.V2 || OurRobot.V0>=OurRobot.V3){if(OurRobot.V3==OurRobot.V2){/*IntAndFloat();*/}}
while(OurRobot.V0<=OurRobot.V3){if(OurRobot.V0!=OurRobot.V5 && OurRobot.V1>OurRobot.V2 && OurRobot.V2>=OurRobot.V0 && OurRobot.V1<=OurRobot.V0){/*IntAndFloat();*/}}
while(OurRobot.V5>=OurRobot.V2){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
if(OurRobot.V4!=OurRobot.V2){while(OurRobot.V1!=OurRobot.V0){if(OurRobot.V5!=OurRobot.V2 || OurRobot.V1!=OurRobot.V2 && OurRobot.V4<OurRobot.V3 && OurRobot.V4<=OurRobot.V5){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V1<OurRobot.V3 || OurRobot.V5<OurRobot.V1){if(OurRobot.V1>OurRobot.V4){/*IntAndFloat();*/}}
/*Example();*/
		}

		public override void ExitState()
		{
			
while(OurRobot.V0>=OurRobot.V1){/*IntAndFloat();*/}
while(OurRobot.V3!=OurRobot.V0 || OurRobot.V0<OurRobot.V1){/*IntAndFloat();*/}
if(OurRobot.V1>OurRobot.V5){/*Example();*/}
while(OurRobot.V3==OurRobot.V1 || OurRobot.V4>OurRobot.V2){/*Example();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*Example();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
if(OurRobot.V4<OurRobot.V0 || OurRobot.V3==OurRobot.V2 && OurRobot.V1<OurRobot.V5 && OurRobot.V4>=OurRobot.V1){/*Example();*/}
		}
	}
}