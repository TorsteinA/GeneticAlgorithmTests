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


			//Algorithm.RunGeneticAlgorithm();


			//*** Testing File creation ***
            var rnd = new Random();
			var population = new Population(50, true);
	        FileCreator fc;
	        for (int generation = 0; generation < 2; generation++)
				fc = new FileCreator(generation, population);

	        var testLines = PopulationFileHandler.ReadFile(1);

	        foreach (var line in testLines)
	        {
		        Console.WriteLine(line);
	        }
			//*/




			//*** Genetic Algorithm for strings ***
			//	        FitnessCalc.SetSolution(Algorithm.Solution);
			//	        var myPop = new Population(Algorithm.PopulationSize, true);
			//	        var generationCount = 0;
			//	        
			//	        while (myPop.GetFittest().GetFitness() < FitnessCalc.GetMaxFitness()) 
			//	        {
			//	            generationCount++;
			//
			//	            Console.WriteLine();
			//	            Console.ForegroundColor = ConsoleColor.DarkYellow;
			//	            Console.Write("Generation: ");
			//	            Console.ForegroundColor = ConsoleColor.White;
			//	            Console.Write(generationCount);
			//	            Console.ForegroundColor = ConsoleColor.DarkYellow;
			//	            Console.Write(", \t Fittest score: ");
			//	            Console.ForegroundColor = ConsoleColor.White;
			//	            Console.Write(myPop.GetFittest().GetFitness() + "/" + FitnessCalc.GetMaxFitness());
			//	            Console.ForegroundColor = ConsoleColor.DarkYellow;
			//	            Console.WriteLine(", \t Genes of fittest: ");
			//	            Console.ForegroundColor = ConsoleColor.White;
			//	            Console.WriteLine(myPop.GetFittest().ToString());
			//	            
			//	            myPop = Algorithm.EvolvePopulation(myPop);
			//	        }
			//	        
			//	        Console.WriteLine();
			//	        Console.ForegroundColor = ConsoleColor.Green;
			//	        Console.WriteLine("Solution Found!");
			//	        Console.Write("Generation: ");
			//	        Console.ForegroundColor = ConsoleColor.Yellow;
			//	        Console.WriteLine(generationCount);
			//	        Console.WriteLine();
			//	        Console.ForegroundColor = ConsoleColor.Red;
			//	        Console.WriteLine("MyPop Genes:    ");
			//	        Console.ForegroundColor = ConsoleColor.White;
			//	        Console.Write(myPop.GetFittest());
			//	        Console.ForegroundColor = ConsoleColor.Red;
			//	        Console.WriteLine();
			//	        Console.WriteLine();
			//	        Console.WriteLine("Solution Genes: ");
			//	        Console.ForegroundColor = ConsoleColor.White;
			//	        Console.Write(Algorithm.Solution);
			//	        Console.WriteLine();
			//	        Console.WriteLine();
			//	        Console.WriteLine();
			//*/



			// Keep the console window open in debug mode.
			/*			System.Console.WriteLine("Press any key to exit.");

	                    System.Console.ReadKey();*/

		}
	}
}