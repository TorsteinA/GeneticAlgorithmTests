using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CSharp;

namespace GeneticAlgorithmForStrings
{
    internal class DllFileCreator
    {
	    internal static void CreateDll(string dllDirPath, int generation, int individual, DnaToCode dnaTranslator)
	    {

		    var classCodeAsString = RobotFileCreator.GetFileText(generation, individual, dnaTranslator);
		    //			classCodeAsString += ...

		    // TODO: add state files etc if they don't get included automatically.
		    //TODO:		AddConstantClasses();							//Classes that won't change between individuals that robot needs to work.

		    var csc = new CSharpCodeProvider(new Dictionary<string, string> {{"CompilerVersion", "v4.0"}});
		    var parameters =
			    new CompilerParameters(new[] {"mscorlib.dll", "System.Core.dll", "Robocode.dll", "Helpers.dll"},
				    $"{dllDirPath}/{RobotFileCreator.GetRobotName(generation, individual)}.dll", true)
			    {
				    GenerateExecutable = false,
			    };
		    var results = csc.CompileAssemblyFromSource(parameters,
			    classCodeAsString);
		    results.Errors.Cast<CompilerError>().ToList().ForEach(error => Console.WriteLine(error.ErrorText));
	    }
    }
}