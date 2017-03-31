namespace GeneticAlgorithmForStrings {
    internal class FitnessCalc {

        static char[] _solution;
		
		/// <summary>
		/// Sets solution
		/// </summary>
		/// <param name="newSolution">Only Numbers supported for now.</param>
        internal static void SetSolution(string newSolution)
        {
            _solution = new char[newSolution.Length];

            //Loop through each character of our string and save it in our byte array
            for (var i = 0; i < newSolution.Length; i++) {
                _solution[i] = newSolution[i];
            }
        }

		/// <summary>
		/// Calculate individuals fitness by comparing it to our solution
		/// </summary>
		/// <param name="individual">Individual to check health from</param>
		/// <returns></returns>
		internal static int GetFitness(Individual individual)
        {
            var fitness = 0;
            //Loop through our individuals genes and compare them to our candidates
            for (var i = 0; i<individual.Size() && i < _solution.Length; i++) {
                if(individual.GetGene(i) == _solution[i]) {
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
            var maxFitness = _solution.Length;
            return maxFitness;
        }
    }
}