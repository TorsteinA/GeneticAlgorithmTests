using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0039 OurRobot { get; set; }
		public State1 (Robot_g0001_i0039 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V1==OurRobot.V3)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(107, 42, 239);
			
if(OurRobot.V1>=OurRobot.V4 || OurRobot.V0==OurRobot.V4){while(OurRobot.V0<=OurRobot.V4){/*IntAndFloat();*/}}
while(OurRobot.V2>=OurRobot.V0 || OurRobot.V2!=OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
while(OurRobot.V5<=OurRobot.V4 || OurRobot.V0<OurRobot.V2){/*Example();*/}
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V4!=OurRobot.V5 || OurRobot.V3>OurRobot.V1 || OurRobot.V3>OurRobot.V1){if(OurRobot.V0<=OurRobot.V4 && OurRobot.V1>OurRobot.V0){if(OurRobot.V0==OurRobot.V5){/*IntAndFloat();*/}}}
if(OurRobot.V2>OurRobot.V0){if(OurRobot.V4<=OurRobot.V3){/*IntAndFloat();*/}}
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V4==OurRobot.V0){while(OurRobot.V4!=OurRobot.V2 && OurRobot.V4<=OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
		}
	}
}