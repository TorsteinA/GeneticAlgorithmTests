using System;
using System.Text;

namespace GeneticAlgorithmForStrings {
    internal class FitnessCalc {

        static char[] solution;
		
		/// <summary>
		/// Sets solution
		/// </summary>
		/// <param name="newSolution">Only Numbers supported for now.</param>
        internal static void SetSolution(string newSolution)
        {
            solution = new char[newSolution.Length];

            //Loop through each character of our string and save it in our byte array
            for (int i = 0; i < newSolution.Length; i++) {
                solution[i] = newSolution[i];
            }
        }

		/// <summary>
		/// Calculate individuals fitness by comparing it to our solution
		/// </summary>
		/// <param name="individual">Individual to check health from</param>
		/// <returns></returns>
		internal static int GetFitness(Individual individual)
        {
            int fitness = 0;
            //Loop through our individuals genes and compare them to our candidates
            for (int i = 0; i<individual.Size() && i < solution.Length; i++) {
                if(individual.GetGene(i) == solution[i]) {
                    fitness++;
                }
            }
            return fitness;
        }

		/// <summary>
		/// Get perfect fitness based on solution
		/// </summary>
		/// <returns></returns>
		internal static int GetMaxFitness()
        {
            int maxFitness = solution.Length;
            return maxFitness;
        }
    }
}