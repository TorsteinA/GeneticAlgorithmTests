using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0027 OurRobot { get; set; }
		public State1 (Robot_g0000_i0027 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V2==OurRobot.V1)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(221, 115, 22);
			
if(OurRobot.V3>=OurRobot.V1 && OurRobot.V1!=OurRobot.V3){if(OurRobot.V5!=OurRobot.V0){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
while(OurRobot.V1<=OurRobot.V2){while(OurRobot.V6<OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V0!=OurRobot.V6){if(OurRobot.V6<OurRobot.V5 || OurRobot.V2<=OurRobot.V1){/*IntAndFloat();*/}}
/*Example();*/
if(OurRobot.V0==OurRobot.V2 && OurRobot.V2==OurRobot.V0 || OurRobot.V1<=OurRobot.V5 || OurRobot.V1>OurRobot.V4){while(OurRobot.V2==OurRobot.V1 || OurRobot.V4<OurRobot.V5){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V5!=OurRobot.V6 && OurRobot.V2>=OurRobot.V0 || OurRobot.V3<OurRobot.V5){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
if(OurRobot.V3!=OurRobot.V6){while(OurRobot.V3<=OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
		}

		public override void ExitState()
		{
			
/*Example();*/
		}
	}
}