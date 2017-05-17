using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0016 OurRobot { get; set; }
		public State1 (Robot_g0001_i0016 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V2<OurRobot.V0 && OurRobot.V0<=OurRobot.V2)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(34, 124, 11);
			
while(OurRobot.V0<=OurRobot.V3 || OurRobot.V1!=OurRobot.V0 && OurRobot.V0>=OurRobot.V2){/*Example();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V3>=OurRobot.V1){/*IntAndFloat(-1,-1.0f);*/}
while(OurRobot.V4>OurRobot.V3 || OurRobot.V1==OurRobot.V3 || OurRobot.V1==OurRobot.V3){/*IntAndFloat();*/}
/*CircularTargetFire();*/
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V1<=OurRobot.V3){if(OurRobot.V0>OurRobot.V3){/*IntAndFloat();*/}}
if(OurRobot.V2>OurRobot.V3){/*IntAndFloat();*/}
if(OurRobot.V0>OurRobot.V3 && OurRobot.V4==OurRobot.V2){if(OurRobot.V1>OurRobot.V2){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
if(OurRobot.V2<OurRobot.V3 && OurRobot.V0<OurRobot.V4){if(OurRobot.V1>=OurRobot.V4){/*CircularTargetFire();*/}}
while(OurRobot.V3!=OurRobot.V1 && OurRobot.V3<=OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*IntAndFloat();*/
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V2<OurRobot.V1 && OurRobot.V0>OurRobot.V4 || OurRobot.V2<OurRobot.V1 && OurRobot.V4>OurRobot.V2){/*Example();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V0>=OurRobot.V2){while(OurRobot.V2<OurRobot.V1 && OurRobot.V0>OurRobot.V2 && OurRobot.V3>=OurRobot.V4 && OurRobot.V4==OurRobot.V3){/*IntAndFloat();*/}}
while(OurRobot.V2==OurRobot.V4 && OurRobot.V2>=OurRobot.V0){while(OurRobot.V4>OurRobot.V1 || OurRobot.V1==OurRobot.V3 || OurRobot.V3>=OurRobot.V4){/*IntAndFloat();*/}}
/*Example();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V2!=OurRobot.V3 && OurRobot.V0<=OurRobot.V1 || OurRobot.V2>=OurRobot.V3){if(OurRobot.V4>=OurRobot.V3 || OurRobot.V3==OurRobot.V2 && OurRobot.V1>OurRobot.V3){/*CircularTargetFire();*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V2<OurRobot.V1 || OurRobot.V4!=OurRobot.V0){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V3>OurRobot.V2 || OurRobot.V1<OurRobot.V0){if(OurRobot.V4>=OurRobot.V0){/*CircularTargetFire();*/}}
/*IntAndFloat();*/
/*CircularTargetFire();*/
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
/*IntAndFloat();*/
while(OurRobot.V3!=OurRobot.V4 && OurRobot.V2==OurRobot.V1){if(OurRobot.V4==OurRobot.V1){/*CircularTargetFire();*/}}
while(OurRobot.V0<=OurRobot.V4 && OurRobot.V2!=OurRobot.V0 || OurRobot.V1<OurRobot.V2 || OurRobot.V3>OurRobot.V2){if(OurRobot.V3<=OurRobot.V1 || OurRobot.V4<OurRobot.V3){if(OurRobot.V2!=OurRobot.V0){/*IntAndFloat();*/}}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
if(OurRobot.V2<OurRobot.V4){/*Example();*/}
/*Example();*/
		}
	}
}