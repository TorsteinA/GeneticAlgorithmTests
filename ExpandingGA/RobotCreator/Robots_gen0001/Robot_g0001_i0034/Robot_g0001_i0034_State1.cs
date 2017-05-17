using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0034 OurRobot { get; set; }
		public State1 (Robot_g0001_i0034 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V1==OurRobot.V0 && OurRobot.V4!=OurRobot.V1 || OurRobot.V1!=OurRobot.V0 && OurRobot.V1<OurRobot.V2)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(203, 167, 67);
			
while(OurRobot.V1!=OurRobot.V3 || OurRobot.V2<OurRobot.V0 || OurRobot.V4!=OurRobot.V2){/*Example();*/}
if(OurRobot.V2<OurRobot.V3){if(OurRobot.V3>OurRobot.V4){if(OurRobot.V0>=OurRobot.V1 || OurRobot.V4>OurRobot.V3){/*IntAndFloat();*/}}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
		}

		public override void DoStateAction()
		{
			
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V1<=OurRobot.V3){/*Example();*/}
/*IntAndFloat();*/
while(OurRobot.V0<=OurRobot.V3 && OurRobot.V3<OurRobot.V1 || OurRobot.V1==OurRobot.V0){/*CircularTargetFire();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V3==OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
while(OurRobot.V2>=OurRobot.V3 || OurRobot.V1>=OurRobot.V4 || OurRobot.V3<OurRobot.V1){if(OurRobot.V4!=OurRobot.V2 || OurRobot.V0!=OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
if(OurRobot.V3!=OurRobot.V1 && OurRobot.V0<OurRobot.V3 && OurRobot.V2>OurRobot.V3){/*Example();*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
if(OurRobot.V3!=OurRobot.V1 && OurRobot.V2>OurRobot.V0){if(OurRobot.V3<OurRobot.V2){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
		}
	}
}