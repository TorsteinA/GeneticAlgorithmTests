using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0017 OurRobot { get; set; }
		public State1 (Robot_g0001_i0017 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V5<OurRobot.V6)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(98, 72, 89);
			
while(OurRobot.V1>=OurRobot.V5){while(OurRobot.V5>=OurRobot.V1 || OurRobot.V4==OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
if(OurRobot.V4!=OurRobot.V0 && OurRobot.V5==OurRobot.V0 || OurRobot.V2<OurRobot.V4 || OurRobot.V0>=OurRobot.V6){if(OurRobot.V6!=OurRobot.V1){/*IntAndFloat();*/}}
if(OurRobot.V5!=OurRobot.V4 && OurRobot.V1>=OurRobot.V4){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*Example();*/
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V4<OurRobot.V6 && OurRobot.V6==OurRobot.V0 && OurRobot.V4>OurRobot.V0 || OurRobot.V5>=OurRobot.V3){/*Example();*/}
/*IntAndFloat();*/
while(OurRobot.V5==OurRobot.V1){while(OurRobot.V6<=OurRobot.V5){/*IntAndFloat();*/}}
while(OurRobot.V2!=OurRobot.V6 && OurRobot.V0!=OurRobot.V1){while(OurRobot.V0!=OurRobot.V1 || OurRobot.V0<OurRobot.V6){if(OurRobot.V6<OurRobot.V0 || OurRobot.V2==OurRobot.V5 || OurRobot.V5==OurRobot.V4 && OurRobot.V5>=OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*Example();*/
if(OurRobot.V0>=OurRobot.V3 || OurRobot.V2<=OurRobot.V3){while(OurRobot.V6!=OurRobot.V4){/*IntAndFloat();*/}}
if(OurRobot.V2>OurRobot.V5){while(OurRobot.V5<=OurRobot.V4){if(OurRobot.V4!=OurRobot.V1){/*IntAndFloat();*/}}}
/*Example();*/
/*IntAndFloat();*/
if(OurRobot.V4!=OurRobot.V3 || OurRobot.V1>=OurRobot.V6 || OurRobot.V5>=OurRobot.V4){while(OurRobot.V0<OurRobot.V6){if(OurRobot.V3<=OurRobot.V5){/*IntAndFloat();*/}}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V5>=OurRobot.V6){if(OurRobot.V0!=OurRobot.V1){/*Example();*/}}
while(OurRobot.V3==OurRobot.V2){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*IntAndFloat();*/
/*Example();*/
		}

		public override void ExitState()
		{
			
		}
	}
}