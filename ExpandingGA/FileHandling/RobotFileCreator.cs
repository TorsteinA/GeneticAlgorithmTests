namespace GeneticAlgorithmForStrings
{
	internal class RobotFileCreator
	{
		internal void CreateRobotFiles(string filePath, string robotId, DnaToCode dnaTranslator) {
			//Create Robot_gX_iY.cs
			FileCreator.CreateFile(
				filePath,
				$"{robotId}{FileCreator.CodeFileExtension}",
				GetFileText(robotId, dnaTranslator),
//				GetBotZero(robotId),
				true
			);
		}

		internal string GetFileText(string robotId, DnaToCode dnaTranslator) {
			var imports = $"using System;" +
						"\nusing System.Drawing;" +
						"\nusing Robocode;" +
						"\nusing Santom;" +
                        "\nusing Alvtor_Hartho_15.FSM;" +
                        "\nusing ExampleSetup.Robocode;" +
			            "\n";
            

			var classInfo = $"\nnamespace {FileCreator.NameSpace} {{    //GARICS: Genetic Algorithm Robot in C Sharp" +
			                "\npublic class " + robotId + " : Alvtor_Hartho_15.Garics {";

			var fields = "\n" + dnaTranslator.GetVariableDeclarations();

			var runMethod = "\n\t\tpublic override void Run() {" +
			                "\n\t\t\tEnemy = new EnemyData();" +
			                "\n\t\t\tStateManager = new StateManagerScript(new State0(this));" +
			                "\n" + dnaTranslator.GetVariableInitialisations() +
							"\n" +
			 			    "\n\t\t\twhile (true) {" +
			                "\n\t\t\t\tStateManager.FrameCheck();" +
			 			    "\n\t\t\t\tExecute();" +
			                "\n\t\t\t\tOldEnemy = Enemy;" +
			                "\n\t\t\t}" +
			                "\n\t\t}" +
			                "\n";

			const string methods = "\n\t\tpublic override void OnScannedRobot(ScannedRobotEvent e) {" +
			                       "\n\t\t\tvar angleToEnemy = HeadingRadians + e.BearingRadians;" +
			                       "\n\t\t\tvar enemyX = (int)(X + Math.Sin(angleToEnemy) * e.Distance);" +
			                       "\n\t\t\tvar enemyY = (int)(Y + Math.Cos(angleToEnemy) * e.Distance);" +
			                       "\n\t\t\tEnemy.SetEnemyData(e, new Point2D(enemyX, enemyY));" +
			                       "\n\t\t}";

			const string end = "\n\t}" +
			                   "\n}";

			return imports + /*GetRobotAssemblyInfo() +*/ classInfo + fields + runMethod + methods + end;
		}

	    internal static string GetBotZero(string robotId)
	    {
	        return $@"using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Robocode;
using Santom;
using Alvtor_Hartho_15.FSM;
using ExampleSetup.Robocode;

{GetRobotAssemblyInfo()}

namespace Alvtor_Hartho_15
{{ //GARICS: Genetic Algorithm Robot in C Sharp
    public class {robotId} : Garics
    {{
        public float V0 {{ get; set; }}
        public double V1 {{ get; set; }}
        public int V2 {{ get; set; }}
        public double V3 {{ get; set; }}
        public int V4 {{ get; set; }}
        public double V5 {{ get; set; }}
        public double V6 {{ get; set; }}
        public int V7 {{ get; set; }}

        public override void Run()
        {{
            #region Necessary properties

            Enemy = new EnemyData();
            V0 = 9.9f;
            V1 = Enemy.Distance;
            V2 = 420;
            V3 = Enemy.Distance;
            V4 = 1;
            V5 = Enemy.Distance;
            V6 = X;
            V7 = 9999999;

            #endregion

            #region My First Robot

            TurnLeft(Heading - 90);
            TurnGunRight(90);

            #endregion

            #region GARICS

            BodyColor = Color.Pink;
            //StateManager = new StateManagerScript(new State0(this));                            -----------------------------Remember to uncomment---------------------------------

            #endregion

            while (true) {{
                #region My first robot

                // Move our robot 5000 pixels ahead
                Ahead(5000);

                // Turn the robot 90 degrees
                TurnRight(90);


                #endregion

                #region GARICS

                //StateManager.FrameCheck();                            -----------------------------Remember to uncomment---------------------------------
                SetFire(3);
                Execute();
                OldEnemy = Enemy;

                #endregion
            }}
        }}

        public override void OnScannedRobot(ScannedRobotEvent e) {{
            #region My First Robot
            Fire(1);
            #endregion

            #region GARICS

            var angleToEnemy = HeadingRadians + e.BearingRadians;
            var enemyX = (int)(X + Math.Sin(angleToEnemy) * e.Distance);
            var enemyY = (int)(Y + Math.Cos(angleToEnemy) * e.Distance);
            Enemy.SetEnemyData(e, new Point2D(enemyX, enemyY));

            #endregion
        }}
    }}
}}";
	    }

		internal static string GetRobotId(int generation, int individualNumber) {
			return "Robot_g" + generation.ToString("D4") + "_i" + individualNumber.ToString("D4");
		}

        internal static string GetRobotAssemblyInfo()
        {
            return $@"[assembly: AssemblyVersion(""1.0.0.0"")]
[assembly: AssemblyTitle(""GARICS"")]
[assembly: TargetFramework("".NETFramework, Version = v4.6.1"", FrameworkDisplayName = "".NET Framework 4.6.1"")]
[assembly: AssemblyDescription("""")]
[assembly: Debuggable(
    DebuggableAttribute.DebuggingModes.Default |
    DebuggableAttribute.DebuggingModes.DisableOptimizations |
    DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints |
    DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: AssemblyConfiguration("""")]
[assembly: AssemblyCompany("""")]
[assembly: AssemblyProduct(""GARICS"")]
[assembly: AssemblyCopyright(""Copyright © Torstein Alvern & Thomas Hartmann 2017"")]
[assembly: AssemblyTrademark("""")]
[assembly: ComVisible(false)]
[assembly: AssemblyFileVersion(""1.0.0.0"")]
[assembly: Guid(""{ System.Guid.NewGuid() }"")]
";
        }
	}
}