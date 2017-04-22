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


        internal static void CreateFile(string filePath, string name, Population population) {
            var pathIncludingFile = System.IO.Path.Combine(filePath, name);
            var contents = "";

            Console.WriteLine(!System.IO.File.Exists(pathIncludingFile) ? "File \"{0}\" Created!" : "File \"{0}\" overwritten!", filePath + name);


            // Create and write to file.
            using (var fs = File.Create(pathIncludingFile))
            {

                for (var i = 0; i < population.Size(); i++)
                {
                    contents += population.GetIndividual(i).ToString() + "\n";
                }
                var info = new UTF8Encoding(true).GetBytes(contents);
                fs.Write(info, 0, info.Length);

                fs.Close();
            }
        }
    }
}