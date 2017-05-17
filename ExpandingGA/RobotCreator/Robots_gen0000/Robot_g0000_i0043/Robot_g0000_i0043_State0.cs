using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0043 OurRobot { get; set; }
		public State0 (Robot_g0000_i0043 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V0<OurRobot.V3)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(58, 200, 231);
			
/*IntAndFloat(-1,-1.0f);*/
if(OurRobot.V0<=OurRobot.V4){if(OurRobot.V0>=OurRobot.V3 && OurRobot.V1!=OurRobot.V4 && OurRobot.V2==OurRobot.V0){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
/*IntAndFloat();*/
/*Example();*/
/*IntAndFloat();*/
while(OurRobot.V1!=OurRobot.V2 && OurRobot.V4<=OurRobot.V3 || OurRobot.V2>=OurRobot.V0 && OurRobot.V0!=OurRobot.V1){/*Example();*/}
if(OurRobot.V4!=OurRobot.V0 && OurRobot.V1>=OurRobot.V3){if(OurRobot.V3<OurRobot.V1 || OurRobot.V3<=OurRobot.V2){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V0<OurRobot.V4 && OurRobot.V0>=OurRobot.V2 || OurRobot.V0!=OurRobot.V2){while(OurRobot.V4<OurRobot.V2 && OurRobot.V2==OurRobot.V0){/*Example();*/}}
if(OurRobot.V1<OurRobot.V2 || OurRobot.V2<=OurRobot.V4 || OurRobot.V4>OurRobot.V0){/*Example();*/}
/*IntAndFloat();*/
if(OurRobot.V1>OurRobot.V0 && OurRobot.V3==OurRobot.V1){if(OurRobot.V2>OurRobot.V3 || OurRobot.V0>=OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
		}

		public override void DoStateAction()
		{
			
/*CircularTargetFire();*/
/*IntAndFloat();*/
/*Example();*/
while(OurRobot.V4>OurRobot.V0){while(OurRobot.V4>OurRobot.V3 && OurRobot.V4>=OurRobot.V3){/*IntAndFloat();*/}}
/*CircularTargetFire();*/
while(OurRobot.V3==OurRobot.V1 && OurRobot.V0>OurRobot.V3 && OurRobot.V2<OurRobot.V1 || OurRobot.V3>OurRobot.V4){while(OurRobot.V0<=OurRobot.V2){/*IntAndFloat();*/}}
while(OurRobot.V4!=OurRobot.V3 || OurRobot.V3>=OurRobot.V1 && OurRobot.V2>=OurRobot.V1){/*IntAndFloat();*/}
if(OurRobot.V4<=OurRobot.V3 && OurRobot.V0>OurRobot.V2 && OurRobot.V0==OurRobot.V4 && OurRobot.V2>=OurRobot.V4){while(OurRobot.V2==OurRobot.V3){/*IntAndFloat();*/}}
if(OurRobot.V1<=OurRobot.V4){/*IntAndFloat();*/}
if(OurRobot.V4>OurRobot.V1){while(OurRobot.V1==OurRobot.V4 && OurRobot.V4>=OurRobot.V2){if(OurRobot.V3==OurRobot.V0 || OurRobot.V4<=OurRobot.V2 && OurRobot.V4>OurRobot.V1 || OurRobot.V2==OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V2==OurRobot.V3 && OurRobot.V2!=OurRobot.V0){if(OurRobot.V3<=OurRobot.V4 || OurRobot.V4>=OurRobot.V3 && OurRobot.V0==OurRobot.V2){/*IntAndFloat();*/}}
/*IntAndFloat();*/
while(OurRobot.V2<OurRobot.V0 && OurRobot.V3>OurRobot.V0){/*IntAndFloat();*/}
while(OurRobot.V1>OurRobot.V2){/*CircularTargetFire();*/}
if(OurRobot.V4>OurRobot.V0 && OurRobot.V3>=OurRobot.V4 || OurRobot.V0>=OurRobot.V2){if(OurRobot.V0>=OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
		}

		public override void ExitState()
		{
			
if(OurRobot.V4==OurRobot.V3){while(OurRobot.V1<=OurRobot.V0 && OurRobot.V0>OurRobot.V2 || OurRobot.V4<=OurRobot.V3 || OurRobot.V4>=OurRobot.V0){if(OurRobot.V0>=OurRobot.V2 && OurRobot.V2>OurRobot.V4){/*Example();*/}}}
while(OurRobot.V4!=OurRobot.V0 && OurRobot.V0>=OurRobot.V3 || OurRobot.V4==OurRobot.V1 || OurRobot.V1!=OurRobot.V4){if(OurRobot.V2!=OurRobot.V0){/*IntAndFloat();*/}}
while(OurRobot.V2>OurRobot.V0 && OurRobot.V3<=OurRobot.V0 && OurRobot.V4==OurRobot.V2){while(OurRobot.V4<OurRobot.V0 || OurRobot.V2!=OurRobot.V1){if(OurRobot.V4<=OurRobot.V2){/*IntAndFloat();*/}}}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V3>=OurRobot.V4 && OurRobot.V0>OurRobot.V4){while(OurRobot.V3<OurRobot.V0){/*IntAndFloat();*/}}
/*IntAndFloat();*/
while(OurRobot.V4==OurRobot.V2){/*IntAndFloat();*/}
while(OurRobot.V4<OurRobot.V3 || OurRobot.V2!=OurRobot.V3 && OurRobot.V2!=OurRobot.V0){/*CircularTargetFire();*/}
while(OurRobot.V4>OurRobot.V3 || OurRobot.V4==OurRobot.V1 || OurRobot.V0>OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*IntAndFloat();*/
while(OurRobot.V2<OurRobot.V3){/*IntAndFloat();*/}
while(OurRobot.V3!=OurRobot.V1 || OurRobot.V2<OurRobot.V1){if(OurRobot.V1>OurRobot.V2){/*IntAndFloat();*/}}
/*IntAndFloat();*/
if(OurRobot.V2<=OurRobot.V4){/*IntAndFloat();*/}
while(OurRobot.V0<=OurRobot.V3 && OurRobot.V2>OurRobot.V0){/*Example();*/}
		}
	}
}