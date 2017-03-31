using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmForStrings {
    class FileCreator
    {
        public static string FolderName = @"e:\RobotCreator";
        public string PathString = "";
        public string FileName;

        public FileCreator(int generation, int individual)
        {
            FileName = GetFileName(generation, individual);
            PathString = System.IO.Path.Combine(FolderName, "Robots_gen" + generation);
            System.IO.Directory.CreateDirectory(PathString);

            PathString = System.IO.Path.Combine(PathString, FileName);
            
            Console.WriteLine("Path to my file: {0}\n", PathString);

            if (!System.IO.File.Exists(PathString)) {
                using (System.IO.FileStream fs = System.IO.File.Create(PathString)) {
                    
                }
            }
            else {
                Console.WriteLine("File \"{0}\" already exists.", FileName);
//                return; //Use to prevent overwriting
            }


            // Create the file.
            using (FileStream fs = File.Create(PathString))
            {
                Byte[] info =
                    new UTF8Encoding(true).GetBytes(CreateFirstPartOfRobot() + 
                                                    CreateMidPartOfRobot(generation, individual) +
                                                    CreateLastPartOfRobot());
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }

        private string CreateFirstPartOfRobot()
        {
            var imports = "using System;" +
                          "\nusing Robocode;" +
                          "\n";

            var classInfo = "\nclass RobotCreationTest : AdvancedRobot {";

            var insideMain = "\n\tpublic static void Main(string[] args) {" + 
                             "\n\t\tWriteHelloWorld();" +
                             "\n\t}";

            var methods = "\n\n\tpublic void WriteHelloWorld() {" +
                          "\n";

            return imports + classInfo + insideMain + methods;

        }

        private string CreateMidPartOfRobot(int generation , int individualNumber) {
            var middle = "\t\tConsole.WriteLine(\"Hello World from Generation ";
            middle += generation;
            middle += ", Individual number ";
            middle += individualNumber;
            middle += "!\");";
            
            return middle;
        }

        private string CreateLastPartOfRobot()
        {
            return "\n\t}\n}";
        }

        private string GetFileName(int generation , int individualNumber)
        {
            var fileName = "Robot_G";
            fileName += generation;
            fileName += "_I";
            fileName += individualNumber;
            fileName += ".cs";

            return fileName;
        }
    }
}




/*

// Specify a name for your top-level folder.
string folderName = @"c:\Top-Level Folder";

// To create a string that specifies the path to a subfolder under your 
// top-level folder, add a name for the subfolder to folderName.
string pathString = System.IO.Path.Combine(folderName, "SubFolder");

// You can write out the path name directly instead of using the Combine
// method. Combine just makes the process easier.
string pathString2 = @"c:\Top-Level Folder\SubFolder2";

// You can extend the depth of your path if you want to.
//pathString = System.IO.Path.Combine(pathString, "SubSubFolder");

// Create the subfolder. You can verify in File Explorer that you have this
// structure in the C: drive.
//    Local Disk (C:)
//        Top-Level Folder
//            SubFolder
System.IO.Directory.CreateDirectory(pathString);

        // Create a file name for the file you want to create. 
        string fileName = System.IO.Path.GetRandomFileName();

// This example uses a random string for the name, but you also can specify
// a particular name.
//string fileName = "MyNewFile.txt";

// Use Combine again to add the file name to the path.
pathString = System.IO.Path.Combine(pathString, fileName);

        // Verify the path that you have constructed.
        Console.WriteLine("Path to my file: {0}\n", pathString);

        // Check that the file doesn't already exist. If it doesn't exist, create
        // the file and write integers 0 - 99 to it.
        // DANGER: System.IO.File.Create will overwrite the file if it already exists.
        // This could happen even with random file names, although it is unlikely.
        if (!System.IO.File.Exists(pathString))
        {
            using (System.IO.FileStream fs = System.IO.File.Create(pathString))
            {
                for (byte i = 0; i< 100; i++)
                {
                    fs.WriteByte(i);
                }
            }
        }
        else
        {
            Console.WriteLine("File \"{0}\" already exists.", fileName);
            return;
        }

        // Read and display the data from your file.
        try
        {
            byte[] readBuffer = System.IO.File.ReadAllBytes(pathString);
            foreach (byte b in readBuffer)
            {
                Console.Write(b + " ");
            }
            Console.WriteLine();
        }
        catch (System.IO.IOException e)
        {
            Console.WriteLine(e.Message);
        }

        // Keep the console window open in debug mode.
        System.Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
    }*/