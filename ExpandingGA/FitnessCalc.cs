using System;
using System.Text;

namespace GeneticAlgorithmForStrings {
    internal class FitnessCalc {

        static string[] solution;
		
		/// <summary>
		/// Sets solution
		/// </summary>
		/// <param name="newSolution">Only Numbers supported for now.</param>
        internal static void SetSolution(string[] newSolution)
        {
            solution = new string[newSolution.Length];

            //Loop through each character of our string and save it in our array
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

				

				if (individual.GetGene(i).Length == solution[i].Length){
					fitness++;
				}

				for (int j = 0; j <= solution[i].Length-1; j++) {
					char a = individual.GetGenePart(i,j);
					
					char b = solution[i][j];
					if (a == b) 
					{
						fitness++;
					}
				}
			}
			Console.WriteLine("Fitness: " + fitness);
			return fitness;
        }

		/// <summary>
		/// Get perfect fitness based on solution
		/// </summary>
		/// <returns></returns>
		internal static int GetMaxFitness()
        {
			int maxFitness = 0;

			for (int i = 0; i < solution.Length; i++) {
				maxFitness += solution[i].Length;
			}
            return maxFitness;
        }
    }
}