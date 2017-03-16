using System;
using System.Text;

namespace SecondTryAtGeneticAlgorithms {
    internal class FitnessCalc {

        static int[] solution;// = new int[64];
        
        // Set a candidate solution as a byte array
        internal static void SetSolution(int[] newSolution)
        {
            solution = newSolution;
        }

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
                //}
            }
        }

        //Calculate individuals fittness by comparing it to our candidate solution
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

        //Get optimium fitness
        internal static int GetMaxFitness()
        {
            int maxFitness = solution.Length;
            return maxFitness;
        }
    }
}