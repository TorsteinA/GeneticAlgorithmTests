using System;

namespace GeneticAlgorithmForStrings {
    internal class Algorithm {
        
		//Tweak. Too low and it breaks, too high, and each generation will take forever.
	    internal static readonly int PopulationSize = 3;
		//Tweak. Too high creates random gibberish, too low never finds the solution.
        private const double MutationRate = 0.035;
		//Letters that algorithm can make genes with
		internal static readonly string AllowedLetters = "agct";
        //DNA length
        internal static int DefaultGeneLength = 1820;

        //tournamentSelection population size
        //private const int TournamentSize = 40;
        //How much DNA to take from each parent. Should stay at 0.5
        private const double UniformRate = 0.5;
        //Keep copy of best individual next generation?
        private const bool Elitism = true;

        private static readonly Random Rnd = new Random();

		
	    internal static void RunGeneticAlgorithm(int fromSavedGeneration)
	    {
	        int generationCount;
	        Population myPop;

            if (fromSavedGeneration == 0)
	        {
                RoboCodeMatchHandler.ClearResultsFolder();
	            generationCount = 0;
	            myPop = new Population(PopulationSize, true, generationCount);
	        }
	        else
	        {
	            generationCount = fromSavedGeneration;
	            var individualGenes = PopulationFileHandler.ReadFile(fromSavedGeneration);
	            var individuals = new Individual[individualGenes.Length];
	            for (var i = 0; i < individualGenes.Length; i++)
	            {
	                individuals[i] = new Individual(generationCount, i);
	            }
                myPop = new Population(individuals);
	        }

	        while (true)    //No need for an exit condition in this Genetic Algorithm
            {
                myPop = EvolvePopulation(myPop, generationCount);

                var fittestBot = myPop.GetFittest();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Generation: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(generationCount);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(", \t Fittest score: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(fittestBot.GetFitness());
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(", \t Fittest Bot ID: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(fittestBot.RobotId + "\n");

                generationCount++;
            }
		}


        /// <summary>
        /// Evolve a population
        /// </summary>
        /// <param name="pop">Population to evolve</param>
        /// <param name="generationCount"></param>
        /// <returns>Evolved population</returns>
        internal static Population EvolvePopulation(Population pop, int generationCount)
        {
            var newPopulation = new Population(pop.Size(), false, generationCount);

            var fc = new FileCreator(generationCount, pop);

            // Keep our best individual
            if (Elitism) 
                newPopulation.SaveIndividual(0, pop.GetFittest());
            
            // Crossover population
            const int elitismOffset = Elitism ? 1 : 0;

            // Loop over the population size and create new individuals with crossover
            for (var i = elitismOffset; i < pop.Size(); i++) {
                var individual1 = CustomSelection(pop);
                var individual2 = CustomSelection(pop);

                var newIndividual = Crossover(individual1, individual2, generationCount, i);
                newPopulation.SaveIndividual(i, newIndividual);
            }

            // Mutate population
            for (var i = elitismOffset; i < newPopulation.Size(); i++)
                Mutate(newPopulation.GetIndividual(i));
            
            return newPopulation;
        }

        /// <summary>
        /// Select random individual from population
        /// </summary>
        /// <param name="pop"></param>
        /// <returns></returns>
        private static Individual NaturalSelection(Population pop)
        {
            return pop.GetIndividual(Rnd.Next(pop.Size()));
        }

        /// <summary>
        /// Select random individual with fitness higher than 0
        /// </summary>
        /// <param name="pop"></param>
        /// <returns></returns>
        private static Individual CustomSelection(Population pop)
        {
            Individual candidate;
            do
            {
                candidate = pop.GetIndividual(Rnd.Next(pop.Size()));
            } while (candidate.GetFitness() <= 0);  //If we normalize fitness values, we can use a specific rate here
            return candidate;
        }

        /// <summary>
        /// Crossover individuals
        /// </summary>
        /// <param name="individual1">Parent individual 1</param>
        /// <param name="individual2">Parent individual 2</param>
        /// <param name="generation"></param>
        /// <param name="individual"></param>
        /// <returns>Child individual</returns>
        private static Individual Crossover(Individual individual1, Individual individual2, int generation, int individual)
        {
            var newIndividual = new Individual(generation, individual);
            // Loop through genes
            for (var i = 0; i < individual1.Size(); i++) {
                // Crossover
                newIndividual.SetGene(i, Rnd.NextDouble() <= UniformRate ? individual1.GetGene(i) : individual2.GetGene(i));
            }
            return newIndividual;
        }

		/// <summary>
		/// Mutate an individual
		/// </summary>
		/// <param name="indiv">Individual to mutate</param>
		private static void Mutate(Individual indiv)
        {
            // Loop through genes
            for (var i = 0; i < indiv.Size(); i++) {
                if (!(Rnd.NextDouble() <= MutationRate)) continue;
                // Create random gene
                var gene = AllowedLetters[Rnd.Next(AllowedLetters.Length)];
                indiv.SetGene(i, gene);
            }
        }

        /*
		/// <summary>
		/// Select individual for crossover
		/// </summary>
		/// <param name="pop">Population to select from</param>
		/// <returns>Fittest individual from tournament</returns>
		private static Individual TournamentSelection(Population pop)
        {
            // Create a tournament population
            var tournament = new Population(TournamentSize, false);
            // For each place in the tournament get a random individual
            for (var i = 0; i < TournamentSize; i++) {
                var randomId = Rnd.Next(pop.Size());
                tournament.SaveIndividual(i, pop.GetIndividual(randomId));
            }
            // Get the fittest
            var fittest = tournament.GetFittest();
            return fittest;
        }
        */
    }
}