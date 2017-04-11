using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmForStrings {
	internal class RobotStateFileCreator {
		
		internal static void CreateStateFiles(string filePath, int generation, int individual) {
			for (var i = 0; i <= 1; i++) {
				FileCreator.CreateFile(
					filePath,
					$"{FileCreator.GetRobotName(generation, individual)}_State{i}{FileCreator.CodeFileExtension}",
					GetFileText(i)
				);
			}
		}

		//TODO Fill in text to go in state files. 
		private static string GetFileText(int stateNumber) {
			return $@"
This is the robots state {stateNumber}
";
		}
	}
}
