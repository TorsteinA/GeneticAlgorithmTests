using System;

namespace GeneticAlgorithmForStrings {


	internal class Individual {

		private string[] _genes = new string[Algorithm.DefaultGeneLength];
		private int _fitness = 0;
		private Random rnd = new Random();

		/// <summary>
		/// create a random individual
		/// </summary>
		internal void GenerateIndividual() 
	    {
			for (int i = 0; i < Size(); i++) 
			{
				string gene = "";
				int geneLength = rnd.Next() % Algorithm.MaxGeneStringLength;
				
				Console.WriteLine("GeneNr: " + i + ", GeneLength: " + geneLength);

				//Create string of random length
				for (int j = 0; j < geneLength; j++) {
					gene += " ";
				}
				
				//Fill string with random characters
				for (int j = 0; j < geneLength; j++) {
					//Console.WriteLine("LoopDeLoop: "+ j + ", gL: " + geneLength);

					char c = Algorithm.allowedLetters[rnd.Next(Algorithm.allowedLetters.Length)];
					string cs = "" + c;

					gene = gene.Remove(j,1).Insert(j, cs);
				}
				_genes[i] = gene;
			}
        }

		/// <summary>
		/// Returns gene at index
		/// </summary>
		/// <param name="index">Where to find gene</param>
		/// <returns></returns>
        internal string GetGene(int index)
        {
            return _genes[index];
        }

		/// <summary>
		/// returns gene part from gene at geneIndex, with part from partIndex.
		/// </summary>
		/// <param name="geneIndex"></param>
		/// <param name="partIndex"></param>
		/// <returns></returns>
		internal char GetGenePart(int geneIndex, int partIndex) 
		{
			char[] chars = new char[_genes[geneIndex].Length];

			if (partIndex <= chars.Length)
				chars = _genes[geneIndex].ToCharArray();

			Console.WriteLine(chars);

			char returnChar = chars[partIndex];

			return returnChar;
		}

		/// <summary>
		/// Sets gene at index to value
		/// </summary>
		/// <param name="index">Where to change gene</param>
		/// <param name="value">What to change gene to</param>
        internal void SetGene(int index, string value)
        {
            _genes[index] = value;
            _fitness = 0;
        }
		
		internal void SetGenePart(int geneIndex, int partIndex, string value) 
		{
			Console.WriteLine("Setting GeneIndex: " + geneIndex + ", on partIndex: " + partIndex + ", to value: " + value);

			char[] geneChars = _genes[geneIndex].ToCharArray(); 
			char[] valueChars = value.ToCharArray();

			for (int i = 0; i <= value.Length && i <= geneChars.Length; i++) {
				Console.WriteLine("Index: " + i);
				geneChars[partIndex++] = valueChars[i];
			}
			Console.WriteLine("New Gene: " + new string(geneChars) + ", old Gene: " + _genes[geneIndex]);
			_genes[geneIndex] = new string(geneChars);
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
            string geneString = "";
            for (int i = 0; i < Size(); i++) {
                geneString += GetGene(i) + "\n";
            }
            return geneString;
        }
    }
}