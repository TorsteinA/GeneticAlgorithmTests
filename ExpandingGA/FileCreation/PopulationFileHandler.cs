using System;
using System.IO;
using System.Text;

namespace GeneticAlgorithmForStrings
{
    public static class PopulationFileHandler
    {
		internal static void CreateFile(int generation, Population population)
        {
            var contents = "";
			
	        for (var i = 0; i < population.Size(); i++) {
		        contents += population.GetIndividual(i) + Environment.NewLine;
	        }
			FileCreator.CreateFile(Path.Combine(FileCreator.RootFolderName, FileCreator.PopulationsFolderName), 
				GetFileName(generation), 
				contents, 
				true);
		}

		/// <summary>
		/// Reads the file created by PopulationFileHandler.CreateFile() and returns it as a string array.
		/// </summary>
		/// <param name="generation">The generation to get the population of</param>
		/// <returns></returns>
	    internal static string[] ReadFile(int generation)
		{
			var folderPath = Path.Combine(FileCreator.RootFolderName, FileCreator.PopulationsFolderName);
			
			try 
			{
				return File.ReadAllLines(Path.Combine(folderPath, GetFileName(generation)));
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

	    private static string GetFileName(int generation) => $"Population_Gen{generation:D4}.txt";
	}
}