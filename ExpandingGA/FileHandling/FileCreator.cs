using System;
using System.IO;
using System.Text;

namespace GeneticAlgorithmForStrings {
	internal class FileCreator
	{
		internal const string RootFolderName = @"RobotCreator/",	//Root Folder for robots
							PopulationsFolderName = "Populations",	//Folder for robot populations.
							DllFolderName = "DLL",					//Folder for robot Dll's.
							NameSpace = "Alvtor_Hartho_15",
							CodeFileExtension = ".cs";

		private readonly string _directoryPath,
								_dllDirectoryPath;

		private static DnaToCode _dnaTranslator;

		internal FileCreator(int generation, Population population)
		{
			_dllDirectoryPath = Path.Combine(RootFolderName, DllFolderName);
			_directoryPath = Path.Combine(RootFolderName, GetRobotFolderName(generation));

			Directory.CreateDirectory(_directoryPath);
			Directory.CreateDirectory(_dllDirectoryPath);
			Directory.CreateDirectory(Path.Combine(RootFolderName, PopulationsFolderName));

			PopulationFileHandler.CreateFile(generation, population);
			for (var i = 0; i < population.Size(); i++)
			{
				CreateFiles(generation, i, population.GetIndividual(i));
			}
		}

		private void CreateFiles(int generation, int individual, Individual genes) {
			// assign robot name
			var robotName = RobotFileCreator.GetRobotName(generation, individual);

			// create dir path and directory
			var robotDirectoryPath = Path.Combine(_directoryPath, robotName);
			Directory.CreateDirectory(robotDirectoryPath);

			_dnaTranslator = new DnaToCode(genes);	//In later iteration, replace with Factory
			RobotFileCreator.CreateRobotFiles(robotDirectoryPath, generation, individual, genes, _dnaTranslator);
			RobotStateFileCreator.CreateStateFiles(robotDirectoryPath, generation, individual, _dnaTranslator);
			DllFileCreator.CreateDll(_dllDirectoryPath, generation, individual, _dnaTranslator);
			BattleFileCreator.CreateBattleFiles(robotDirectoryPath, NameSpace, robotName);
		}

		internal static void CreateFile(string filePath, string name, string contents, bool overwrite) {
			var pathIncludingFile = Path.Combine(filePath, name);


			if (!overwrite)
			{
				if (!File.Exists(pathIncludingFile))
				{
					Console.WriteLine($"File \"{name}\" created!");
					File.WriteAllText(pathIncludingFile, contents);
				}
				else
				{
					Console.WriteLine($"File \"{name}\" already exists. Did not overwrite");
				}
			}
			else
			{
				Console.WriteLine(!File.Exists(pathIncludingFile) ? "File \"{0}\" Created!" : "File \"{0}\" overwritten!", filePath + "/" + name);
				// Create and write to file.
				using (var fs = File.Create(pathIncludingFile))
				{
					var info = new UTF8Encoding(true).GetBytes(contents);
					fs.Write(info, 0, info.Length);
					fs.Close();
				}
			}
		}

		private static string GetRobotFolderName(int generation)
		{
			return "Robots_gen" + generation.ToString("D4");
		}
	}
}