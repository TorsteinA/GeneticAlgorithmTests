using System;

namespace SecondTryAtGeneticAlgorithms {

    
    internal class Individual {

        static internal int DefaultGeneLength = Algorithm.solution.Length;
        private int[] _genes = new int[DefaultGeneLength];
        private int _fitness = 0;
        private Random rnd = new Random();

        //create a random individual
        internal void GenerateIndividual()
        {
            for (int i = 0; i < Size(); i++) {
                int gene = (int)Math.Round((double)rnd.Next() % Algorithm.randomGeneRange);    //tutorial did not have % 1000
                _genes[i] = gene;
            }
        }

        internal int GetGene(int index)
        {
            return _genes[index];
        }

        internal void SetGene(int index, int value)
        {
            _genes[index] = value;
            _fitness = 0;
        }

        internal string GetGenes()
        {
            string returnString = "";
            for (var i = 0; i < Size(); i++) {
                returnString += _genes[i];
            }
            return returnString;
        }

        internal int Size()
        {
            return _genes.Length;
        }

        internal int GetFitness()
        {
            if (_fitness == 0) {
                _fitness = FitnessCalc.GetFitness(this);
            }
            return _fitness;
        }

        public override string ToString()
        {
            string geneString = "";
            for (int i = 0; i < Size(); i++) {
                geneString += GetGene(i);
            }
            return geneString;
        }
    }
}