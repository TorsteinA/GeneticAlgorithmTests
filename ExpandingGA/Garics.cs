using Robocode;
using SeaSharpBot.FSM;
using SeaSharpBot.Helpers;

namespace GeneticAlgorithmForStrings {
	public abstract class Garics : AdvancedRobot {
		internal EnemyData Enemy { get; set; }
		internal EnemyData OldEnemy;
		internal double OldEnemyHeading;
		internal StateManagerScript StateManager;
	}
}