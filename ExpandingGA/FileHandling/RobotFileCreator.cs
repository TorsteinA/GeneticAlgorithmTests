namespace GeneticAlgorithmForStrings
{
	internal class RobotFileCreator
	{
		internal static void CreateRobotFiles(string filePath, string robotId, Individual genes, DnaToCode dnaTranslator) {
			//Create Robot_gX_iY.cs
			FileCreator.CreateFile(
				filePath,
				$"{robotId}{FileCreator.CodeFileExtension}",
				GetFileText(robotId, dnaTranslator),
				true
			);
		}

		internal static string GetFileText(string robotId, DnaToCode dnaTranslator) {
			var imports = $"using System;" +
						"\nusing System.Drawing;" +
						"\nusing Robocode;" +
						"\nusing Santom;" +
                        "\nusing Alvtor_Hartho_15.FSM;" +
                        "\nusing ExampleSetup.Robocode;" +
			            "\n";

			var classInfo = $"\nnamespace {FileCreator.NameSpace} {{    //GARICS: Genetic Algorithm Robot in C Sharp" +
			                "\npublic class " + robotId + " : Alvtor_Hartho_15.Garics {";

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

		internal static string GetRobotId(int generation, int individualNumber) {
			return "Robot_g" + generation.ToString("D4") + "_i" + individualNumber.ToString("D4");
		}
	}
}