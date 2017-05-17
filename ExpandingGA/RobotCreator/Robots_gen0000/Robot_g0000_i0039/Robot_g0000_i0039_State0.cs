using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0039 OurRobot { get; set; }
		public State0 (Robot_g0000_i0039 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V5!=OurRobot.V4 || OurRobot.V3!=OurRobot.V0 || OurRobot.V1>OurRobot.V0)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(38, 184, 187);
			
/*IntAndFloat(30,-1.0f);*/
if(OurRobot.V3!=OurRobot.V0){if(OurRobot.V3>=OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
if(OurRobot.V1>=OurRobot.V4){if(OurRobot.V3>OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
if(OurRobot.V1>=OurRobot.V3 && OurRobot.V2>=OurRobot.V0 && OurRobot.V1<=OurRobot.V5){/*IntAndFloat();*/}
while(OurRobot.V2==OurRobot.V1 && OurRobot.V1>=OurRobot.V4){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V2>=OurRobot.V0 && OurRobot.V1>=OurRobot.V4){if(OurRobot.V5>OurRobot.V1){/*IntAndFloat();*/}}
while(OurRobot.V1==OurRobot.V2 && OurRobot.V0<=OurRobot.V3 || OurRobot.V0>=OurRobot.V1 || OurRobot.V0<OurRobot.V3){/*IntAndFloat();*/}
while(OurRobot.V2>OurRobot.V0 && OurRobot.V0==OurRobot.V1 || OurRobot.V2>OurRobot.V3 || OurRobot.V2>OurRobot.V4){while(OurRobot.V2!=OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
while(OurRobot.V5<=OurRobot.V4 || OurRobot.V0<OurRobot.V2){/*Example();*/}
/*IntAndFloat();*/
if(OurRobot.V3<OurRobot.V5){if(OurRobot.V3!=OurRobot.V4 || OurRobot.V0==OurRobot.V5){/*CircularTargetFire();*/}}
while(OurRobot.V1>=OurRobot.V4 || OurRobot.V4==OurRobot.V5 || OurRobot.V2<OurRobot.V0 && OurRobot.V4<OurRobot.V2){if(OurRobot.V1>=OurRobot.V5){if(OurRobot.V4<OurRobot.V5 && OurRobot.V4>OurRobot.V1){/*IntAndFloat();*/}}}
if(OurRobot.V1<=OurRobot.V5){/*Example();*/}
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V0<=OurRobot.V5){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*Example();*/
while(OurRobot.V4>=OurRobot.V1){/*IntAndFloat();*/}
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
while(OurRobot.V1>OurRobot.V0){if(OurRobot.V2<=OurRobot.V5){/*Example();*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V5!=OurRobot.V4){if(OurRobot.V2!=OurRobot.V4 || OurRobot.V1!=OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
		}
	}
}