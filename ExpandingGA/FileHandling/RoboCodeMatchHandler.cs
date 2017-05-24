using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using net.sf.jni4net.jni;
using Robocode;
using Robocode.Control;
using Robocode.Control.Events;
using RobotSpecification = robocode.control.RobotSpecification;

namespace GeneticAlgorithmForStrings
{
    internal class RoboCodeMatchHandler
    {
        private double _resultScore;

        internal RoboCodeMatchHandler(Individual individual, string pathToBattleFiles)
        {
            _resultScore = 0;
            //RunMatches(individual, pathToBattleFiles);
            RunMatch("");
        }

        /// <summary>
        /// Runs matches between individual and pre-selected bots to return a score
        /// </summary>
        /// <param name="individual"></param>
        /// <param name="pathToBattleFiles"></param>
        /// <returns></returns>
        internal void RunMatches(Individual individual, string pathToBattleFiles)
        {
            var battleFiles = Directory.GetFiles(pathToBattleFiles, ".battle");
            _resultScore = battleFiles.Sum(battle => RunMatch(battle));
        }

        private double RunMatch(string battle)
        {
            double result = 0.0;
            
            //Run one robocode battle based on battleFile from directory!
            // Create the RobocodeEngine
            RobocodeEngine engine = new RobocodeEngine("C:\\robocode"); // Run from C:\Robocode
//            RobocodeEngine engine = new RobocodeEngine("C:\\Users\\torstein\\Source\\Repos\\GeneticAlgorithmTests\\ExpandingGA\\bin\\Debug"); // Run from local bin/debug

            // Add battle event handlers
            engine.BattleCompleted += new BattleCompletedEventHandler(BattleCompleted);
            engine.BattleMessage += new BattleMessageEventHandler(BattleMessage);
            engine.BattleError += new BattleErrorEventHandler(BattleError);

            // Show the Robocode battle view
            engine.Visible = true;

            // Disable log messages from Robocode
            RobocodeEngine.LogMessagesEnabled = false;

            // Setup the battle specification

            int numberOfRounds = 5;
            BattlefieldSpecification battlefield = new BattlefieldSpecification(800, 600); // 800x600
//            RobotSpecification[] selectedRobots = engine.GetLocalRepository("sample.RamFire,sample.Corners");           //------ Add battle files somehow ----
            var selectedRobots = engine.GetLocalRepository("sample.RamFire,sample.Corners");                              //------ Add battle files somehow ----
            BattleSpecification battleSpec = new BattleSpecification(numberOfRounds, battlefield, selectedRobots);

            // Run our specified battle and let it run till it is over
            engine.RunBattle(battleSpec, true /* wait till the battle is over */);

            // Cleanup our RobocodeEngine
            engine.Close();












            return result;
        }

        /// <summary>
        /// Uses match parameters to determine max score. 
        /// </summary>
        /// <returns></returns>
        public double GetScore()
        {
            return _resultScore;
        }


        // Called when the battle is completed successfully with battle results
        private static void BattleCompleted(BattleCompletedEvent e) {
            Console.WriteLine("-- Battle has completed --");

            // Print out the sorted results with the robot names
            Console.WriteLine("Battle results:");
            foreach (BattleResults result in e.SortedResults) {
                Console.WriteLine("  " + result.TeamLeaderName + ": " + result.Score);
            }
        }

        // Called when the game sends out an information message during the battle
        private static void BattleMessage(BattleMessageEvent e) {
            Console.WriteLine("Msg> " + e.Message);
        }

        // Called when the game sends out an error message during the battle
        private static void BattleError(BattleErrorEvent e) {
            Console.WriteLine("Err> " + e.Error);
        }

        /// <summary>
        /// Runs all the *.battle files in the specified directory.
        /// Note: runs them sequentially to avoid race conditions, as we cannot control external programs, i.e. cmd.exe
        /// </summary>
        /// <param name="dirPath"></param>
        public static void RunBattles(string dirPath)
        {
            var battleFiles = Directory.GetFiles(dirPath, "*.battle");

            foreach (var battleFile in battleFiles) // run this singlethreaded to avoid race conditions
            {
                var battleCommand = $@"/C java -Xmx512M -cp libs/robocode.jar;libs/jni4net.j-0.8.7.0.jar robocode.Robocode -nodisplay -battle {battleFile}";

                var processInfo = new ProcessStartInfo("cmd.exe", battleCommand)
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    WorkingDirectory = @"C:\robocode"
                };

                var process = Process.Start(processInfo);

                process.Start();
                process.WaitForExit();
            }

            Console.WriteLine("Finished battles in " + dirPath);
        }
    }
}