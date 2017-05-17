using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0019 OurRobot { get; set; }
		public State1 (Robot_g0001_i0019 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V0==OurRobot.V5)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(55, 99, 56);
			
while(OurRobot.V4>=OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
		}

		public override void DoStateAction()
		{
			
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
/*Example();*/
/*IntAndFloat();*/
if(OurRobot.V1!=OurRobot.V3 || OurRobot.V5!=OurRobot.V3 && OurRobot.V5==OurRobot.V2){/*IntAndFloat();*/}
if(OurRobot.V0==OurRobot.V5){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
while(OurRobot.V0!=OurRobot.V4 || OurRobot.V2!=OurRobot.V0){while(OurRobot.V0>OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*CircularTargetFire();*/
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V1<=OurRobot.V0 && OurRobot.V1>=OurRobot.V2){/*IntAndFloat();*/}
while(OurRobot.V1!=OurRobot.V3 && OurRobot.V0!=OurRobot.V1){/*CircularTargetFire();*/}
if(OurRobot.V5<OurRobot.V3 && OurRobot.V3<=OurRobot.V0 || OurRobot.V1>=OurRobot.V2 && OurRobot.V2>=OurRobot.V0){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*IntAndFloat();*/
if(OurRobot.V3!=OurRobot.V0){/*CircularTargetFire();*/}
		}
	}
}