using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0023 OurRobot { get; set; }
		public State0 (Robot_g0001_i0023 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V2>=OurRobot.V4)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(220, 214, 254);
			
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V4<=OurRobot.V6){/*Example();*/}
while(OurRobot.V1>=OurRobot.V4){while(OurRobot.V2>=OurRobot.V3 && OurRobot.V2>OurRobot.V7 || OurRobot.V6==OurRobot.V5 || OurRobot.V7==OurRobot.V5){/*IntAndFloat(-8,-1.0f);*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*Example();*/
if(OurRobot.V2>OurRobot.V0 || OurRobot.V2!=OurRobot.V0 && OurRobot.V5==OurRobot.V2 || OurRobot.V5>OurRobot.V4){while(OurRobot.V2>OurRobot.V7 && OurRobot.V0==OurRobot.V2 && OurRobot.V3==OurRobot.V5 || OurRobot.V6>OurRobot.V7){/*Example();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V5<OurRobot.V7 || OurRobot.V0>=OurRobot.V1){while(OurRobot.V3<=OurRobot.V4 || OurRobot.V4!=OurRobot.V1 && OurRobot.V0<OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
while(OurRobot.V7<=OurRobot.V0){/*IntAndFloat();*/}
		}

		public override void DoStateAction()
		{
			
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V4<OurRobot.V7 || OurRobot.V5>=OurRobot.V2){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
if(OurRobot.V0<OurRobot.V3 && OurRobot.V3<=OurRobot.V6 && OurRobot.V1<OurRobot.V6){/*Example();*/}
if(OurRobot.V5>=OurRobot.V0 || OurRobot.V1>=OurRobot.V3 || OurRobot.V4<=OurRobot.V1){while(OurRobot.V2!=OurRobot.V5){if(OurRobot.V1==OurRobot.V6){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}}
while(OurRobot.V4<OurRobot.V3 || OurRobot.V0==OurRobot.V7 || OurRobot.V5>OurRobot.V0 || OurRobot.V2==OurRobot.V5){/*CircularTargetFire();*/}
if(OurRobot.V5!=OurRobot.V6 && OurRobot.V5<OurRobot.V3){while(OurRobot.V0<OurRobot.V5){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
while(OurRobot.V5>OurRobot.V3){/*IntAndFloat();*/}
if(OurRobot.V1>OurRobot.V3 || OurRobot.V3<OurRobot.V4 || OurRobot.V2>=OurRobot.V7){/*Example();*/}
if(OurRobot.V3<=OurRobot.V4){while(OurRobot.V5<OurRobot.V0 && OurRobot.V0>OurRobot.V2 || OurRobot.V7>=OurRobot.V1){/*IntAndFloat();*/}}
while(OurRobot.V5>=OurRobot.V0){/*IntAndFloat();*/}
while(OurRobot.V5>=OurRobot.V7){while(OurRobot.V5>=OurRobot.V7 && OurRobot.V7==OurRobot.V0 || OurRobot.V5==OurRobot.V6 && OurRobot.V7>=OurRobot.V6){/*IntAndFloat();*/}}
/*CircularTargetFire();*/
if(OurRobot.V6==OurRobot.V4 || OurRobot.V3==OurRobot.V6){while(OurRobot.V4>OurRobot.V3 && OurRobot.V1!=OurRobot.V4 && OurRobot.V2<OurRobot.V7 && OurRobot.V3>=OurRobot.V6){/*CircularTargetFire();*/}}
		}
	}
}