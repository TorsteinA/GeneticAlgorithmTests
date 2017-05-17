using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace Alvtor_Hartho_15
{
	public class State1 : State
	{
		public Robot_g0001_i0028 OurRobot { get; set; }
		public State1 (Robot_g0001_i0028 ourRobot) : base (ourRobot)
		{
			OurRobot = ourRobot;
		}

		public override State StateChangeRelevance()
		{
			if (OurRobot.V3!=OurRobot.V0 || OurRobot.V0<=OurRobot.V1 && OurRobot.V1==OurRobot.V3)
				return new State0 (OurRobot);

			return this;
		}

		public override void EnterState()
		{
			OurRobot.BodyColor = Color.Red;
//			OurRobot.BodyColor = Color.FromArgb(166, 91, 141);
			
while(OurRobot.V3==OurRobot.V2 || OurRobot.V0<=OurRobot.V3 && OurRobot.V0!=OurRobot.V3){/*IntAndFloat();*/}
while(OurRobot.V2!=OurRobot.V3 && OurRobot.V3>=OurRobot.V4 && OurRobot.V2>=OurRobot.V4){while(OurRobot.V1!=OurRobot.V4 && OurRobot.V1>=OurRobot.V5 || OurRobot.V0!=OurRobot.V4){/*IntAndFloat();*/}}
while(OurRobot.V5<OurRobot.V3){/*IntAndFloat();*/}
if(OurRobot.V2<OurRobot.V5 && OurRobot.V4>OurRobot.V5){/*IntAndFloat();*/}
/*CircularTargetFire();*/
/*IntAndFloat();*/
if(OurRobot.V0<=OurRobot.V2 || OurRobot.V1<=OurRobot.V4 || OurRobot.V0<=OurRobot.V2 || OurRobot.V1>OurRobot.V2){if(OurRobot.V2>=OurRobot.V1){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
while(OurRobot.V1<=OurRobot.V3 && OurRobot.V1!=OurRobot.V3 && OurRobot.V3!=OurRobot.V0 || OurRobot.V0<OurRobot.V1){/*IntAndFloat();*/}
if(OurRobot.V1>OurRobot.V5){/*Example();*/}
while(OurRobot.V3==OurRobot.V1 || OurRobot.V4>OurRobot.V2){/*Example();*/}
/*IntAndFloat();*/
/*IntAndFloat();*/
		}

		public override void DoStateAction()
		{
			
while(OurRobot.V1!=OurRobot.V0 && OurRobot.V3!=OurRobot.V1 && OurRobot.V0<OurRobot.V3){while(OurRobot.V0>OurRobot.V5 && OurRobot.V5<OurRobot.V2 || OurRobot.V2==OurRobot.V5){/*IntAndFloat();*/}}
/*CircularTargetFire();*/
while(OurRobot.V2<OurRobot.V1 && OurRobot.V1<=OurRobot.V0){/*IntAndFloat();*/}
if(OurRobot.V3==OurRobot.V0){while(OurRobot.V2!=OurRobot.V0 || OurRobot.V1<OurRobot.V4){/*IntAndFloat();*/}}
/*IntAndFloat();*/
if(OurRobot.V2!=OurRobot.V4 && OurRobot.V3!=OurRobot.V4 || OurRobot.V0>OurRobot.V4 && OurRobot.V0<=OurRobot.V2){while(OurRobot.V5>=OurRobot.V0 || OurRobot.V1==OurRobot.V3){/*Example();*/}}
/*IntAndFloat();*/
if(OurRobot.V4<OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}
/*Example();*/
/*IntAndFloat();*/
while(OurRobot.V0<OurRobot.V4 || OurRobot.V1>OurRobot.V4){/*IntAndFloat();*/}
		}

		public override void ExitState()
		{
			
if(OurRobot.V0!=OurRobot.V5 || OurRobot.V3!=OurRobot.V5){while(OurRobot.V0==OurRobot.V5){/*OurRobot.Fire(500 / OurRobot.Enemy.Distance);*/}}
		}
	}
}