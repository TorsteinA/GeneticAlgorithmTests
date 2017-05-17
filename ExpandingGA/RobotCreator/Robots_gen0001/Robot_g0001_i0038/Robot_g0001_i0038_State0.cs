using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0001_i0038 OurRobot { get; set; }
		public State0 (Robot_g0001_i0038 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V5>=OurRobot.V4)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(101, 253, 124);
			
while(OurRobot.V5==OurRobot.V2 && OurRobot.V1>OurRobot.V3){while(OurRobot.V3!=OurRobot.V1){/*IntAndFloat(3,-1.0f);*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V0!=OurRobot.V4){/*Example();*/}
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V2<=OurRobot.V5 || OurRobot.V5!=OurRobot.V0 && OurRobot.V3==OurRobot.V1 && OurRobot.V1<OurRobot.V0){/*IntAndFloat();*/}
while(OurRobot.V4>OurRobot.V3 && OurRobot.V5>OurRobot.V2 && OurRobot.V0!=OurRobot.V2){if(OurRobot.V0==OurRobot.V5){/*IntAndFloat();*/}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
if(OurRobot.V1<OurRobot.V3 || OurRobot.V5<=OurRobot.V3 || OurRobot.V1<OurRobot.V0 && OurRobot.V5>=OurRobot.V1){/*IntAndFloat();*/}
while(OurRobot.V3!=OurRobot.V4 && OurRobot.V2>OurRobot.V3){/*Example();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
		}

		public override void ExitState()
		{
			
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*Example();*/
/*IntAndFloat();*/
if(OurRobot.V1<=OurRobot.V5 && OurRobot.V4<OurRobot.V5 && OurRobot.V0>OurRobot.V1){if(OurRobot.V1==OurRobot.V2 || OurRobot.V5>=OurRobot.V0 || OurRobot.V1!=OurRobot.V2 && OurRobot.V3==OurRobot.V5){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V0>OurRobot.V4){while(OurRobot.V1>OurRobot.V4 || OurRobot.V4<OurRobot.V5){/*IntAndFloat();*/}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V5!=OurRobot.V0 && OurRobot.V3>=OurRobot.V1){if(OurRobot.V5<OurRobot.V3 || OurRobot.V0<OurRobot.V2 && OurRobot.V2<=OurRobot.V1 || OurRobot.V1<OurRobot.V2){if(OurRobot.V1>=OurRobot.V2 || OurRobot.V1==OurRobot.V2 || OurRobot.V3<OurRobot.V5 && OurRobot.V3>OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}}
while(OurRobot.V2>OurRobot.V4){if(OurRobot.V0!=OurRobot.V2){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
if(OurRobot.V3>=OurRobot.V2){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
		}
	}
}