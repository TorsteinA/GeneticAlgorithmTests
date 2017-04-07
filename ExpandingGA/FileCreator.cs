using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.CSharp;

namespace GeneticAlgorithmForStrings {
	internal class FileCreator
	{
		//TODO Refactor fileCreator and BattleFileCreator to Superclass FileCreator, and subclasses BattleFileCreator, CodeFileCreator?

		private const string FolderName = @"RobotCreator/"; //Root Folder for robots
		internal const string NameSpace = "GARICS",
							CodeFileExtension = ".cs";

		private readonly string _directoryPath, 
								_dllDirectoryPath;
		
		internal FileCreator(int generation, int individual) {
			
			_dllDirectoryPath = System.IO.Path.Combine(FolderName, "DLL");
			_directoryPath = System.IO.Path.Combine(FolderName, "Robots_gen" + generation.ToString("D4"));

			System.IO.Directory.CreateDirectory(_directoryPath);
			System.IO.Directory.CreateDirectory(_dllDirectoryPath);
			
			CreateFiles(generation, individual);
		}

		private void CreateFiles(int generation, int individual) {
			RobotFileCreator.CreateRobotFiles(_directoryPath, generation, individual);						//The robot itself
			//TODO		AddConstantClasses();							//Classes that won't change between individuals that robot needs to work.
			DLLFileCreator.CreateDll(_dllDirectoryPath, generation, individual);	//TODO Separate class for DLL creation
			BattleFileCreator.CreateBattleFiles(_directoryPath, NameSpace, GetRobotName(generation, individual));	
		}
//
//		private void CreateRobotCodeFile(int generation, int individual) {
//			CreateFile(_directoryPath, _robotCodeFileName, 
//				CreateFirstPartOfRobot(generation, individual) +
//			                             CreateMidPartOfRobot() +
//			                             CreateLastPartOfRobot());
//	    }

//		 Without quite knowing how DLLs work, We should probably refactor so it works for more than just the robot.cs file sources, and compiles a bot from all the files it needs.
//		private void CreateDll(int generation, int individual) {
//
//			var classCodeAsString = RobotFileCreator.GetFileText(generation, individual);
//
//			var csc = new CSharpCodeProvider(new Dictionary<string, string>() {{"CompilerVersion", "v4.0"}});
//            var parameters =
//                new CompilerParameters(new[] {"mscorlib.dll", "System.Core.dll", "Robocode.dll"},
//                    $"{_dllDirectoryPath}/{GetRobotName(generation, individual)}.dll", true)
//                {
//                    GenerateExecutable = false,
//                    //TODO: get write access to subdirs
////			            OutputAssembly = _directoryPath
//                };
//            var results = csc.CompileAssemblyFromSource(parameters,
//                classCodeAsString);
//            results.Errors.Cast<CompilerError>().ToList().ForEach(error => Console.WriteLine(error.ErrorText));
//
//	    }

		internal static void CreateFile(string filePath, string name, string contents) {
			var pathIncludingFile = System.IO.Path.Combine(filePath, name);

			/** If we don't want to overwrite, the code changes a bit
			if (!File.Exists(pathIncludingFile)) {
					Console.WriteLine($"File \"{name}\" created!");
					File.WriteAllText(pathIncludingFile, contents);
				}
				else {
					Console.WriteLine($"File \"{name}\" already exists. Did not overwrite");
				}
			*/

			Console.WriteLine(!System.IO.File.Exists(pathIncludingFile) ? "File \"{0}\" Created!" : "File \"{0}\" overwritten!", filePath + name);

			// Create and write to file.
			using (var fs = File.Create(pathIncludingFile)) {
				var info = new UTF8Encoding(true).GetBytes(contents);
				fs.Write(info, 0, info.Length);
				fs.Close();
			}
		}
//
//		private static string CreateFirstPartOfRobot(int generation, int individual) {
//            const string imports = "using System;" +
//                                   "\nusing System.Collections.Generic;" +
//                                   "\nusing System.Linq;" +
//                                   "\nusing System.Text;" +
//                                   "\nusing Robocode;" +
//                                   "\n";
//
//            var classInfo = $"\nnamespace {NameSpace} {{    //GARICS: Genetic Algorithm Robot in C Sharp" +	//GARICS: Genetic Algorithm Robot in C Sharp
//							"\n\tclass " + GetRobotName(generation, individual) + " : Robot {";
//
//		    const string fields = "\npublic EnemyData Enemy { get; set; } = null;" +
//                                  "\nprivate StateManagerScript _stateManager;" +
//		                          "\n" +
//		                          "\n";
//
//
//            const string runMethod = "\n\t\tpublic override void Run() {" +
//			                         "\n\n\t\t\t//Proving we can call methods and use comments" +
//			                         "\n\t\t\t//WriteHelloWorld();" +
//			                         "\n\n\t\t\t//We should probably do something useful though" +
//			                         "\n\t\t\tTurnLeft(Heading - 90);" +
//			                         "\n\t\t\tTurnRight(90);" +
//			                         "\n" +
//			                         "\n\t\t\twhile (true) {" +
//			                         "\n\t\t\t\tAhead(5000);" +
//			                         "\n" +
//			                         "\n\t\t\t\tTurnRight(90);" +
//			                         "\n\t\t\t}" +
//			                         "\n\t\t}" +
//			                         "\n";
//
//            const string methods = "\n\t\tpublic override void OnScannedRobot(ScannedRobotEvent e) {" +
//                                   "\n\t\t\t// Absolute angle towards target;" +
//                                   "\n\t\t\tvar angleToEnemy = HeadingRadians + e.BearingRadians;;" +
//                                   "\n\t\t\tvar angleToEnemy = HeadingRadians + e.BearingRadians;;" +
//                                   "\n\t\t\t//Update enemy data;" +
//                                   "\n\t\t\tvar enemyX = (int)(X + Math.Sin(angleToEnemy) * e.Distance);" +
//                                   "\n\t\t\tvar enemyY = (int)(Y + Math.Cos(angleToEnemy) * e.Distance);" +
//                                   "\n\t\t\tEnemy.SetEnemyData(e, new Point2D(enemyX, enemyY));" +
//                                   "\n\t\t}" + 
//                                   "\n" + //Fill more methods here that bot can use. 
//
//                                   "\n\t\tpublic void WriteHelloWorld() {" +
//                                   "\n";
//
//            return imports + classInfo + fields + runMethod + methods;
//        }
//
//		private string CreateMidPartOfRobot() {
//			var middle = "\t\t\tConsole.WriteLine(\"Hello World!\");";
//			//TODO This is where we fill in with code based on genes
//			middle += "\n\t\t\t//Now with comments!";
//			return middle;
//        }
//
//		private static string CreateLastPartOfRobot() {
//            return "\n\t\t}" +
//				   "\n\t}" +
//				   "\n}";
//        }

		internal static string GetRobotName(int generation , int individualNumber) {
            return "Robot_g" + generation.ToString("D4") + "_i" + individualNumber.ToString("D4");
		}
	}
}