using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
///using ExampleSetup.Robocode;
using Microsoft.CSharp;
//using Tomtom;

namespace GeneticAlgorithmForStrings
{
    internal class DllFileCreator
    {
	    private const string FileExtension = "cs";

	    internal void CreateDll(string dllDirPath, string robotDirPath, string robotId, DnaToCode dnaTranslator, int numberOfStates = 2)
	    {
		    var robotPath = Path.Combine(robotDirPath, robotId); // the path to the robot, including dirs
	        var dllPath = Path.Combine(dllDirPath, $"Alvtor_Hartho_15-{robotId}.dll");
            const string helpersPath = @"../../../Helpers/Robot/";
            var files = new string[17]; // initialise array to hold all states and robot
	        files[0] = $"{robotPath}.{FileExtension}"; //add robot to the array


	        for (var i = 0; i < numberOfStates; i++) // add states to the array
		    {
			    files[i+1] = $"{robotPath}_state{i}.{FileExtension}";
		    }

            string[] dependencies =
		    {
			    "Helpers/EnemyDataHelpers",
			    "FSM/StateManagerScript",
			    "FSM/State",
			    "Garics/Garics",
			    "Helpers/Battlefield",
			    "Helpers/Direction",
			    "Helpers/EnemyData",
			    "Helpers/Point2D",
			    "Helpers/Point2DHelpers",
			    "Helpers/Vector2D",
			    "Helpers/Vector2DHelpers",
			    "Helpers/UtilsVector",
			    "Helpers/RobotVectors",
			    "Helpers/MathHelpers"
		    };

		    for (var i = 0; i < dependencies.Length; i++)
		    {
			    files[i + 3] = $"{helpersPath}{dependencies[i]}.{FileExtension}";
		    }
            
            var parameters = new CompilerParameters
		    {
			    GenerateInMemory = false, // save assembly as physical file
			    IncludeDebugInformation = true, // generate debug info
			    TreatWarningsAsErrors = true, // treat warnings as errors
			    CompilerOptions = "/optimize", //optimize output
//			    MainClass = robotId, // Specify the class that contains the Main method of the executable. Probably useless with dlls
                OutputAssembly = dllPath,
			    GenerateExecutable = false, //create .dll, not .exe
			    ReferencedAssemblies =
			    {
				    "mscorlib.dll",
				    "System.Core.dll",
				    "Robocode.dll",
				    "System.dll",
				    "System.net.dll", // For helpers
//				    "Helpers.dll",
//				    "System.Collections.Generic.dll",
				    "System.Drawing.dll",
			    }
		    };

		    // create provider and generate results
		    var codeProvider = new CSharpCodeProvider(new Dictionary<string, string> { { "CompilerVersion", "v4.0" }, { "AssemblyVersion", "4.5.2.6" } , { "AssemblyTitle", "GARICS" } }); // NOTE: removed constructor parameter: new Dictionary<string, string> {{"CompilerVersion", "v4.0"}}


            Process currentProcess = Process.GetCurrentProcess();
            string folder = Path.Combine(Path.GetDirectoryName(currentProcess.MainModule.FileName), helpersPath);
            string filter = "*.cs";

            string[] filez0 = { $"{robotPath}.{FileExtension}", $"{robotPath}_state0.{FileExtension}", $"{robotPath}_state1.{FileExtension}" };
            string[] filez1 = Directory.GetFiles(Path.Combine(folder, "Helpers"), filter);
	        string[] filez2 = Directory.GetFiles(Path.Combine(folder, "FSM"), filter);
	        string[] filez3 = Directory.GetFiles(Path.Combine(folder, "Garics"), filter);
            string[] filez = filez0.Concat(filez1.Concat(filez2.Concat(filez3))).ToArray();        //Should rename from filez to something more appropriate

//	        var results = codeProvider.CompileAssemblyFromFile(parameters, files);
            var results = codeProvider.CompileAssemblyFromFile(parameters, filez);
            

		    results.Errors.Cast<CompilerError>().ToList().ForEach(error =>
				Console.WriteLine($"Error: {error.FileName}: {error.ErrorText} ({error.Line}, {error.Column})")); // log errors in console

		    // try loading the assembly
		    try
		    {
//			    Assembly.LoadFrom("./Helpers.dll");
//			    Assembly.LoadFrom($"{dllDirPath}/Alvtor_Hartho_15-{robotId}.dll");

                Assembly.LoadFrom(dllPath);
		    }
		    catch (Exception ex)
		    {
			    Console.WriteLine($"Caught exception: {ex.Message}");
			    var typeLoadException = ex as ReflectionTypeLoadException;
			    var loaderExceptions  = typeLoadException?.LoaderExceptions;
			    if (loaderExceptions != null) Console.WriteLine(loaderExceptions);
		    }

	    }
    }
}