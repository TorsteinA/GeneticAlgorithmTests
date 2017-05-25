using System;
using System.Diagnostics;
using System.IO;

namespace GeneticAlgorithmForStrings
{
    internal class RoboCodeMatchHandler
    {
        /// <summary>
        /// Runs all the *.battle files in the specified directory.
        /// Note: runs them sequentially to avoid race conditions, as we cannot control external programs, i.e. cmd.exe
        /// </summary>
        /// <param name="dirPath"></param>
        public static void RunBattles(string dirPath)
        {
            //Console.WriteLine("Running battles, please wait ...");
            var battleFiles = Directory.GetFiles(dirPath, "*.battle");

            foreach (var battleFile in battleFiles) // run this singlethreaded to avoid race conditions
            {
                //Console.WriteLine($"Battle: {battleFile}");
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

                process.WaitForExit();
            }

            Console.WriteLine("Finished battles in " + dirPath);
        }
        
        public static void ClearResultsFolder()
        {
            //Array.ForEach(Directory.GetFiles(@"c:\\robocode\\{FileCreator.NameSpace}\\"), File.Delete);
            string[] filePaths = Directory.GetFiles(@"c:\robocode\robots\.data\" + FileCreator.NameSpace);
            foreach (string filePath in filePaths)
                File.Delete(filePath);
        }
    }
}