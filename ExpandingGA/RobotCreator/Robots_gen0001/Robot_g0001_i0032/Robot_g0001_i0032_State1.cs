using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0032 OurRobot { get; set; }
		public State1 (Robot_g0001_i0032 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V2>OurRobot.V3)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(60, 69, 150);
			
if(OurRobot.V2==OurRobot.V4 && OurRobot.V1>OurRobot.V4){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*Example();*/
		}

		public override void DoStateAction()
		{
			
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V4!=OurRobot.V2){/*CircularTargetFire();*/}
if(OurRobot.V2==OurRobot.V3 || OurRobot.V3<=OurRobot.V2 || OurRobot.V1==OurRobot.V0 || OurRobot.V2<OurRobot.V1){while(OurRobot.V0==OurRobot.V1 && OurRobot.V0>OurRobot.V2 || OurRobot.V2<OurRobot.V0){/*IntAndFloat();*/}}
if(OurRobot.V1==OurRobot.V3){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*Example();*/
while(OurRobot.V4>OurRobot.V2 && OurRobot.V2<OurRobot.V1){while(OurRobot.V4!=OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*IntAndFloat();*/
/*Example();*/
/*IntAndFloat();*/
while(OurRobot.V4<=OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
if(OurRobot.V4>=OurRobot.V3){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V3<=OurRobot.V0){while(OurRobot.V4<=OurRobot.V1){/*IntAndFloat();*/}}
if(OurRobot.V4<=OurRobot.V0){/*IntAndFloat();*/}
		}

		public override void ExitState()
		{
			
while(OurRobot.V0<=OurRobot.V1 || OurRobot.V3<OurRobot.V2){/*IntAndFloat();*/}
if(OurRobot.V0!=OurRobot.V4){/*CircularTargetFire();*/}
if(OurRobot.V3>=OurRobot.V2 || OurRobot.V2==OurRobot.V4 && OurRobot.V3<=OurRobot.V0){/*IntAndFloat();*/}
/*Example();*/
/*IntAndFloat();*/
while(OurRobot.V3>OurRobot.V2 && OurRobot.V0>OurRobot.V1 && OurRobot.V4>OurRobot.V1 && OurRobot.V1>OurRobot.V3){/*CircularTargetFire();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
		}
	}
}