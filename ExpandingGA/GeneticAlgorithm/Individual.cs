using System;

namespace GeneticAlgorithmForStrings {
	internal class Individual
	{

	    private char[] _genes = new char[Algorithm.DefaultGeneLength];
		private int _fitness = 0;
	    public string RobotId { get; set; }

	    internal Individual(int generation, int individual)
	    {
	        RobotId = RobotFileCreator.GetRobotId(generation, individual);
	    }

	    /// <summary>
		/// create a random individual
		/// </summary>
		internal void GenerateIndividual(Random random)
        {
            for (var i = 0; i < Size(); i++) {
				var gene = Algorithm.AllowedLetters[random.Next(Algorithm.AllowedLetters.Length)];
                _genes[i] = gene;
            }
        }

		/// <summary>
		/// Returns gene at index
		/// </summary>
		/// <param name="index">Where to find gene</param>
		/// <returns></returns>
        internal char GetGene(int index)
        {
            return _genes[index];
        }

		/// <summary>
		/// Sets gene at index to value
		/// </summary>
		/// <param name="index">Where to change gene</param>
		/// <param name="value">What to change gene to</param>
        internal void SetGene(int index, char value)
        {
            _genes[index] = value;
            _fitness = 0;
        }

        /// <summary>
        /// Sets entire genome
        /// </summary>
        /// <param name="genes"></param>
	    internal void SetGenes(char[] genes)
	    {
	        _genes = genes;
	        _fitness = 0;
	    }

		/// <summary>
		/// Length of Genes
		/// </summary>
		/// <returns>Length of genes</returns>
        internal int Size()
        {
            return _genes.Length;
        }

		/// <summary>
		/// Fitness of individual
		/// </summary>
		/// <returns>Fitness</returns>
        internal int GetFitness()
        {
            if (_fitness == 0) {
                _fitness = FitnessCalc.GetFitness(this);
            }
            return _fitness;
        }

		/// <summary>
		/// To String
		/// </summary>
		/// <returns>Gene as string</returns>
        public override string ToString()
        {
            var geneString = "";
            for (var i = 0; i < Size(); i++) {
                geneString += GetGene(i);
            }
            return geneString;
        }
    }
}