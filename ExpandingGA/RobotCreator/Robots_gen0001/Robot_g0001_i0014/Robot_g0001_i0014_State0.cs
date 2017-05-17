using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0014 OurRobot { get; set; }
		public State0 (Robot_g0001_i0014 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V1>OurRobot.V3 || OurRobot.V0>OurRobot.V5)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(56, 70, 181);
			
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat(3,-1.0f);*/
/*IntAndFloat();*/
while(OurRobot.V1<OurRobot.V2 && OurRobot.V4!=OurRobot.V2 && OurRobot.V0>OurRobot.V2 && OurRobot.V0>=OurRobot.V3){while(OurRobot.V1<OurRobot.V3 && OurRobot.V2==OurRobot.V3 || OurRobot.V1>OurRobot.V5){/*IntAndFloat();*/}}
while(OurRobot.V5==OurRobot.V3){while(OurRobot.V3<OurRobot.V4 && OurRobot.V1==OurRobot.V4){/*CircularTargetFire();*/}}
while(OurRobot.V5>=OurRobot.V1 || OurRobot.V0==OurRobot.V4 && OurRobot.V2>=OurRobot.V0){if(OurRobot.V0>=OurRobot.V2 && OurRobot.V5>=OurRobot.V1 && OurRobot.V2>=OurRobot.V3 || OurRobot.V1<OurRobot.V2){if(OurRobot.V0>=OurRobot.V3){/*IntAndFloat();*/}}}
while(OurRobot.V1>=OurRobot.V5 || OurRobot.V1>=OurRobot.V3){if(OurRobot.V2<=OurRobot.V3 && OurRobot.V4<OurRobot.V1){/*IntAndFloat();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V1==OurRobot.V3){if(OurRobot.V5==OurRobot.V4){if(OurRobot.V0<=OurRobot.V2 && OurRobot.V4>=OurRobot.V1 && OurRobot.V3==OurRobot.V0 || OurRobot.V2!=OurRobot.V0){/*IntAndFloat();*/}}}
while(OurRobot.V0>=OurRobot.V4){if(OurRobot.V0>=OurRobot.V3){if(OurRobot.V2>=OurRobot.V3 && OurRobot.V5==OurRobot.V2 || OurRobot.V0==OurRobot.V1 || OurRobot.V1<=OurRobot.V0){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}}
if(OurRobot.V5<=OurRobot.V1){/*IntAndFloat();*/}
if(OurRobot.V5<OurRobot.V3){if(OurRobot.V1>=OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
		}

		public override void ExitState()
		{
			
if(OurRobot.V0>OurRobot.V3 || OurRobot.V3!=OurRobot.V4){while(OurRobot.V5>=OurRobot.V0){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
if(OurRobot.V0==OurRobot.V2){/*IntAndFloat();*/}
if(OurRobot.V0>=OurRobot.V3 && OurRobot.V2>OurRobot.V3){if(OurRobot.V4<OurRobot.V5 || OurRobot.V5==OurRobot.V2 && OurRobot.V5!=OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
if(OurRobot.V1>OurRobot.V0){if(OurRobot.V1<=OurRobot.V0 && OurRobot.V5==OurRobot.V3 || OurRobot.V3>=OurRobot.V4 || OurRobot.V0>=OurRobot.V4){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V4<=OurRobot.V1){while(OurRobot.V0<OurRobot.V1){if(OurRobot.V5>=OurRobot.V4 && OurRobot.V4==OurRobot.V1 || OurRobot.V0<=OurRobot.V1 || OurRobot.V2==OurRobot.V1){/*Example();*/}}}
		}
	}
}