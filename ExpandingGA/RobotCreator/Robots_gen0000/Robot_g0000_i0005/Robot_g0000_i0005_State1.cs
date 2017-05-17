using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0000_i0005 OurRobot { get; set; }
		public State1 (Robot_g0000_i0005 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V3>=OurRobot.V5 || OurRobot.V0<=OurRobot.V4 || OurRobot.V3<=OurRobot.V6 && OurRobot.V4==OurRobot.V1)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(119, 76, 27);
			
while(OurRobot.V6<=OurRobot.V4 || OurRobot.V0>OurRobot.V6){/*IntAndFloat();*/}
/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/
/*IntAndFloat();*/
/*IntAndFloat();*/
/*Example();*/
if(OurRobot.V7==OurRobot.V0){if(OurRobot.V6<OurRobot.V5 && OurRobot.V7>=OurRobot.V3){if(OurRobot.V7==OurRobot.V3 || OurRobot.V0>OurRobot.V5){/*CircularTargetFire();*/}}}
/*Example();*/
/*IntAndFloat();*/
while(OurRobot.V7!=OurRobot.V4){if(OurRobot.V0==OurRobot.V2){/*CircularTargetFire();*/}}
while(OurRobot.V1!=OurRobot.V2){/*Example();*/}
while(OurRobot.V0<OurRobot.V6){if(OurRobot.V7!=OurRobot.V5){/*Example();*/}}
if(OurRobot.V5>OurRobot.V4){while(OurRobot.V0!=OurRobot.V4 || OurRobot.V2<OurRobot.V6){/*Example();*/}}
		}

		public override void DoStateAction()
		{
			
/*CircularTargetFire();*/
/*IntAndFloat();*/
while(OurRobot.V0>=OurRobot.V3){while(OurRobot.V4<OurRobot.V1){/*CircularTargetFire();*/}}
/*Example();*/
while(OurRobot.V5>=OurRobot.V0 && OurRobot.V5>=OurRobot.V3 && OurRobot.V7<OurRobot.V0 && OurRobot.V2>OurRobot.V1){if(OurRobot.V7<OurRobot.V3){/*CircularTargetFire();*/}}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*Example();*/
if(OurRobot.V7>OurRobot.V4){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
		}

		public override void ExitState()
		{
			
while(OurRobot.V5>OurRobot.V0){if(OurRobot.V4>OurRobot.V0 && OurRobot.V0>=OurRobot.V5 || OurRobot.V6>=OurRobot.V2){/*IntAndFloat();*/}}
while(OurRobot.V3<=OurRobot.V5){while(OurRobot.V1==OurRobot.V3){if(OurRobot.V4>OurRobot.V0){/*IntAndFloat();*/}}}
while(OurRobot.V7==OurRobot.V3){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
while(OurRobot.V4<=OurRobot.V6 || OurRobot.V6>OurRobot.V7 && OurRobot.V3<OurRobot.V0 && OurRobot.V5<=OurRobot.V1){while(OurRobot.V3<=OurRobot.V0){/*Example();*/}}
if(OurRobot.V3>=OurRobot.V1 && OurRobot.V1>OurRobot.V3 && OurRobot.V6>=OurRobot.V5 && OurRobot.V0==OurRobot.V2){if(OurRobot.V2!=OurRobot.V7 && OurRobot.V2<=OurRobot.V4){if(OurRobot.V4>OurRobot.V0){/*Example();*/}}}
/*IntAndFloat();*/
/*IntAndFloat();*/
/*Example();*/
while(OurRobot.V4<=OurRobot.V1 && OurRobot.V0>=OurRobot.V3 && OurRobot.V3>=OurRobot.V5){while(OurRobot.V7==OurRobot.V4 || OurRobot.V3!=OurRobot.V7 && OurRobot.V0<OurRobot.V6 && OurRobot.V5==OurRobot.V0){/*Example();*/}}
if(OurRobot.V6<=OurRobot.V7 || OurRobot.V0<=OurRobot.V1 || OurRobot.V4>OurRobot.V7 && OurRobot.V6<OurRobot.V3){while(OurRobot.V0>=OurRobot.V3){/*Example();*/}}
while(OurRobot.V1!=OurRobot.V5){while(OurRobot.V3!=OurRobot.V1){/*IntAndFloat();*/}}
/*IntAndFloat();*/
		}
	}
}