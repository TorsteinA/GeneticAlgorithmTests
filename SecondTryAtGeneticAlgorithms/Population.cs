using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTryAtGeneticAlgorithms {
    class Population {
        Individual[] individuals;
        
        internal Population(int populationSize, bool initialise)
        {
            individuals = new Individual[populationSize];
            //Initialize population
            if (initialise) {
                for(int i = 0; i < Size(); i++) {
                    Individual newIndividdual = new Individual();
                    newIndividdual.GenerateIndividual();
                    SaveIndividual(i, newIndividdual);
                }
            }
        }

        internal Individual GetIndividual(int index)
        {
            return individuals[index];
        }

        internal Individual GetFittest()
        {
            Individual fittest = individuals[0];
            //Loop through individuals to find fittest
            for(int i = 0; i < Size(); i++) {
                if (fittest.GetFitness() <= GetIndividual(i).GetFitness()) {
                    fittest = GetIndividual(i);
                }
            }
            return fittest;
        }

        internal int Size()
        {
            return individuals.Length;
        }

        internal void SaveIndividual(int index, Individual indiv)
        {
            individuals[index] = indiv;
        }
    }
}