using System;

namespace GeneticAlgorithmForStrings {
    internal class Program {
        public static void Main(string[] args)
        {
            for (var generationCount = 0; generationCount < 3; generationCount++)
            {
                for (var individualCount = 0; individualCount < 3; individualCount++)
                {
                    var fileC = new FileCreator(generationCount, individualCount);
                }
            }
            Console.WriteLine("Files Created");

            /*
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
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
	}
}