using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmForStrings {
	internal class GeneratedRobotClassesExample {
		// Below are rough designs of the generated classes to use as reference when implementing.
		// DnaToCode references are meant for implementation, and not to be called with the generated class.
		// Assumes class hierarchy says Robot_gX_iY is a Garics, and a Garics is an AdvancedRobot. (Needs to be this way because of functions in State.cs)


		/*
				
*** The Robot class ***
		 
		using System;
		using System.Drawing;
		using System.Runtime.InteropServices;
		using System.Text;
		using Robocode;
		using Robocode.Util;
		using SeaSharpBot.FSM;
		using SeaSharpBot.FSM.States;
		using SeaSharpBot.FSM.States.Bottom;
		using SeaSharpBot.FSM.States.Top;
		using SeaSharpBot.Helpers;
		
		namespace Garics

		public class Robot_gX_iY : Garics {
					
			DnaToCode.GetVariableDeclarations();
		
			public override void Run() {
				Enemy = new EnemyData();
				_stateManager = new StateManagerScript(new State1(this));
				
				DnaToCode.GetVariableInitialisations();

				while (true) {
					_stateManager.FrameCheck();
					Execute();
					OldEnemy = Enemy;
				}
			}

			public override void OnScannedRobot(ScannedRobotEvent e) {
				var angleToEnemy = HeadingRadians + e.BearingRadians;
				var enemyX = (int)(X + Math.Sin(angleToEnemy) * e.Distance);
				var enemyY = (int)(Y + Math.Cos(angleToEnemy) * e.Distance);
				Enemy.SetEnemyData(e, new Point2D(enemyX, enemyY));
			}
		}

		
*** State1 ***		

		using System;
		using System.Drawing;
	 
		namespace Garics {
	 		public class State1 : State	{
	 			public State1(Garics ourRobot){
	 				OurRobot = ourRobot;
	 			}
	 
	 			public override State StateChangeRelevance(){
	 				if (DnaToCode.GetFirstToSecondStateTransitionContent())
	 					return new State2(OurRobot);
	 				else
	 					return this;
	 			}
	 
	 			public override void EnterState(){
	 				OurRobot.BodyColor = Color.Green;		//Figured having a visual clue stay consistent helps debugging when we get to running actual matches. 
	 				DnaToCode.GetFirstStateEnterMethodContent();
	  			}
	 
	 			public override void DoStateAction(){
	 				DnaToCode.GetFirstStateDoStateActionMethodContent();
	 			}
	 
	 			public override void ExitState(){
	 				DnaToCode.GetFirstStateLeaveMethodContent();
	 			}
	 		}
		}
	 

*** State2 ***

		using System;
		using System.Drawing;
	 
		namespace Garics {
	 		public class State2 : State	{
	 			public State2(Garics ourRobot){
	 				OurRobot = ourRobot;
	 			}
	 
	 			public override State StateChangeRelevance(){
	 				if (DnaToCode.GetSecondToFirstStateTransitionContent())
	 					return new State1(OurRobot);
	 				else
	 					return this;
	 			}
	 
	 			public override void EnterState(){
	 				OurRobot.BodyColor = Color.Red;		//Figured having a visual clue stay consistent helps debugging when we get to running actual matches. 
	 				DnaToCode.GetSecondStateEnterMethodContent();
	  			}
	 
	 			public override void DoStateAction(){
	 				DnaToCode.GetSecondStateDoStateActionMethodContent();
	 			}
	 
	 			public override void ExitState(){
	 				DnaToCode.GetSecondStateLeaveMethodContent();
	 			}
	 		}
		}
		 
	 */

	}
}
