using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CSharp;

namespace GeneticAlgorithmForStrings {
    internal class Program {
        public static void Main(string[] args)
        {
			//TODO When changing project to create many generations of bots, use e: drive on desktop computer because HDD space.
			
			
//			*** FileCreator testing ***
	        var indiv = new Individual();
	        indiv.GenerateIndividual();

			for (var generation = 0; generation < 5; generation++) {
				for (var individual = 0; individual < 5; individual++) {
					Console.WriteLine("Generation " + generation.ToString("D3") + ", Individual " + individual.ToString("D4"));
					var fileCreator = new FileCreator(generation, individual, indiv);  //Creates folders from generation, and uses both generation and individual for filename
					Console.WriteLine();
				}
			}
			



			/*** Genetic Algorithm for strings ***
			FitnessCalc.SetSolution(Algorithm.Solution);
			var myPop = new Population(Algorithm.PopulationSize, true);
			var generationCount = 0;
            
			while (myPop.GetFittest().GetFitness() < FitnessCalc.GetMaxFitness()) 
            {
				generationCount++;

			    Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Generation: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(generationCount);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(", \t Fittest score: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(myPop.GetFittest().GetFitness() + "/" + FitnessCalc.GetMaxFitness());
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(", \t Genes of fittest: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(myPop.GetFittest().ToString());
                
				myPop = Algorithm.EvolvePopulation(myPop);
			}
            
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Solution Found!");
			Console.Write("Generation: ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(generationCount);
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("MyPop Genes:    ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write(myPop.GetFittest());
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Solution Genes: ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write(Algorithm.Solution);
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
            */



			// Keep the console window open in debug mode.
			/*			System.Console.WriteLine("Press any key to exit.");

						System.Console.ReadKey();*/

		}
	}
}