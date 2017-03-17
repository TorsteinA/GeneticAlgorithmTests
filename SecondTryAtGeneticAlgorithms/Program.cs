using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTryAtGeneticAlgorithms {
    class Program {
        static void Main(string[] args)
        {
            FitnessCalc.SetSolution(Algorithm.solution);
            Population myPop = new Population(Algorithm.populationSize, true);
            int _generationCount = 0;

            while(myPop.GetFittest().GetFitness() < FitnessCalc.GetMaxFitness()) {
                _generationCount++;
                Console.WriteLine("   Generation: " 
                    + _generationCount 
                    + ", \t Fittest score: " 
                    + myPop.GetFittest().GetFitness() 
                    + ", \t Genes of fittest: " 
                    + myPop.GetFittest().ToString());
                myPop = Algorithm.EvolvePopulation(myPop);
            }
            Console.WriteLine();
            Console.WriteLine("Solution Found!");
            Console.WriteLine("Generation: " + _generationCount);
            Console.WriteLine("MyPop Genes:    " + myPop.GetFittest());
            Console.WriteLine("Solution Genes: " + Algorithm.solution);

        }
    }
}
