using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;

namespace GeneticAlgorithmForStrings {
    class FileCreator
    {
        private static readonly string _folderName = @"RobotCreator/";   //Root Folder for robots
		private readonly string _fileExtension = ".cs";
		private string _pathString;
        private string _fileName;

		//TODO print 0001 instead of 1, 0023 instead of 23. This is to keep things sorted when there's hundreds of entities

        public FileCreator(int generation, int individual) {
			_pathString = System.IO.Path.Combine(_folderName, "Robots_gen" + generation);
			_fileName = GetFileName(generation, individual) + _fileExtension;
            System.IO.Directory.CreateDirectory(_pathString);
            
            Console.WriteLine("Path to my file: {0}\n", _pathString);

			CreateFile(generation, individual);
        }

		private void CreateFile(int generation, int individual) {

			_pathString = System.IO.Path.Combine(_pathString, _fileName);
			if (!System.IO.File.Exists(_pathString)) {
				using (System.IO.FileStream fs = System.IO.File.Create(_pathString)) {

				}
			}
			else {
				Console.WriteLine("File \"{0}\" already exists.", _fileName);
//                return;	 //Use to prevent overwriting existing files
			}

			// Create the file.
			using (FileStream fs = File.Create(_pathString)) {
				// Get together the pieces that goes into file.
				Byte[] info = new UTF8Encoding(true).GetBytes(CreateFirstPartOfRobot(generation, individual) +
													CreateMidPartOfRobot() +
													CreateLastPartOfRobot());

			    #region DLL generation

			    var dllPathString = $"Robots_DLL";
			    Directory.CreateDirectory(dllPathString);

			    var classString = CreateFirstPartOfRobot(generation, individual) +
			                      CreateMidPartOfRobot() +
			                      CreateLastPartOfRobot();

			    var csc = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", "v4.62" } });
			    var parameters =
			        new CompilerParameters(new[] {"mscorlib.dll", "System.Core.dll", "Robocode.dll"}, $"{GetFileName(generation, individual)}.dll", true)
			        {
			            GenerateExecutable = false,
			            //TODO: get write access to subdirs
//			            OutputAssembly = dllPathString
			        };
			    var results = csc.CompileAssemblyFromSource(parameters,
			        classString);
			    results.Errors.Cast<CompilerError>().ToList().ForEach(error => Console.WriteLine(error.ErrorText));

			    #endregion

				// Add information to the file.
				fs.Write(info, 0, info.Length);
			}
		}

		private string CreateFirstPartOfRobot(int generation, int individual) {
            var imports = "using System;" +
						  "\nusing System.Collections.Generic;" +
						  "\nusing System.Linq;" +
						  "\nusing System.Text;" +
						  "\nusing Robocode;" +
                          "\n";

            var classInfo = "\nnamespace GARICS {    //GARICS: Genetic Algorithm Robot in C Sharp" +	//GARICS: Genetic Algorithm Robot in C Sharp
							"\n\tclass " + GetFileName(generation, individual) + " : Robot {";

			var runMethod = "\n\t\tpublic override void Run() {" +
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

            var methods = "\n\t\tpublic override void OnScannedRobot(ScannedRobotEvent e) {" +
						  "\n\t\t\tFire(1);" +
						  "\n\t\t}" + 
						  "\n" + //Fill more methods here that bot can use. 
						  "\n\t\tpublic void WriteHelloWorld() {" +
                          "\n";

            return imports + classInfo + runMethod + methods;
        }

		//This is where we fill in with code based on genes
		private string CreateMidPartOfRobot() { 
            var middle = "\t\t\tConsole.WriteLine(\"Hello World!\");";
			middle += "\n\t\t\t//Now with comments!";
			return middle;
        }

        private string CreateLastPartOfRobot() {
            return "\n\t\t}" +
				   "\n\t}" +
				   "\n}";
        }

        private string GetFileName(int generation , int individualNumber) {
            var fileName = "Robot_g";
            fileName += generation;
            fileName += "_i";
            fileName += individualNumber;

            return fileName;
        }
    }
}