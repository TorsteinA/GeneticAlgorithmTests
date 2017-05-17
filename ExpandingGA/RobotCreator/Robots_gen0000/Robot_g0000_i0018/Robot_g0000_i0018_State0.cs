using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0018 OurRobot { get; set; }
		public State0 (Robot_g0000_i0018 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V1>OurRobot.V7)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(58, 42, 35);
			
if(OurRobot.V2<=OurRobot.V7 || OurRobot.V5>=OurRobot.V1){while(OurRobot.V6!=OurRobot.V5){/*IntAndFloat(-1,-1.0f);*/}}
while(OurRobot.V3<OurRobot.V1){/*IntAndFloat();*/}
while(OurRobot.V6>=OurRobot.V3 && OurRobot.V6==OurRobot.V4){while(OurRobot.V0<=OurRobot.V4 || OurRobot.V6>OurRobot.V4){/*IntAndFloat();*/}}
/*IntAndFloat();*/
if(OurRobot.V6>=OurRobot.V2){if(OurRobot.V1==OurRobot.V7){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*Example();*/
if(OurRobot.V6>OurRobot.V4 && OurRobot.V1!=OurRobot.V7 || OurRobot.V6>=OurRobot.V7){while(OurRobot.V6==OurRobot.V0 && OurRobot.V0<=OurRobot.V1){/*Example();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V7!=OurRobot.V6 || OurRobot.V2!=OurRobot.V5 && OurRobot.V2==OurRobot.V4 && OurRobot.V0==OurRobot.V1){/*Example();*/}
if(OurRobot.V4>OurRobot.V5){while(OurRobot.V1>=OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
while(OurRobot.V3<OurRobot.V1){/*IntAndFloat();*/}
while(OurRobot.V4>OurRobot.V6){/*CircularTargetFire();*/}
if(OurRobot.V6<=OurRobot.V4){/*IntAndFloat();*/}
if(OurRobot.V0<OurRobot.V6 && OurRobot.V1<=OurRobot.V6 || OurRobot.V0!=OurRobot.V4 || OurRobot.V6>OurRobot.V1){/*IntAndFloat();*/}
if(OurRobot.V0<=OurRobot.V3){/*IntAndFloat();*/}
/*IntAndFloat();*/
while(OurRobot.V0<OurRobot.V7 && OurRobot.V1>=OurRobot.V7){while(OurRobot.V4<OurRobot.V3){/*CircularTargetFire();*/}}
/*Example();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V3<OurRobot.V2 && OurRobot.V1>=OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*Example();*/
		}
	}
}