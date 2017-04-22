using System;

namespace GeneticAlgorithmForStrings {
    internal class Population {
        readonly Individual[] _individuals;

        private readonly Random _rnd = new Random();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="populationSize"></param>
        /// <param name="initialise"></param>
        internal Population(int populationSize, bool initialise)
        {
            _individuals = new Individual[populationSize];
            //Initialize population
            if (!initialise) return;
            for(var i = 0; i < Size(); i++) {
                var newIndividdual = new Individual();
                newIndividdual.GenerateIndividual(_rnd);
                SaveIndividual(i, newIndividdual);
            }
        }

        /// <summary>
        /// Constructor that creates population from array of individuals.
        /// </summary>
        /// <param name="individuals"></param>
        internal Population(Individual[] individuals)
        {
            _individuals = individuals;
        }

		/// <summary>
		/// Get Individual from population by index
		/// </summary>
		/// <param name="index"></param>
		/// <returns>Individual at index</returns>
        internal Individual GetIndividual(int index)
        {
            return _individuals[index];
        }

		/// <summary>
		/// Get Fittest individual in population
		/// </summary>
		/// <returns>Fittest individual in population</returns>
        internal Individual GetFittest()
        {
            var fittest = _individuals[0];
            //Loop through individuals to find fittest
            for(var i = 0; i < Size(); i++) {
                if (fittest.GetFitness() <= GetIndividual(i).GetFitness()) {
                    fittest = GetIndividual(i);
                }
            }
            return fittest;
        }

		/// <summary>
		/// Size of population
		/// </summary>
		/// <returns>Size of population</returns>
        internal int Size()
        {
            return _individuals.Length;
        }

		/// <summary>
		/// Saves individual to population
		/// </summary>
		/// <param name="index">Index to save individual to</param>
		/// <param name="indiv">Individual to save</param>
        internal void SaveIndividual(int index, Individual indiv)
        {
            _individuals[index] = indiv;
        }
    }
}