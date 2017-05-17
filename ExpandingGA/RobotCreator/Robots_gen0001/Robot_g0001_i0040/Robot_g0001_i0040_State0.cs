using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0040 OurRobot { get; set; }
		public State0 (Robot_g0001_i0040 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V1<OurRobot.V5 && OurRobot.V2<OurRobot.V6)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(43, 6, 94);
			
while(OurRobot.V5==OurRobot.V6){if(OurRobot.V5<OurRobot.V1){if(OurRobot.V3<OurRobot.V4){/*IntAndFloat(-1,-1.0f);*/}}}
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V3!=OurRobot.V6){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
if(OurRobot.V2>=OurRobot.V3){/*CircularTargetFire();*/}
/*Example();*/
while(OurRobot.V0>=OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
while(OurRobot.V5>=OurRobot.V4){if(OurRobot.V1!=OurRobot.V3 && OurRobot.V3==OurRobot.V0){/*IntAndFloat();*/}}
/*IntAndFloat();*/
		}

		public override void DoStateAction()
		{
			
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V4<=OurRobot.V2){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
if(OurRobot.V1>OurRobot.V6){while(OurRobot.V4>OurRobot.V0){if(OurRobot.V3>OurRobot.V1 && OurRobot.V1==OurRobot.V6){/*Example();*/}}}
if(OurRobot.V6<=OurRobot.V5){if(OurRobot.V4!=OurRobot.V2){if(OurRobot.V3<OurRobot.V5 || OurRobot.V6>=OurRobot.V5){/*CircularTargetFire();*/}}}
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
while(OurRobot.V5>=OurRobot.V3 && OurRobot.V3>OurRobot.V2 && OurRobot.V0>=OurRobot.V4 || OurRobot.V6!=OurRobot.V0){/*CircularTargetFire();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V2!=OurRobot.V6 || OurRobot.V0<OurRobot.V5){/*Example();*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
		}
	}
}