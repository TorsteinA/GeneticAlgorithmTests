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
			DLLFileCreator.CreateDll(_dllDirectoryPath, generation, individual);
			BattleFileCreator.CreateBattleFiles(_directoryPath, NameSpace, GetRobotName(generation, individual));	
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

		internal static string GetRobotName(int generation , int individualNumber) {
            return "Robot_g" + generation.ToString("D4") + "_i" + individualNumber.ToString("D4");
		}
	}
}