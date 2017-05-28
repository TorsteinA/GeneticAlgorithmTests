﻿using System;
using System.IO;
using System.Text;

namespace GeneticAlgorithmForStrings {
	internal class BattleFileCreator {
		//The robots to face off against
		private static readonly string[] EnemyRobots =
			{"Alvtor_Hartho_15.Robot_g0009_i0006", "Alvtor_Hartho_15.Robot_g0006_i0001", "Alvtor_Hartho_15.Robot_g0004_i0014", "SeaSharpBot.SeaSharpBot"};

		//Number of rounds per battle
		private const int NumberOfRounds = 10;

		internal void CreateBattleFiles(string filePath, string nameSpace, string robotName) {
			foreach (var enemyRobot in EnemyRobots) {
				FileCreator.CreateFile(
					filePath, 
					$"{robotName}_vs_{enemyRobot}.battle",
					GetFileText($"{nameSpace}.{robotName}", enemyRobot),
					true
				);
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
robocode.battle.initialPositions=(?,?,?),(?,?,?)";
		}
	}
}