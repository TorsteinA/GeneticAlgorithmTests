using System;
using System.Text;

namespace SecondTryAtGeneticAlgorithms {
    internal class FitnessCalc {

        static int[] solution;
		
		/// <summary>
		/// Sets solution
		/// </summary>
		/// <param name="newSolution">Only Numbers supported for now.</param>
        internal static void SetSolution(string newSolution)
        {
            solution = new int[newSolution.Length];

            //Loop through each character of our string and save it in our byte array
            for (int i = 0; i < newSolution.Length; i++) {
                //string character = "";
                //character = newSolution.Substring(i);
                //if (character.Contains("0") || character.Contains("1")) {
                    solution[i] = newSolution[i] - 48;         //-48 to compensate for ASCII
                //} else {
                //    solution[i] = 0;
                //}			//Commented out because it might crash if it doesn't receive only numbers in the string
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