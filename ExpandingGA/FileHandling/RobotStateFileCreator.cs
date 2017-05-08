using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmForStrings {
	internal class RobotStateFileCreator {

		private static Random Random { get; set; } = new Random(); // for random colors

		internal static void CreateStateFiles(string filePath, string robotId, DnaToCode dnaTranslator) {
			for (var i = 0; i <= 1; i++) {
				FileCreator.CreateFile(
					filePath,
					$"{robotId}_State{i}{FileCreator.CodeFileExtension}",
					GetFileText(i, robotId, dnaTranslator),
					true
				);
			}
		}

		private static string GetFileText(int stateNumber, string robotId, DnaToCode dnaTranslator)
		{
			return $@"using System;
using System.Drawing;
using Alvtor_Hartho_15.FSM;
namespace {FileCreator.NameSpace}
{{
	public class State{stateNumber} : State
	{{
		public {robotId} OurRobot {{ get; set; }}
		public State{stateNumber} ({robotId} ourRobot) : base (ourRobot)
		{{
			OurRobot = ourRobot;
		}}

		public override State StateChangeRelevance()
		{{
			if ({(stateNumber == 0 ? dnaTranslator.GetFirstToSecondStateTransitionContent() : dnaTranslator.GetSecondToFirstStateTransitionContent())})
				return new State{(stateNumber == 0 ? stateNumber+1 : stateNumber-1)} (OurRobot);

			return this;
		}}

		public override void EnterState()
		{{
			OurRobot.BodyColor = Color.{(stateNumber == 0 ? "Green" : "Red")};
//			OurRobot.BodyColor = Color.FromArgb({Random.Next(256)}, {Random.Next(256)}, {Random.Next(256)});
			{(stateNumber == 0 ? dnaTranslator.GetFirstStateEnterMethodContent() : dnaTranslator.GetSecondStateEnterMethodContent())}
		}}

		public override void DoStateAction()
		{{
			{(stateNumber == 0 ? dnaTranslator.GetFirstStateDoStateActionMethodContent() : dnaTranslator.GetSecondStateDoStateActionMethodContent())}
		}}

		public override void ExitState()
		{{
			{(stateNumber == 0 ? dnaTranslator.GetFirstStateLeaveMethodContent() : dnaTranslator.GetSecondStateLeaveMethodContent())}
		}}
	}}
}}";
		}
	}
}
