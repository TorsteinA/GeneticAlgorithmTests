using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeneticAlgorithmForStrings {
	internal class FileCreator
	{
		internal const string RootFolderName = @"RobotCreator",	//Root Folder for robots
							PopulationsFolderName = "Populations",	//Folder for robot populations.
							DllFolderName = "DLL",					//Folder for robot Dll's.
							NameSpace = "Alvtor_Hartho_15",
							CodeFileExtension = ".cs";

		private readonly string _directoryPath,
								_dllDirectoryPath;

		internal FileCreator(int generation, Population population)
		{
			_dllDirectoryPath = Path.Combine(RootFolderName, DllFolderName);
			_directoryPath = Path.Combine(RootFolderName, GetRobotFolderName(generation));

			Directory.CreateDirectory(_directoryPath);
			Directory.CreateDirectory(_dllDirectoryPath);
			Directory.CreateDirectory(Path.Combine(RootFolderName, PopulationsFolderName));

			PopulationFileHandler.CreateFile(generation, population);

			var tasks = new Task[population.Size()];

			for (var i = 0; i < population.Size(); i++)
			{
				Console.WriteLine($"Starting bot {i}");
				var individual = i;
				tasks[individual] = Task.Factory.StartNew(() => CreateFiles(generation, individual, population.GetIndividual(individual)));
			}

			Task.WaitAll(tasks); // wait for all tasks to finish
			Console.WriteLine($"Finished generation {generation:D4}");
		}

		private void CreateFiles(int generation, int individual, Individual genes) {
			// assign robot name
			var robotId = RobotFileCreator.GetRobotId(generation, individual);

			// create dir path and directory
			var robotDirectoryPath = Path.Combine(_directoryPath, robotId);
			Directory.CreateDirectory(robotDirectoryPath);

			var dirPathFull = Path.Combine(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName),
				robotDirectoryPath);

			var dllFileCreator = new DllFileCreator();
			var battleFileCreator = new BattleFileCreator();
			var robotFileCreator = new RobotFileCreator();
			var stateCreator = new RobotStateFileCreator();

			var dnaTranslator = new DnaToCode(genes);	//In later iteration, replace with Factory
			// create files, compile robot
			robotFileCreator.CreateRobotFiles(robotDirectoryPath, robotId, dnaTranslator);
			stateCreator.CreateStateFiles(robotDirectoryPath, robotId, dnaTranslator);
			dllFileCreator.CreateDll(_dllDirectoryPath, robotDirectoryPath, robotId, dnaTranslator);
			battleFileCreator.CreateBattleFiles(robotDirectoryPath, NameSpace, robotId);

			// run battles
			RoboCodeMatchHandler.RunBattles(dirPathFull);

			// read results and pick the best bots
			// todo: get elites

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
				Console.WriteLine(!File.Exists(pathIncludingFile) ? "File \"{0}\" Created!" : "File \"{0}\" overwritten!", filePath + "\\" + name);
				// Create and write to file.
				using (var fs = File.Create(pathIncludingFile))
				{
					var info = new UTF8Encoding(true).GetBytes(contents);
					fs.Write(info, 0, info.Length);
					fs.Close();
				}
			}
		}

		private static string GetRobotFolderName(int generation) => $"Robots_gen{generation:D4}";
	}
}