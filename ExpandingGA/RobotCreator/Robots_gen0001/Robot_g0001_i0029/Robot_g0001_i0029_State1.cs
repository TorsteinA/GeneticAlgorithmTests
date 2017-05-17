using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0029 OurRobot { get; set; }
		public State1 (Robot_g0001_i0029 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V1<=OurRobot.V0 && OurRobot.V2<=OurRobot.V1)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(119, 7, 132);
			
while(OurRobot.V1<=OurRobot.V4){while(OurRobot.V2>=OurRobot.V3){if(OurRobot.V1<OurRobot.V2){/*IntAndFloat();*/}}}
if(OurRobot.V3<OurRobot.V4 || OurRobot.V4!=OurRobot.V0){/*IntAndFloat();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
if(OurRobot.V1!=OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V1<=OurRobot.V0 && OurRobot.V1<OurRobot.V2){if(OurRobot.V0<OurRobot.V3 && OurRobot.V1<=OurRobot.V2){/*IntAndFloat();*/}}
if(OurRobot.V0!=OurRobot.V3 || OurRobot.V0<OurRobot.V1){/*CircularTargetFire();*/}
if(OurRobot.V0<OurRobot.V3){while(OurRobot.V3>=OurRobot.V1 || OurRobot.V2==OurRobot.V3 || OurRobot.V0<OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V0<=OurRobot.V3 || OurRobot.V1<=OurRobot.V2 || OurRobot.V4!=OurRobot.V2 && OurRobot.V0>=OurRobot.V3){if(OurRobot.V3>OurRobot.V0){/*IntAndFloat();*/}}
while(OurRobot.V3==OurRobot.V1){/*CircularTargetFire();*/}
/*Example();*/
/*IntAndFloat();*/
if(OurRobot.V4==OurRobot.V1){while(OurRobot.V3==OurRobot.V4 || OurRobot.V0<OurRobot.V1){if(OurRobot.V4>OurRobot.V2 && OurRobot.V3<OurRobot.V1 && OurRobot.V3!=OurRobot.V0){/*IntAndFloat();*/}}}
/*IntAndFloat();*/
if(OurRobot.V4<OurRobot.V0 && OurRobot.V2>OurRobot.V4){if(OurRobot.V4>OurRobot.V2){/*CircularTargetFire();*/}}
		}

		public override void ExitState()
		{
			
if(OurRobot.V1>=OurRobot.V2 && OurRobot.V1!=OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*IntAndFloat();*/
if(OurRobot.V2<OurRobot.V4){if(OurRobot.V1==OurRobot.V2 || OurRobot.V3==OurRobot.V4 || OurRobot.V0==OurRobot.V1){if(OurRobot.V3==OurRobot.V1 || OurRobot.V0!=OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
/*CircularTargetFire();*/
if(OurRobot.V3<=OurRobot.V4 && OurRobot.V2>OurRobot.V1){if(OurRobot.V1>OurRobot.V3){/*IntAndFloat();*/}}
if(OurRobot.V3<=OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
		}
	}
}