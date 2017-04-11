namespace GeneticAlgorithmForStrings
{
	internal class RobotFileCreator
	{
		internal static void CreateRobotFiles(string filePath, int generation, int individual) {
			FileCreator.CreateFile(
				filePath,
				$"{FileCreator.GetRobotName(generation, individual)}{FileCreator.CodeFileExtension}",
				GetFileText(generation, individual)
			);
			RobotStateFileCreator.CreateStateFiles(filePath, generation, individual);
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
			                "\n\tclass " + FileCreator.GetRobotName(generation, individual) + " : Robot {";

			var fields = "\n\t\tpublic EnemyData Enemy { get; set; } = null;" +
			             "\n\t\tprivate StateManagerScript _stateManager;" +
			             "\n\t\t" +	//TODO Get variables from DNA Translator
			             "\n";

			const string runMethod = "\n\t\tpublic override void Run() {" +
			                         "\n\n\t\t\t//Proving we can call methods and use comments" +
			                         "\n\t\t\t//WriteHelloWorld();" +
			                         "\n\n\t\t\t//We should probably do something useful though" +
			                         "\n\t\t\tTurnLeft(Heading - 90);" +
			                         "\n\t\t\tTurnRight(90);" +
			                         "\n" +
			                         "\n\t\t\twhile (true) {" +
			                         "\n\t\t\t\tAhead(5000);" +
			                         "\n" +
			                         "\n\t\t\t\tTurnRight(90);" +
			                         "\n\t\t\t}" +
			                         "\n\t\t}" +
			                         "\n";

			const string methods = "\n\t\tpublic override void OnScannedRobot(ScannedRobotEvent e) {" +
			                       "\n\t\t\t// Absolute angle towards target;" +
			                       "\n\t\t\tvar angleToEnemy = HeadingRadians + e.BearingRadians;" +
			                       "\n\t\t\t//Update enemy data;" +
			                       "\n\t\t\tvar enemyX = (int)(X + Math.Sin(angleToEnemy) * e.Distance);" +
			                       "\n\t\t\tvar enemyY = (int)(Y + Math.Cos(angleToEnemy) * e.Distance);" +
			                       "\n\t\t\tEnemy.SetEnemyData(e, new Point2D(enemyX, enemyY));" +
			                       "\n\t\t}" +
			                       "\n" + //Fill more methods here that bot can use. 

			                       "\n\t\tpublic void WriteHelloWorld() {" +
			                       "\n";

			var middle = "\t\t\tConsole.WriteLine(\"Hello World!\");";
						//TODO This is where we fill in with code based on genes
						middle += "\n\t\t\t//Now with comments!";
						
			const string end = "\n\t\t}" +
			                   "\n\t}" +
			                   "\n}";

			return imports + classInfo + fields + runMethod + methods + middle + end;
		}
	}
}