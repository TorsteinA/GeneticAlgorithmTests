using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0010 OurRobot { get; set; }
		public State1 (Robot_g0000_i0010 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V5<=OurRobot.V3 && OurRobot.V4>OurRobot.V3 || OurRobot.V6>OurRobot.V7 || OurRobot.V1>OurRobot.V0)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(71, 12, 84);
			
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V3!=OurRobot.V2){while(OurRobot.V3>OurRobot.V4 && OurRobot.V1!=OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
if(OurRobot.V4>OurRobot.V6 || OurRobot.V2>OurRobot.V6){if(OurRobot.V5>OurRobot.V2){/*IntAndFloat();*/}}
/*IntAndFloat();*/
if(OurRobot.V6<OurRobot.V5){/*IntAndFloat();*/}
/*Example();*/
while(OurRobot.V0<OurRobot.V1){/*IntAndFloat();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
if(OurRobot.V1>=OurRobot.V0 || OurRobot.V4<=OurRobot.V0){if(OurRobot.V1!=OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V4==OurRobot.V2){while(OurRobot.V6!=OurRobot.V3){/*IntAndFloat();*/}}
if(OurRobot.V6==OurRobot.V0 || OurRobot.V0>=OurRobot.V3){if(OurRobot.V5<=OurRobot.V2){/*IntAndFloat();*/}}
if(OurRobot.V2<=OurRobot.V4 && OurRobot.V3>OurRobot.V1){if(OurRobot.V1<=OurRobot.V3){/*CircularTargetFire();*/}}
if(OurRobot.V7<=OurRobot.V0){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*IntAndFloat();*/
while(OurRobot.V0<OurRobot.V5 || OurRobot.V3>=OurRobot.V5){if(OurRobot.V5>=OurRobot.V1 || OurRobot.V3<=OurRobot.V6 || OurRobot.V6>=OurRobot.V2){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
while(OurRobot.V1>OurRobot.V5 || OurRobot.V6<=OurRobot.V1 || OurRobot.V7>=OurRobot.V1 && OurRobot.V6>OurRobot.V5){/*CircularTargetFire();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V6<OurRobot.V0 || OurRobot.V2<=OurRobot.V4){while(OurRobot.V0==OurRobot.V3 && OurRobot.V7>=OurRobot.V4){if(OurRobot.V5!=OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
		}

		public override void ExitState()
		{
			
/*Example();*/
while(OurRobot.V4<=OurRobot.V6 || OurRobot.V5>OurRobot.V4 || OurRobot.V2==OurRobot.V6){while(OurRobot.V0<OurRobot.V2 && OurRobot.V1>OurRobot.V4){/*Example();*/}}
while(OurRobot.V4==OurRobot.V6){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*IntAndFloat();*/
/*CircularTargetFire();*/
		}
	}
}