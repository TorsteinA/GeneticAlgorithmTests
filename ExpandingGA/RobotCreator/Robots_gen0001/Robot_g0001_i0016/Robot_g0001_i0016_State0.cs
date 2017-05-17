using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0016 OurRobot { get; set; }
		public State0 (Robot_g0001_i0016 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V1>OurRobot.V3 || OurRobot.V3==OurRobot.V0)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(64, 188, 26);
			
		}

		public override void DoStateAction()
		{
			
/*CircularTargetFire();*/
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V4==OurRobot.V1 || OurRobot.V1==OurRobot.V0 || OurRobot.V4<OurRobot.V0 && OurRobot.V2<=OurRobot.V0){/*IntAndFloat();*/}
while(OurRobot.V2>OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
if(OurRobot.V3<=OurRobot.V4 || OurRobot.V1>=OurRobot.V0){/*IntAndFloat();*/}
while(OurRobot.V0==OurRobot.V2){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V0!=OurRobot.V2){if(OurRobot.V0>=OurRobot.V3 && OurRobot.V0>OurRobot.V3 || OurRobot.V4==OurRobot.V2){if(OurRobot.V1<OurRobot.V2){/*IntAndFloat();*/}}}
while(OurRobot.V0<=OurRobot.V1){if(OurRobot.V1>OurRobot.V2){if(OurRobot.V2<OurRobot.V1 && OurRobot.V0>OurRobot.V4 || OurRobot.V2<OurRobot.V1 && OurRobot.V4>OurRobot.V2){/*Example();*/}}}
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V0>=OurRobot.V2){while(OurRobot.V2<OurRobot.V1 && OurRobot.V0>OurRobot.V2 && OurRobot.V3>=OurRobot.V4 && OurRobot.V4==OurRobot.V3){/*IntAndFloat();*/}}
while(OurRobot.V2==OurRobot.V4 && OurRobot.V2>=OurRobot.V0){while(OurRobot.V4>OurRobot.V1 || OurRobot.V1==OurRobot.V3 || OurRobot.V3>=OurRobot.V4){/*IntAndFloat();*/}}
		}

		public override void ExitState()
		{
			
if(OurRobot.V1>=OurRobot.V4){while(OurRobot.V2>=OurRobot.V1){/*IntAndFloat();*/}}
while(OurRobot.V3<=OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*Example();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V0<OurRobot.V1){while(OurRobot.V0<=OurRobot.V1){/*IntAndFloat();*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
		}
	}
}