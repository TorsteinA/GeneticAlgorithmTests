using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmForStrings {
	class Program {
		static void Main(string[] args) {
			FitnessCalc.SetSolution(Algorithm.solution);
			Population myPop = new Population(Algorithm.populationSize, true);
			int _generationCount = 0;

			while (myPop.GetFittest().GetFitness() < FitnessCalc.GetMaxFitness()) {
				_generationCount++;
				Console.WriteLine("\n   Generation: "
					+ _generationCount
					+ ", \t Fittest score: "
					+ myPop.GetFittest().GetFitness()
					+ ", \t Genes of fittest: "
					+ myPop.GetFittest().ToString());
				myPop = Algorithm.EvolvePopulation(myPop);
			}
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Solution Found!");
			Console.Write("Generation: ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(_generationCount);
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
			Console.Write(Algorithm.solution);
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
		}
	}
}