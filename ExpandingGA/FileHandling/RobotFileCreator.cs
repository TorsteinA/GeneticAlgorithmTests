namespace GeneticAlgorithmForStrings
{
	internal class RobotFileCreator
	{
		internal static void CreateRobotFiles(string filePath, int generation, int individual, Individual genes, DnaToCode dnaTranslator) {
			//Create Robot_gX_iY.cs
			FileCreator.CreateFile(
				filePath,
				$"{GetRobotName(generation, individual)}{FileCreator.CodeFileExtension}",
				GetFileText(generation, individual, dnaTranslator),
				true
			);
		}

		internal static string GetFileText(int generation, int individual, DnaToCode dnaTranslator) {
			var imports = $"using System;" +
//						"\nusing System.CodeDom.Compiler;" +
						"\nusing System.Collections.Generic;" +
						"\nusing System.IO;" +
						"\nusing System.Linq;" +
						"\nusing System.Text;" +
						"\nusing Robocode;" +
						"\nusing Santom;" +
						"\nusing Alvtor_Hartho_15;" +
                        "\nusing Alvtor_Hartho_15.FSM;" +
                        "\nusing ExampleSetup.Robocode;" +

//						"\nusing Microsoft.CSharp;" +
			            "\n";

			var classInfo = $"\nnamespace {FileCreator.NameSpace} {{    //GARICS: Genetic Algorithm Robot in C Sharp" +
			                "\nclass " + GetRobotName(generation, individual) + " : Alvtor_Hartho_15.Garics {";

			var fields = "\n" + dnaTranslator.GetVariableDeclarations();

			var runMethod = "\n\t\tpublic override void Run() {" +
			                "\n\t\t\tEnemy = new EnemyData();" +
			                "\n\t\t\tStateManager = new StateManagerScript(new State0(this));" +
			                "\n" + dnaTranslator.GetVariableInitialisations() +
							"\n" +
			 			    "\n\t\t\twhile (true) {" +
			                "\n\t\t\t\tStateManager.FrameCheck();" +
			 			    "\n\t\t\t\tExecute();" +
			                "\n\t\t\t\tOldEnemy = Enemy;" +
			                "\n\t\t\t}" +
			                "\n\t\t}" +
			                "\n";

			const string methods = "\n\t\tpublic override void OnScannedRobot(ScannedRobotEvent e) {" +
			                       "\n\t\t\tvar angleToEnemy = HeadingRadians + e.BearingRadians;" +
			                       "\n\t\t\tvar enemyX = (int)(X + Math.Sin(angleToEnemy) * e.Distance);" +
			                       "\n\t\t\tvar enemyY = (int)(Y + Math.Cos(angleToEnemy) * e.Distance);" +
			                       "\n\t\t\tEnemy.SetEnemyData(e, new Point2D(enemyX, enemyY));" +
			                       "\n\t\t}";

			const string end = "\n\t}" +
			                   "\n}";

			return imports + classInfo + fields + runMethod + methods + end;
		}

		internal static string GetRobotName(int generation, int individualNumber) {
			return "Robot_g" + generation.ToString("D4") + "_i" + individualNumber.ToString("D4");
		}
	}
}