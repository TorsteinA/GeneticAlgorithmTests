using System;
using System.IO;
using System.Text;

namespace GeneticAlgorithmForStrings {
	public class BattleFileCreator {
		//The robots to face off against
		private static readonly string[] EnemyRobots =
			{"sample.SittingDuck", "sample.Crazy", "sample.Tracker", "sample.Corners"};

		//Number of rounds per battle
		private const int NumberOfRounds = 10;

		public static void CreateBattleFiles(string filePath, string nameSpace, string robotName) {
			foreach (var enemyRobot in EnemyRobots) {
				FileCreator.CreateFile(filePath, $"{robotName}_vs_{enemyRobot}.battle",
					GetFileText($"{nameSpace}.{robotName}", enemyRobot));
			}
		}

		private static string GetFileText(string robotName, string enemyName) {
			return $@"#Battle Properties
robocode.battleField.width=800
robocode.battleField.height=600
robocode.battle.numRounds={NumberOfRounds}
robocode.battle.gunCoolingRate=0.1
robocode.battle.rules.inactivityTime=450
robocode.battle.selectedRobots={robotName},{enemyName}
robocode.battle.initialPositions=(50,50,0),(?,?,?)";
		}

		
	}
}