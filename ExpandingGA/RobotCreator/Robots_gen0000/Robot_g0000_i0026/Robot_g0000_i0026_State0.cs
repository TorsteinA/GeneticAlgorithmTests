using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State0 : State
	{
		public Robot_g0000_i0026 OurRobot { get; set; }
		public State0 (Robot_g0000_i0026 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V1<OurRobot.V6 || OurRobot.V7<=OurRobot.V6)
				return new State1 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Green;
//			OurRobot.BodyColor = Color.FromArgb(174, 236, 118);
			
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V1>=OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
while(OurRobot.V2==OurRobot.V5 && OurRobot.V3<=OurRobot.V1 && OurRobot.V2<OurRobot.V0 && OurRobot.V7<=OurRobot.V2){/*IntAndFloat(-1,-1.0f);*/}
while(OurRobot.V7!=OurRobot.V2 || OurRobot.V1==OurRobot.V3){while(OurRobot.V0>=OurRobot.V4 && OurRobot.V0!=OurRobot.V2){if(OurRobot.V3<=OurRobot.V1 && OurRobot.V2<OurRobot.V4 && OurRobot.V1>OurRobot.V6 && OurRobot.V1!=OurRobot.V0){/*IntAndFloat();*/}}}
if(OurRobot.V2>=OurRobot.V7 || OurRobot.V2<OurRobot.V4 || OurRobot.V0<=OurRobot.V2 && OurRobot.V0<=OurRobot.V5){/*IntAndFloat();*/}
while(OurRobot.V3<=OurRobot.V0 && OurRobot.V6>=OurRobot.V2 || OurRobot.V4<OurRobot.V2){while(OurRobot.V1>OurRobot.V3 || OurRobot.V0<OurRobot.V2){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}}
if(OurRobot.V3<=OurRobot.V1){while(OurRobot.V6>=OurRobot.V1 && OurRobot.V3<OurRobot.V0){/*IntAndFloat();*/}}
/*IntAndFloat();*/
/*Example();*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V0<OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*IntAndFloat();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
while(OurRobot.V7<=OurRobot.V3 || OurRobot.V6!=OurRobot.V0 || OurRobot.V7>=OurRobot.V4){/*Example();*/}
while(OurRobot.V2<=OurRobot.V3 || OurRobot.V5!=OurRobot.V4){/*Example();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*CircularTargetFire();*/
while(OurRobot.V1<OurRobot.V2){if(OurRobot.V3>=OurRobot.V0 || OurRobot.V2<=OurRobot.V6){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
/*Example();*/
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/
if(OurRobot.V0>=OurRobot.V1){while(OurRobot.V6<OurRobot.V0){/*CircularTargetFire();*/}}
		}

		public override void ExitState()
		{
			
/*CircularTargetFire();*/
if(OurRobot.V3!=OurRobot.V2 || OurRobot.V6==OurRobot.V1){/*KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);*/}
/*IntAndFloat();*/
while(OurRobot.V7!=OurRobot.V3){/*IntAndFloat();*/}
while(OurRobot.V6==OurRobot.V1){while(OurRobot.V6!=OurRobot.V2 && OurRobot.V2!=OurRobot.V1 && OurRobot.V6<OurRobot.V5 || OurRobot.V5<OurRobot.V3){/*Example();*/}}
while(OurRobot.V7!=OurRobot.V6 || OurRobot.V5<OurRobot.V6){/*IntAndFloat();*/}
while(OurRobot.V7<OurRobot.V1 || OurRobot.V7<OurRobot.V2){/*IntAndFloat();*/}
		}
	}
}