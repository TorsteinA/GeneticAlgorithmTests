using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0038 OurRobot { get; set; }
		public State1 (Robot_g0000_i0038 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V5==OurRobot.V2 || OurRobot.V2<=OurRobot.V0 && OurRobot.V3!=OurRobot.V2)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(235, 248, 210);
			
/*IntAndFloat();*/
if(OurRobot.V2>OurRobot.V0 && OurRobot.V0>OurRobot.V4 || OurRobot.V4<=OurRobot.V5 && OurRobot.V0!=OurRobot.V3){while(OurRobot.V0!=OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*CircularTargetFire();*/
while(OurRobot.V0<OurRobot.V5 || OurRobot.V2!=OurRobot.V5 || OurRobot.V0>=OurRobot.V1 || OurRobot.V1!=OurRobot.V2){/*IntAndFloat();*/}
if(OurRobot.V0==OurRobot.V4 || OurRobot.V3>OurRobot.V4 || OurRobot.V2>=OurRobot.V0){/*Example();*/}
if(OurRobot.V3<OurRobot.V0 && OurRobot.V0==OurRobot.V5 || OurRobot.V2>OurRobot.V4 || OurRobot.V2>=OurRobot.V3){if(OurRobot.V1<=OurRobot.V0 || OurRobot.V1!=OurRobot.V0 || OurRobot.V3<OurRobot.V2){/*IntAndFloat();*/}}
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V0<OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
if(OurRobot.V3<=OurRobot.V2){while(OurRobot.V1!=OurRobot.V5){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
		}
	}
}