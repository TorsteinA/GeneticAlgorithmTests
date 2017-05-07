using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.CSharp;

namespace GeneticAlgorithmForStrings
{
    internal class DllFileCreator
    {
	    private const string FileExtension = "cs";

	    internal static void CreateDll(string dllDirPath, string robotDirPath, string robotId, DnaToCode dnaTranslator, int numberOfStates = 2)
	    {
		    var robotPath = Path.Combine(robotDirPath, robotId); // the path to the robot including dirs
		    var files = new string[numberOfStates+1]; // initialise array to hold all states and robot
		    files[0] = $"{robotPath}.{FileExtension}"; //add robot to the array

		    for (var i = 0; i < numberOfStates; i++) // add states to the array
		    {
			    files[i+1] = $"{robotPath}_state{i}.{FileExtension}";
		    }


		    var parameters = new CompilerParameters
		    {
			    GenerateInMemory = false, // save assembly as physical file
			    IncludeDebugInformation = true, // generate debug info
			    TreatWarningsAsErrors = true, // treat warnings as errors — this might cause breakage with empty if statements and loops
			    CompilerOptions = "/optimize", //optimize output
			    MainClass = robotId, // Specify the class that contains the Main method of the exe. Probably useless with dlls
			    OutputAssembly = $"{dllDirPath}/Alvtor_Hartho_15-{robotId}.dll", //output string
			    GenerateExecutable = false, //create .dll, not .exe
			    ReferencedAssemblies =
			    {
				    "mscorlib.dll",
				    "System.Core.dll",
				    "Robocode.dll",
				    "Helpers.dll",
				    "System.Drawing.dll"
			    }
		    };

		    var codeProvider = new CSharpCodeProvider(new Dictionary<string, string> {{"CompilerVersion", "v4.0"}}); // create provider and generate results
		    var results = codeProvider.CompileAssemblyFromFile(parameters, files);

		    results.Errors.Cast<CompilerError>().ToList().ForEach(error =>
				Console.WriteLine($"Error in file {error.FileName}: {error.ErrorText} ({error.Line}, {error.Column})")); // log errors in console
	    }
    }
}