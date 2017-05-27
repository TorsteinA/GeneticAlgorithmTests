using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Mathos.Parser;
using Microsoft.CSharp;

namespace GeneticAlgorithmForStrings
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //TODO When changing project to create many generations of bots, use e: drive on desktop computer because HDD space.

            int startOnGeneration = 0;
            Algorithm.RunGeneticAlgorithm(startOnGeneration);


            /*** Testing math expression creation ***
            var _parser = new MathParser();
            double c = 256.2;
            string[] a = {c.ToString(), 2.5.ToString(), 0.0.ToString()};
            char[] b = "+/".ToCharArray();
            
            var returnstring = a[0];
            for (var i = 1; i < a.Length; i++) {
                returnstring += $"{b[i-1]}{a[i]}";
            }
            Console.WriteLine(returnstring);
            */






            /*** Testing the match handling ***
            Individual indiv = new Individual();
            var score = FitnessCalc.GetRobotFitness(indiv);
            Console.WriteLine(score);
            */



            /*** Testing File creation ***\
            var rnd = new Random();
            var population = new Population(1, true, 0);
            FileCreator fc;
            for (int generation = 0; generation < 1; generation++)
                fc = new FileCreator(generation, population);
            
//            var testLines = PopulationFileHandler.ReadFile(1);
//
//            foreach (var line in testLines)
//            {
//                Console.WriteLine(line);
//            }
            */

        }
    }
}