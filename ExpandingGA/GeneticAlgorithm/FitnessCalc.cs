using System;
using System.IO;
using System.Linq;

namespace GeneticAlgorithmForStrings {
    internal class FitnessCalc {
        
	    /// <summary>
		/// Runs a series of matches with the individual against other bots to get a score.
		/// </summary>
		/// <param name="individual"></param>
		/// <returns></returns>
		internal static double GetRobotFitness(Individual individual)
	    {
	        const string path = @"C:\robocode\robots\.data\Alvtor_Hartho_15";

            var resultsFile = Directory.GetFiles(path, $"{individual.RobotId}.results").FirstOrDefault();

		    if (resultsFile == null) return -200;

		    return double.Parse(File.ReadLines(resultsFile).Skip(2).Take(1).First() ?? "-100");
		}
    }
}