using System;
using System.IO;
using System.Text;

namespace GeneticAlgorithmForStrings
{
    public class BattleFileCreator
    {
        //The robots to face off against
        private static readonly string[] EnemyRobots =
            {"sample.SittingDuck", "sample.Crazy", "sample.Tracker", "sample.Corners"};

        //Number of rounds per battle
        private const int NumberOfRounds = 10;

        public static void CreateBattleFiles(string filePath, string nameSpace, string robotName)
        {
            foreach (var enemyRobot in EnemyRobots)
            {
                CreateFile(filePath, $"{robotName}_vs_{enemyRobot}.battle",
                    GetFileText($"{nameSpace}.{robotName}", enemyRobot));
            }
        }

        private static string GetFileText(string robotName, string enemyName)
        {
            return $@"#Battle Properties
robocode.battleField.width=800
robocode.battleField.height=600
robocode.battle.numRounds={NumberOfRounds}
robocode.battle.gunCoolingRate=0.1
robocode.battle.rules.inactivityTime=450
robocode.battle.selectedRobots={robotName},{enemyName}
robocode.battle.initialPositions=(50,50,0),(?,?,?)";
        }

        //TODO: write files
        private static void CreateFile(string filePath, string name, string contents)
        {
            var pathIncludingFile = System.IO.Path.Combine(filePath, name);

            if (!File.Exists(pathIncludingFile))
            {
                File.Create(pathIncludingFile);
            }
            else
            {
                Console.WriteLine($"File \"{name}\" already exists.");
//                return;	 //Use to prevent overwriting existing files
            }

/*
            using (var fs = File.Create(pathIncludingFile))
            {
                // Get together the pieces that goes into file.
                var info = new UTF8Encoding(true).GetBytes(contents);


                // Add information to the file.
                fs.Write(info, 0, info.Length);
                fs.Close();*/

            //Dette virket som en enklere måte å skrive ut på
            File.WriteAllText(pathIncludingFile, contents);
        }
    }
}