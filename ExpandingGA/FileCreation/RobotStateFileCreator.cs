using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmForStrings {
	internal class RobotStateFileCreator {

		internal static void CreateStateFiles(string filePath, int generation, int individual, DnaToCode dnaTranslator) {
			for (var i = 0; i <= 1; i++) {
				FileCreator.CreateFile(
					filePath,
					$"{FileCreator.GetRobotName(generation, individual)}_State{i}{FileCreator.CodeFileExtension}",
					GetFileText(i, dnaTranslator)
				);
			}
		}

		private static string GetFileText(int stateNumber, DnaToCode dnaTranslator)
		{
			return "using System;" +
			       "\nusing System.Drawing;" +
                   "\nusing Alvtor_Hartho_15;" +
			       $"\nnamespace {FileCreator.NameSpace} {{" +
			       "\n\tpublic class State" + stateNumber + " : State {" +
			       "\n\t\tpublic State" + stateNumber + "(Garics ourRobot){" +
			       "\n\t\t\tOurRobot = ourRobot;" +
			       "\n\t\t}" +
			       "\n" +
			       "\n\t\tpublic override State StateChangeRelevance(){" +
				   "\n\t\t\tif (" + (stateNumber == 0 ? dnaTranslator.GetFirstToSecondStateTransitionContent() : dnaTranslator.GetSecondToFirstStateTransitionContent()) + ")" +	//Assumes stateNumber is always 0 or 1.
				   "\n\t\t\t\treturn new State" + (stateNumber == 0 ? stateNumber+1 : stateNumber-1) + "(OurRobot);" +																//Assumes stateNumber is always 0 or 1.
			       "\n\n\t\t\treturn this;" +
				   "\n\t\t}" +
			       "\n" +
			       "\n\t\tpublic override void EnterState(){" +
			       "\n\t\t\tOurRobot.BodyColor = Color.Green;" +
			       "\n\t\t\t" + (stateNumber == 0 ? dnaTranslator.GetFirstStateEnterMethodContent() : dnaTranslator.GetSecondStateEnterMethodContent()) +                           //Assumes stateNumber is always 0 or 1.
				   "\n\t\t}" +
			       "\n" +
			       "\n\t\tpublic override void DoStateAction(){" +
			       "\n\t\t\t" + (stateNumber == 0 ? dnaTranslator.GetFirstStateDoStateActionMethodContent() : dnaTranslator.GetSecondStateDoStateActionMethodContent()) +           //Assumes stateNumber is always 0 or 1.
				   "\n\t\t}" +
			       "\n" +
			       "\n\t\tpublic override void ExitState(){" +
			       "\n\t\t\t" + (stateNumber == 0 ? dnaTranslator.GetFirstStateLeaveMethodContent() : dnaTranslator.GetSecondStateLeaveMethodContent()) +                           //Assumes stateNumber is always 0 or 1.
				   "\n\t\t}" +
			       "\n\t}" +
			       "\n}";
		}
	}
}
