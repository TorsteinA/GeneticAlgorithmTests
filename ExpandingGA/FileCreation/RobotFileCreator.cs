namespace GeneticAlgorithmForStrings
{
	internal class RobotFileCreator
	{
		private static DnaToCode _dnaTranslator;
		internal static void CreateRobotFiles(string filePath, int generation, int individual, Individual genes) {
			//Create gene translator
			_dnaTranslator = new DnaToCode(genes);

			//Create Robot_gX_iY.cs
			FileCreator.CreateFile(
				filePath,
				$"{FileCreator.GetRobotName(generation, individual)}{FileCreator.CodeFileExtension}",
				GetFileText(generation, individual)
			);

			//Creates state files.
			RobotStateFileCreator.CreateStateFiles(filePath, generation, individual, _dnaTranslator);
		}
		
		internal static string GetFileText(int generation, int individual) {
			var imports = $"using System;" +
//						"\nusing System.CodeDom.Compiler;" +
						"\nusing System.Collections.Generic;" +
						"\nusing System.IO;" +
						"\nusing System.Linq;" +
						"\nusing System.Text;" +
						"\nusing Robocode;" +
//						"\nusing Microsoft.CSharp;" +
			            "\n";

			var classInfo = $"\nnamespace {FileCreator.NameSpace} {{    //GARICS: Genetic Algorithm Robot in C Sharp" +
			                "\nclass " + FileCreator.GetRobotName(generation, individual) + " : Garics {";

			var fields = "\n" + _dnaTranslator.GetVariableDeclarations();

			var runMethod = "\n\t\tpublic override void Run() {" +
			                "\n\t\t\tEnemy = new EnemyData();" +
			                "\n\t\t\t_stateManager = new StateManagerScript(new State0(this));" +
			                "\n" + _dnaTranslator.GetVariableInitialisations() +
							"\n" +
			 			    "\n\t\t\twhile (true) {" +
			                "\n\t\t\t_stateManager.FrameCheck();" +
			 			    "\n\t\t\tExecute();" +
			                "\n\t\t\tOldEnemy = Enemy;" +
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
	}
}