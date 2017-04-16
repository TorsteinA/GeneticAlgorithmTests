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
			
//			*** DnaToCode testing ***

			var indiv = new Individual();
			indiv.GenerateIndividual();
			var dnaTranslator = new DnaToCode(indiv);

	        Console.WriteLine();
	        Console.WriteLine("DNA");
	        Console.WriteLine(indiv.ToString());
	        Console.WriteLine("Length: " + indiv.Size());
			Console.WriteLine();
	        Console.WriteLine("- Variable declarations");
	        Console.WriteLine(dnaTranslator.GetVariableDeclarations());
	        Console.WriteLine();
	        Console.WriteLine("- Variable Initialisations");
	        Console.WriteLine(dnaTranslator.GetVariableInitialisations());
	        Console.WriteLine();
	        Console.WriteLine("- Transition State1 - State2");
	        Console.WriteLine("if( " + dnaTranslator.GetFirstToSecondStateTransitionContent() + " ) {//Do things}");
	        Console.WriteLine();
	        Console.WriteLine("- Transition State2 - State1");
	        Console.WriteLine("if( " + dnaTranslator.GetSecondToFirstStateTransitionContent() + " ) {//Do things}");
	        Console.WriteLine();
	        Console.WriteLine("- Enter States");
	        Console.WriteLine("- State1");
//	        Console.WriteLine(dnaTranslator.GetFirstStateEnterMethodContent());
//	        Console.WriteLine("- State2");
//	        Console.WriteLine(dnaTranslator.GetSecondStateEnterMethodContent());




	        /*
//			*** FileCreator testing ***
			int generation = 0;
			int individual = 0;
			
			for (int i = 0; i < 5; i++) {
				for (int j = 0; j < 5; j++) {
					Console.WriteLine("Generation " + i.ToString("D3") + ", Individual " + j.ToString("D4"));
					var fileCreator = new FileCreator(i, j);  //Creates folders from generation, and uses both generation and individual for filename
					Console.WriteLine();
				}
			}
			*/



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