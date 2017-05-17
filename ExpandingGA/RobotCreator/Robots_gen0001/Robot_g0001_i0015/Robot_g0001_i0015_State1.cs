using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0015 OurRobot { get; set; }
		public State1 (Robot_g0001_i0015 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V1>OurRobot.V0)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(11, 232, 232);
			
if(OurRobot.V3!=OurRobot.V5){/*IntAndFloat();*/}
while(OurRobot.V1<=OurRobot.V2){while(OurRobot.V1==OurRobot.V4 && OurRobot.V0!=OurRobot.V5){/*Example();*/}}
		}

		public override void DoStateAction()
		{
			
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*Example();*/
/*IntAndFloat();*/
while(OurRobot.V1==OurRobot.V5 && OurRobot.V0>OurRobot.V5){/*IntAndFloat();*/}
/*IntAndFloat();*/
while(OurRobot.V0!=OurRobot.V4){while(OurRobot.V2<=OurRobot.V0){/*CircularTargetFire();*/}}
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
while(OurRobot.V2<OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*Example();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V2<=OurRobot.V1 && OurRobot.V0>=OurRobot.V2){/*CircularTargetFire();*/}
while(OurRobot.V4<=OurRobot.V0 || OurRobot.V5==OurRobot.V3 && OurRobot.V1!=OurRobot.V0 && OurRobot.V5>OurRobot.V4){while(OurRobot.V5<OurRobot.V0){/*IntAndFloat();*/}}
/*CircularTargetFire();*/
while(OurRobot.V1<OurRobot.V0 || OurRobot.V1>=OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
if(OurRobot.V5<OurRobot.V0 && OurRobot.V5!=OurRobot.V3 && OurRobot.V3<=OurRobot.V0){if(OurRobot.V3<OurRobot.V2){/*IntAndFloat();*/}}
while(OurRobot.V1<=OurRobot.V4){/*Example();*/}
if(OurRobot.V2!=OurRobot.V0 && OurRobot.V4==OurRobot.V2 && OurRobot.V2>=OurRobot.V5 && OurRobot.V2>=OurRobot.V4){while(OurRobot.V1<=OurRobot.V4 || OurRobot.V2!=OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
if(OurRobot.V2<=OurRobot.V1){if(OurRobot.V0>OurRobot.V3 || OurRobot.V0>OurRobot.V1 || OurRobot.V3>OurRobot.V2 && OurRobot.V0!=OurRobot.V1){/*CircularTargetFire();*/}}
		}
	}
}