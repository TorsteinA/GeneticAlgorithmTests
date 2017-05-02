namespace GeneticAlgorithmForStrings
{
    internal static class RoboCodeMatchHandler
    {
        /// <summary>
        /// Runs matches between individual and pre-selected bots to return a score
        /// </summary>
        /// <param name="individual"></param>
        /// <returns></returns>
        internal static int RunMatches(Individual individual)
        {
            //TODO implement completely

            var directoryPath = ""; //Get this from FileCreator
            

            //Search through folder for files ending with .battle related to individual (might require restructure of folders so each individual only has one folder) 
            //Run them in sequence
            //Return additive score or average score. 

            return 0;
        }

        /// <summary>
        /// Uses match parameters to determine max score. 
        /// </summary>
        /// <returns></returns>
        public static float GetMaxScore()
        {
            //TODO needs actual implementation
            return 1000;
        }
    }
}