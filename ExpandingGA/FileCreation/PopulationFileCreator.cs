using System;
using System.IO;
using System.Text;

namespace GeneticAlgorithmForStrings
{
    public class PopulationFileCreator
    {
        internal PopulationFileCreator(string path, int gen, Population population)
        {
            CreateFile(path, "Population_Gen" + gen + ".txt", population);
        }
        
        private static void CreateFile(string filePath, string name, Population population) {
            var pathIncludingFile = System.IO.Path.Combine(filePath, name);
            var contents = "";
            
            using (var fs = File.Create(pathIncludingFile))
            {
                for (var i = 0; i < population.Size(); i++)
                {
                    contents += population.GetIndividual(i) + Environment.NewLine;
                }
                var info = new UTF8Encoding(true).GetBytes(contents);
                fs.Write(info, 0, info.Length);
                fs.Close();
            }
        }
    }
}