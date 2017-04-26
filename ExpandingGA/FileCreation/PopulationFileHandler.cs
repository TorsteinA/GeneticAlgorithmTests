using System;
using System.IO;
using System.Text;

namespace GeneticAlgorithmForStrings
{
    public static class PopulationFileHandler
    {
		
//        internal PopulationFileHandler(string path, int gen, Population population)
//        {
//            CreateFile(path, "Population_Gen" + gen + ".txt", population);
//        }
        internal static void CreateFile(string filePath, string name, Population population)
        {
            var contents = "";

	        Directory.CreateDirectory(filePath);
//			
	        for (var i = 0; i < population.Size(); i++) {
		        contents += population.GetIndividual(i) + Environment.NewLine;
	        }

			FileCreator.CreateFile(filePath, name, contents, true);
		}

	    internal static void ReadFile(int generation)
	    {
		    
	    }
    }
}