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

		private const string FolderName = @"RobotCreator/", //Root Folder for robots
							 NameSpace = "GARICS",
							 FileExtension = ".cs";

		private readonly string _directoryPath, 
								_dllDirectoryPath,
								_codeFileName;

		internal FileCreator(int generation, int individual) {
			var robotName = GetFileName(generation, individual);

			_codeFileName = robotName + FileExtension;
			_dllDirectoryPath = System.IO.Path.Combine(FolderName, "DLL");
			_directoryPath = System.IO.Path.Combine(FolderName, "Robots_gen" + generation.ToString("D4"));

			System.IO.Directory.CreateDirectory(_directoryPath);
			System.IO.Directory.CreateDirectory(_dllDirectoryPath);
			
			CreateCodeFile(generation, individual);
			CreateDll(generation, individual);
			BattleFileCreator.CreateBattleFiles(_directoryPath, NameSpace, robotName);
		}

		private void CreateCodeFile(int generation, int individual)
	    {
			CreateFile(_directoryPath, _codeFileName, 
				CreateFirstPartOfRobot(generation, individual) +
			                             CreateMidPartOfRobot() +
			                             CreateLastPartOfRobot());
	    }

		private void CreateDll(int generation, int individual) {

		    var classCodeAsString = CreateFirstPartOfRobot(generation, individual) +
		                            CreateMidPartOfRobot() +
		                            CreateLastPartOfRobot();

            var csc = new CSharpCodeProvider(new Dictionary<string, string>() {{"CompilerVersion", "v4.0"}});
            var parameters =
                new CompilerParameters(new[] {"mscorlib.dll", "System.Core.dll", "Robocode.dll"},
                    $"{GetFileName(generation, individual)}.dll", true)
                {
                    GenerateExecutable = false,
                    //TODO: get write access to subdirs
//			            OutputAssembly = _directoryPath
                };
            var results = csc.CompileAssemblyFromSource(parameters,
                classCodeAsString);
            results.Errors.Cast<CompilerError>().ToList().ForEach(error => Console.WriteLine(error.ErrorText));

	    }

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

		private static string CreateFirstPartOfRobot(int generation, int individual) {
            const string imports = "using System;" +
                                   "\nusing System.Collections.Generic;" +
                                   "\nusing System.Linq;" +
                                   "\nusing System.Text;" +
                                   "\nusing Robocode;" +
                                   "\n";

            var classInfo = $"\nnamespace {NameSpace} {{    //GARICS: Genetic Algorithm Robot in C Sharp" +	//GARICS: Genetic Algorithm Robot in C Sharp
							"\n\tclass " + GetFileName(generation, individual) + " : Robot {";

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
                                   "\n\t\t\tFire(1);" +
                                   "\n\t\t}" + 
                                   "\n" + //Fill more methods here that bot can use. 
                                   "\n\t\tpublic void WriteHelloWorld() {" +
                                   "\n";

            return imports + classInfo + runMethod + methods;
        }

		private string CreateMidPartOfRobot() {
			var middle = "\t\t\tConsole.WriteLine(\"Hello World!\");";
			//TODO This is where we fill in with code based on genes
			middle += "\n\t\t\t//Now with comments!";
			return middle;
        }

		private static string CreateLastPartOfRobot() {
            return "\n\t\t}" +
				   "\n\t}" +
				   "\n}";
        }

		private static string GetFileName(int generation , int individualNumber) {
            var fileName = "Robot_g";
            fileName += generation.ToString("D4");
            fileName += "_i";
            fileName += individualNumber.ToString("D4");

            return fileName;
        }
	}
}