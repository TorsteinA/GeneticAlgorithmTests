using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTryAtGeneticAlgorithms {
    class Algorithm {

        /* GA parameters */
        internal static readonly string solution = "5555555555555555555555555555555555555555555555555555555555555555555555";	//Only numbers are supported for now
		internal static readonly int populationSize = 1000;		//Tweak. Too low and it breaks, too high, and each generation will take forever.
        internal static readonly int randomGeneRange = 100;    //Tweak for difficulty of finding solution
        private static readonly double mutationRate = 0.025;    //Tweak. Too high creates random gibberish, too low never finds the solution.

		private static readonly int tournamentSize = 50;        //Crossover tournament population size
		private static readonly double uniformRate = 0.5;       //How much DNA to take from each parent. Should stay at 0.5
        private static readonly bool elitism = true;            //Keep copy of best individual next generation, or just random?
        
        private static Random rnd = new Random();

		/// <summary>
		/// Evolve a population
		/// </summary>
		/// <param name="pop">Population to evolve</param>
		/// <returns>Evolved population</returns>
		public static Population EvolvePopulation(Population pop)
        {
            Population newPopulation = new Population(pop.Size(), false);
            
            // Keep our best individual
            if (elitism) {
                newPopulation.SaveIndividual(0, pop.GetFittest());
            }

            // Crossover population
            int elitismOffset;
            if (elitism) {
                elitismOffset = 1;
            } else {
                elitismOffset = 0;
            }

            // Loop over the population size and create new individuals with crossover
            for (int i = elitismOffset; i < pop.Size(); i++) {
                Individual indiv1 = TournamentSelection(pop);
                Individual indiv2 = TournamentSelection(pop);
                Individual newIndiv = Crossover(indiv1, indiv2);
                newPopulation.SaveIndividual(i, newIndiv);
            }

            // Mutate population
            for (int i = elitismOffset; i < newPopulation.Size(); i++) {
                Mutate(newPopulation.GetIndividual(i));
            }
            return newPopulation;
        }

		/// <summary>
		/// Crossover individuals
		/// </summary>
		/// <param name="indiv1">Parent individual 1</param>
		/// <param name="indiv2">Parent individual 2</param>
		/// <returns>Child individual</returns>
		private static Individual Crossover(Individual indiv1, Individual indiv2)
        {
            Individual newSol = new Individual();
            // Loop through genes
            for (int i = 0; i < indiv1.Size(); i++) {
                // Crossover
                if (rnd.NextDouble() <= uniformRate) {
                    newSol.SetGene(i, indiv1.GetGene(i));
                } else {
                    newSol.SetGene(i, indiv2.GetGene(i));
                }
            }
            return newSol;
        }

		/// <summary>
		/// Mutate an individual
		/// </summary>
		/// <param name="indiv">Individual to mutate</param>
		private static void Mutate(Individual indiv)
        {
            // Loop through genes
            for (int i = 0; i < indiv.Size(); i++) {
                if (rnd.NextDouble() <= mutationRate) {
                    // Create random gene
                    int gene = (int)Math.Round((double)rnd.Next() % randomGeneRange);
                    indiv.SetGene(i, gene);
                }
            }
        }

		/// <summary>
		/// Select individuals for crossover
		/// </summary>
		/// <param name="pop">Population to select from</param>
		/// <returns>Fittest individual from tournament</returns>
		private static Individual TournamentSelection(Population pop)
        {
            // Create a tournament population
            Population tournament = new Population(tournamentSize, false);
            // For each place in the tournament get a random individual
            for (int i = 0; i < tournamentSize; i++) {
                int randomId = rnd.Next(pop.Size());
                tournament.SaveIndividual(i, pop.GetIndividual(randomId));
            }
            // Get the fittest
            Individual fittest = tournament.GetFittest();
            return fittest;
        }
    }
}