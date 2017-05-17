using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0034 OurRobot { get; set; }
		public State0 (Robot_g0001_i0034 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V0<=OurRobot.V4)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(12, 137, 173);
			
/*Example();*/
if(OurRobot.V4<=OurRobot.V3 && OurRobot.V3>OurRobot.V4){/*IntAndFloat(-28,-1.0f);*/}
while(OurRobot.V2>=OurRobot.V0 || OurRobot.V4==OurRobot.V3){/*Example();*/}
if(OurRobot.V4!=OurRobot.V0 || OurRobot.V0<=OurRobot.V1){if(OurRobot.V1<OurRobot.V2){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*IntAndFloat();*/
		}

		public override void DoStateAction()
		{
			
/*IntAndFloat();*/
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V0!=OurRobot.V2){/*IntAndFloat();*/}
/*IntAndFloat();*/
if(OurRobot.V2>OurRobot.V0 && OurRobot.V2<=OurRobot.V1 || OurRobot.V4>=OurRobot.V3){/*IntAndFloat();*/}
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V4!=OurRobot.V2){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*IntAndFloat();*/
while(OurRobot.V2>=OurRobot.V3 && OurRobot.V0>=OurRobot.V1 || OurRobot.V3>OurRobot.V0 || OurRobot.V0<OurRobot.V2){if(OurRobot.V0<OurRobot.V4){/*IntAndFloat();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
		}
	}
}