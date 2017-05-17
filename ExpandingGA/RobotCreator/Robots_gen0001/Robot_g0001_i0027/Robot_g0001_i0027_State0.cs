using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0027 OurRobot { get; set; }
		public State0 (Robot_g0001_i0027 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V1<OurRobot.V5)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(22, 133, 35);
			
/*IntAndFloat(-7,-1.0f);*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*Example();*/
while(OurRobot.V4>=OurRobot.V1){/*IntAndFloat();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
while(OurRobot.V6<=OurRobot.V2 || OurRobot.V5==OurRobot.V0 || OurRobot.V4==OurRobot.V1 || OurRobot.V3>OurRobot.V1){/*IntAndFloat();*/}
		}

		public override void DoStateAction()
		{
			
if(OurRobot.V3==OurRobot.V4){if(OurRobot.V0==OurRobot.V6 || OurRobot.V4>OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
if(OurRobot.V0==OurRobot.V2){/*IntAndFloat();*/}
if(OurRobot.V0>OurRobot.V4 || OurRobot.V5<=OurRobot.V3 || OurRobot.V1>=OurRobot.V5 || OurRobot.V4>OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*Example();*/
if(OurRobot.V2>OurRobot.V6){if(OurRobot.V5<=OurRobot.V0){/*IntAndFloat();*/}}
if(OurRobot.V3<=OurRobot.V4 || OurRobot.V6==OurRobot.V3){/*IntAndFloat();*/}
if(OurRobot.V3>OurRobot.V5 || OurRobot.V5!=OurRobot.V6 && OurRobot.V1!=OurRobot.V6 && OurRobot.V5<OurRobot.V2){if(OurRobot.V5!=OurRobot.V6 && OurRobot.V2>=OurRobot.V0 || OurRobot.V3<OurRobot.V5){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
if(OurRobot.V3!=OurRobot.V6){while(OurRobot.V3<=OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
while(OurRobot.V4>=OurRobot.V6 && OurRobot.V2==OurRobot.V3){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
while(OurRobot.V3>OurRobot.V4){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
if(OurRobot.V4>=OurRobot.V6 || OurRobot.V2>=OurRobot.V1){if(OurRobot.V3>OurRobot.V4 && OurRobot.V0!=OurRobot.V4 || OurRobot.V6==OurRobot.V4 || OurRobot.V2==OurRobot.V6){/*CircularTargetFire();*/}}
/*IntAndFloat();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
		}

		public override void ExitState()
		{
			
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V1<OurRobot.V4 || OurRobot.V5<OurRobot.V6){while(OurRobot.V2>OurRobot.V1){if(OurRobot.V1==OurRobot.V2){/*IntAndFloat();*/}}}
/*Example();*/
while(OurRobot.V0==OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*IntAndFloat();*/
		}
	}
}