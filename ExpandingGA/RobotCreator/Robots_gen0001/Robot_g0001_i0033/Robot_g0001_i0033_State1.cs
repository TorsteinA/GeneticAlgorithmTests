using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0033 OurRobot { get; set; }
		public State1 (Robot_g0001_i0033 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V2==OurRobot.V4)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(33, 229, 163);
			
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V4<=OurRobot.V3 && OurRobot.V5==OurRobot.V6 && OurRobot.V3!=OurRobot.V1 && OurRobot.V6!=OurRobot.V7){if(OurRobot.V1>OurRobot.V0 && OurRobot.V3==OurRobot.V6 && OurRobot.V4==OurRobot.V1){if(OurRobot.V5==OurRobot.V7){/*Example();*/}}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
if(OurRobot.V7<OurRobot.V1){if(OurRobot.V1<=OurRobot.V7 && OurRobot.V6<=OurRobot.V1 || OurRobot.V7>OurRobot.V5){/*IntAndFloat();*/}}
/*Example();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
while(OurRobot.V7==OurRobot.V2 && OurRobot.V7<=OurRobot.V5 && OurRobot.V4<OurRobot.V2 || OurRobot.V1>OurRobot.V3){if(OurRobot.V0==OurRobot.V1){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*Example();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*Example();*/
		}

		public override void DoStateAction()
		{
			
/*IntAndFloat();*/
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
/*CircularTargetFire();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
if(OurRobot.V7==OurRobot.V6 && OurRobot.V6!=OurRobot.V4){while(OurRobot.V0!=OurRobot.V4 && OurRobot.V7>OurRobot.V2 || OurRobot.V0<=OurRobot.V2 || OurRobot.V4>=OurRobot.V2){/*Example();*/}}
/*Example();*/
/*Example();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*CircularTargetFire();*/
		}

		public override void ExitState()
		{
			
if(OurRobot.V3<=OurRobot.V7 || OurRobot.V1==OurRobot.V6 || OurRobot.V0==OurRobot.V3 && OurRobot.V6>=OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
if(OurRobot.V2<OurRobot.V5 || OurRobot.V4>OurRobot.V0){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*IntAndFloat();*/
if(OurRobot.V2>OurRobot.V7 && OurRobot.V4<OurRobot.V6){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*IntAndFloat();*/
while(OurRobot.V7>=OurRobot.V2 && OurRobot.V1>=OurRobot.V2){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*Example();*/
		}
	}
}