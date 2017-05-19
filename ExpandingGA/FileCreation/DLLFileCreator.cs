using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using ExampleSetup.Robocode;
using Microsoft.CSharp;
using Tomtom;

namespace GeneticAlgorithmForStrings
{
    internal class DllFileCreator
    {
	    private const string FileExtension = "cs";

	    internal static void CreateDll(string dllDirPath, string robotDirPath, string robotId, DnaToCode dnaTranslator, int numberOfStates = 2)
	    {
		    var robotPath = Path.Combine(robotDirPath, robotId); // the path to the robot, including dirs
	        var dllPath = Path.Combine(dllDirPath, $"Alvtor_Hartho_15-{robotId}.dll");
//		    var files = new string[numberOfStates+1]; // initialise array to hold all states and robot
	        var files = new string[17]; // initialise array to hold all states and robot
	        files[0] = $"{robotPath}.{FileExtension}"; //add robot to the array


	        for (var i = 0; i < numberOfStates; i++) // add states to the array
		    {
			    files[i+1] = $"{robotPath}_state{i}.{FileExtension}";
		    }

		    const string helpersPath = @"../../../Helpers/Robot/";





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
			    //OutputAssembly = $"{dllDirPath}/Alvtor_Hartho_15-{robotId}.dll", //output string
                OutputAssembly = dllPath,
			    GenerateExecutable = false, //create .dll, not .exe
			    ReferencedAssemblies =
			    {
				    "mscorlib.dll",
				    "System.Core.dll",
				    "Robocode.dll",
				    "System.net.dll", // For helpers
//				    "Helpers.dll",
				    "System.Drawing.dll"
			    }
		    };

		    // create provider and generate results
		    var codeProvider = new CSharpCodeProvider(); // NOTE: removed constructor parameter: new Dictionary<string, string> {{"CompilerVersion", "v4.0"}}




            Process currentProsess = Process.GetCurrentProcess();
            string folder = Path.Combine(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName), helpersPath);
            string filter = "*.cs";
            string[] filez = Directory.GetFiles(folder, filter);
            
//            Console.WriteLine(Path.GetFullPath(folder));
            


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