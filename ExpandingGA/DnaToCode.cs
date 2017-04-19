using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;

namespace GeneticAlgorithmForStrings {
	internal class DnaToCode {
        
        #region Fields

	    private int _numberOfVariables,                     //How many variables the robot gets to play with.
	                _geneIterator = 0;		                //always call with ++ when used with genes.GetGene().

		private const int MinStatements = 2,		        //Minimum number of statements in each states DoStateAction 
                          MinEnterLeaveStatements = 0,      //Minimum number of statements in each states EnterState and LeaveState
					      MinVariables = 5;		            //Minimum number of variables for numberOfVariables.

	    private string _variableDeclarations,		        					//String with variable declarations of robot
					   _variableInitialisations;		        				//String with variable declarations of robot
		private readonly string _firstStateEnterMethodContent,					//String with contents of first states enter method
					            _secondStateEnterMethodContent,					//String with contents of second states enter method
 					            _firstStateLeaveMethodContent,					//String with contents of first states leave method
					            _secondStateLeaveMethodContent,					//String with contents of second states leave method
 					            _firstStateDoStateActionMethodContent,			//String with contents of first states action method
					            _secondStateDoStateActionMethodContent,			//String with contents of second states action method
					            _firstToSecondStateTransitionContent,	        //String with contents of transition from first to second
					            _secondToFirstStateTransitionContent;           //String with contents of transition from second to first

		private readonly string[] _methodCalls = {								//String array with method calls robot can use. All calls from this array are called from a state class. 
			"KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians)",	
            "ourRobot.Fire(500 / ourRobot.Enemy.Distance)",								
            "CircularTargetFire()",							                            
            "ourRobot.TurnRight()", //Needs parameters							       
            "TestMethod()",
            "Example()" };
		
		private readonly Dictionary<string, List<string>> _variableDictionary = new Dictionary<string, List<string>>();		// Block for variable contents. Check helpermethod SetupVariableLists to see/edit values
		
		private List<string> _intVarList, 
							 _floatVarList, 
							 _doubleVarList, 
							 _transitionsList;
		
#endregion Fields

        #region CreateCodeContent

        /// <summary>
            /// Constructor of DnaToCode class
            /// </summary>
            /// <param name="genes"></param>
        public DnaToCode(Individual genes)
        {
	        Console.WriteLine("GeneIter:" + _geneIterator);

	        SetVariables(genes);    //uses max 19 genes with 4-letter genes and minVariables = 5
			SetTransitions();

			//Set geneIterator to specific number to let next gene start at the same place each time and not get messed up by mutations in variables
	        Console.WriteLine("GeneIter:" + _geneIterator);
			_geneIterator = 20;
			
			// Sets content for transitions
			_firstToSecondStateTransitionContent = GetCondition(genes); //uses 5 genes TODO (But currently does not support && or || in conditions)
			_secondToFirstStateTransitionContent = GetCondition(genes); //uses 5 genes 

	        Console.WriteLine("GeneIter:" + _geneIterator);
			_geneIterator = 30;
			
			// Sets content for state Enter
			_firstStateEnterMethodContent = CreateStateMethodContent(genes, MinEnterLeaveStatements); //Worst Case use of genes = 1+6((1+5)*3) = 109
			Console.WriteLine("GeneIter:" + _geneIterator);
	        _geneIterator = 140;

			_secondStateEnterMethodContent = CreateStateMethodContent(genes, MinEnterLeaveStatements);
			Console.WriteLine("GeneIter:" + _geneIterator);
			_geneIterator = 250;
            

			// Sets content for state Leave
			_firstStateLeaveMethodContent = CreateStateMethodContent(genes, MinEnterLeaveStatements);
	        Console.WriteLine("GeneIter:" + _geneIterator);
	        _geneIterator = 360;

			_secondStateLeaveMethodContent = CreateStateMethodContent(genes, MinEnterLeaveStatements);
            Console.WriteLine("GeneIter:" + _geneIterator);
            _geneIterator = 470;

		    // Sets content for state doAction
		     _firstStateDoStateActionMethodContent = CreateStateMethodContent(genes, MinStatements);
	        Console.WriteLine("GeneIter:" + _geneIterator);
			_geneIterator = 580;

			_secondStateDoStateActionMethodContent = CreateStateMethodContent(genes, MinStatements);
			Console.WriteLine("GeneIter:" + _geneIterator);
		}

		/// <summary>
		/// Initialises transitionslist and fills it with transitions based on number of variables this bot has. 
		/// </summary>
		private void SetTransitions()
		{
			_transitionsList = new List<string>();
			
			for (var i = 0; i <= _numberOfVariables; i++) {
				for (var j = 0; j <= _numberOfVariables; j++) {
					if (i == j) continue;	//Comparing a variable with itself is unlikely to be the best solution, so we skip those.
					_transitionsList.Add("v"+ i + "<" +"v" + j );
					_transitionsList.Add("v"+ i + ">" +"v" + j );
					_transitionsList.Add("v"+ i + "<=" +"v" + j );
					_transitionsList.Add("v"+ i + ">=" +"v" + j );
					_transitionsList.Add("v"+ i + "==" +"v" + j );
					_transitionsList.Add("v"+ i + "!=" +"v" + j );
				}
			}
			//Max transitions in _transitionsList with 6 comparators and 8 variables is 432 transitions
		}

		/// <summary>
		/// Sets content of variables.
		/// </summary>
		/// <param name="genes"></param>
		private void SetVariables(Individual genes)
		{
			SetupVariableLists();
			
			var variableDeclarations = "";
		    var variableInitialisations = "";
			var geneIter = _geneIterator;

		    SetNumberOfVariables(genes.GetGene(_geneIterator++));
			
		    for (var i = geneIter; i < _numberOfVariables; i++) {
				var gene = genes.GetGene(_geneIterator++);
				var type = _variableDictionary.ElementAt(GeneToNumber(gene) % _variableDictionary.Count).Key;
				var valueList = _variableDictionary.ElementAt(GeneToNumber(gene) % _variableDictionary.Count).Value;
				var value = valueList[GenesToNumber(genes, 2, 0) % valueList.Count];
				
			    if (i > geneIter) {
				    variableDeclarations += "\n";
				    variableInitialisations += "\n";
				}
				
				variableDeclarations += type + " v" + i + ";";
			    variableInitialisations += "v" + i + " = " + value + ";";
				
		    }
			_variableDeclarations = variableDeclarations;
			_variableInitialisations = variableInitialisations;
		}
		
		/// <summary>
		/// Creates a string with the contents of a method
		/// </summary>
		/// <param name="genes"></param>
		/// <param name="minStatements"></param>
		/// <param name="block"></param>
		/// <returns></returns>
		private string CreateStateMethodContent(Individual genes, int minStatements) {
			var contents = "";
			var statements = GenesToNumber(genes, 1, minStatements);
			for (var i = 0; i < statements; i++) {
				contents += "\n" + GetStatement(genes, 0);
			}
			return contents;
		}

	    /// <summary>
	    /// Returns condition that can be used with statements
	    /// </summary>
	    /// <param name="genes"></param>
	    /// <param name="depth"></param>
	    /// <returns></returns>
	    private string GetCondition_old(Individual genes, int depth) {
            
            //If new gene is 0 or 1, do nothing, if it's 2, use &&, if it's 3, use || ?
            
            const int depthLimit = 2;
            var transitionContent = "";
            var geneChars = Algorithm.AllowedLetters;
            var gene1 = genes.GetGene(_geneIterator++);
            var gene2 = genes.GetGene(_geneIterator++);
            
            //Adds condition from block
            for (var i = 0; i <= geneChars.Length; i++) {
                for (var j = 0; j <= geneChars.Length; i++)
                {
	                if (gene1 == geneChars[i] && gene2 == geneChars[j])
		                if ((geneChars.Length * i + j) > _numberOfVariables)
		                {
			                transitionContent = _transitionsList[(geneChars.Length * i + j)];
		                }
                }
            }
            if (depth >= depthLimit) return transitionContent;

            //Expands condition
            var gene3 = genes.GetGene(_geneIterator++);
            switch (gene3)
            {
                case 'a':
                case 'g':
                    break;
                case 'c':
                    transitionContent += " && " + GetCondition_old(genes, ++depth);
                    break;
                case 't':
                    transitionContent += " || " + GetCondition_old(genes, ++depth);
                    break;
            }

            return transitionContent;
        }

		/// <summary>
		/// Returns condition from block with index based on genes. 
		/// </summary>
		/// <param name="genes"></param>
		/// <returns></returns>
		private string GetCondition(Individual genes)
		{
			var index = GenesToNumber(genes, 5, 0);
			return _transitionsList[index % _transitionsList.Count];
		}
		
#endregion CreateCodeContent

		#region HelperMethods
		
		private void SetupVariableLists() {
			
			_doubleVarList = new List<string>
			{
				"ourRobot.X",
				"ourRobot.Y",
				"ourRobot.Velocity",
				"ourRobot.Energy",
				"ourRobot.Heading",
				"ourRobot.Height",
				"ourRobot.Width",
				"ourRobot.RadarHeading",	//RadarHeading only uses degrees. Always using degrees because this isn't the only case. (Though only using radians would be preferable)
				"ourRobot.GunHeat",
				"ourRobot.GunHeading",
				"ourRobot.BattleFieldWidth",
				"ourRobot.BattleFieldHeight",
				"ourRobot.Enemy.Distance",
				"ourRobot.Enemy.Energy",
				"ourRobot.Enemy.Position.X",
				"ourRobot.Enemy.Position.Y",
				"ourRobot.Enemy.Velocity",
				"ourRobot.Enemy.Acceleration",
				"ourRobot.Enemy.BearingDegrees",
				"ourRobot.Enemy.HeadingDegrees",
				"ourRobot.Enemy.TurnRateDegrees"
			};
			
			_intVarList = new List<string>
			{
				"0",
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"10",
				"42",
				"420",
				"9999999"
			};

			_floatVarList = new List<string>
			{
				"0.001",
				"1.1",
				"5.5",
				"3.2",
				"9.9",
				"3.1415928",		//Pi
				"1.618",			//Phi
				"2.718281828459",	//Euler's number
				"1.41421"			//Pythagoras' constant
			};
			
			// Adding lists to dictionary
			_variableDictionary.Add("double", _doubleVarList);	//Having only 3 lists doubles chance of first element (with 4-letter dna), which is preferable here
			_variableDictionary.Add("float", _floatVarList);
			_variableDictionary.Add("int", _intVarList);
		}
		
		/// <summary>
		/// Sets how many variables the robot gets to play with
		/// </summary>
		/// <param name="gene"></param>
		private void SetNumberOfVariables(char gene) {

            for (var i = 0; i < Algorithm.AllowedLetters.Length; i++) {
                if (gene == Algorithm.AllowedLetters[i]) {
                    _numberOfVariables = i + MinVariables;
                }
            }
        }
        
		/// <summary>
		/// Returns a number between minNumber and minNumber + 4^numberOfGenes based on genes
		/// </summary>
		/// <param name="genes"></param>
		/// <param name="numberOfGenes"></param>
		/// <param name="minNumber"></param>
		/// <returns></returns>
		private int GenesToNumber(Individual genes, int numberOfGenes, int minNumber)
		{
			var geneL = new List<int>();
			var num = 0;

			for (var i = 0; i < numberOfGenes; i++) {
				geneL.Add(GeneToNumber(genes.GetGene(_geneIterator++)));
			}

			foreach (var g in geneL) {
				num *= Algorithm.AllowedLetters.Length;
				num += g;
			}
			return num + minNumber;
		}

		/// <summary>
		/// Returns a number between 0 and 3 based on gene.
		/// </summary>
		/// <param name="gene"></param>
		/// <returns></returns>
		private static int GeneToNumber(char gene)
		{
			switch (gene)
			{
				case 'a':
					return 0;
				case 'g':
					return 1;
				case 'c':
					return 2;
				case 't':
					return 3;
				default:
					return -1;
			}
		}
		
		/// <summary>
		/// Returns string with a method call, if-statement, or a loop.
		/// </summary>
		/// <param name="genes">Genes to use</param>
		/// <param name="depth">Call with </param>
		/// <returns></returns>
		private string GetStatement(Individual genes, int depth)
		{
			var statement = "";
			var gene1 = genes.GetGene(_geneIterator++);
			
			switch (gene1) {
				case 'a':
					if (depth < 3) statement += GetIfStatement(genes, depth);
					else statement += GetMethodCall(genes);
					break;
				case 't':
					if (depth < 2) statement += GetLoop(genes, depth);
					else statement += GetMethodCall(genes);
					break;
				case 'c':
				case 'g':
					statement += GetMethodCall(genes);
					break;
			}
			return statement;
		}

		/// <summary>
		/// Returns a loop with a condition and statements inside.
		/// </summary>
		/// <param name="genes"></param>
		/// <param name="depth"></param>
		/// <returns></returns>
		private string GetLoop(Individual genes, int depth) {
			var statement = "";
			statement += "while(";
			statement += GetCondition(genes);
			statement += "){";
			statement += GetStatement(genes, ++depth);
			statement += "}";
			return statement;
		}

		/// <summary>
		/// Returns an if-statement with condition and statements inside.
		/// </summary>
		/// <param name="genes"></param>
		/// <param name="depth"></param>
		/// <returns></returns>
		private string GetIfStatement(Individual genes, int depth) {
			var statement = "";
			statement += "if(";
			statement += GetCondition(genes);
			statement += "){";
			statement += GetStatement(genes, ++depth);
			statement += "}";
			return statement;
		}

		/// <summary>
		/// Returns a method call from _methodcalls using 2 genes. If _methodCalls have more than 16 elements, refactor.
		/// </summary>
		/// <param name="genes"></param>
		/// <returns></returns>
		private string GetMethodCall(Individual genes)
		{
			//var index = GenesToNumber(genes, 2, 0);
			//return _methodCalls[index % _methodCalls.Length] + ";";


			//Above is old working code based on finished blocks, below is nonfactored almost-pseudo-to-see-if-I-can-make-this-work-code. Ideally, a gene will choose to create or fetch a method call.

			
			//Make RoboMethod list, and fill it with RoboMethods. Extract from here what type it needs, and where it needs it. 

			var roboMethodList = new List<RoboMethod>
			{
				new RoboMethod("None", new List<RoboMethodTypes>()),
				new RoboMethod("OneInt", new List<RoboMethodTypes>() {RoboMethodTypes.Int}),
				new RoboMethod("IntAndFloat", new List<RoboMethodTypes>() {RoboMethodTypes.Int, RoboMethodTypes.Float}),
				new RoboMethod("DoubBoub", new List<RoboMethodTypes>() {RoboMethodTypes.Double, RoboMethodTypes.Double}),
				new RoboMethod("DoubFloat", new List<RoboMethodTypes>() {RoboMethodTypes.Double, RoboMethodTypes.Float})
			};

			
			var geneNum = GenesToNumber(genes, 1, 0);
			var returnString = roboMethodList[geneNum].MethodName + "(";


			while (roboMethodList[geneNum].TypeRequired.Count > 0)
			{
				var rType = roboMethodList[geneNum].TypeRequired.Dequeue();

				if (rType.Equals(RoboMethodTypes.Int)) returnString += "0"; //FetchInt();
				if (rType.Equals(RoboMethodTypes.Float)) returnString += "0.0f"; //FetchFloat();
				if (rType.Equals(RoboMethodTypes.Double)) returnString += "0.0"; //FetchDouble();

				if (roboMethodList[geneNum].TypeRequired.Count > 0) returnString += ",";	//If there's none left to fill, don't put comma.
			}
			
			returnString += ");";
			return returnString;
		}

		
		#endregion HelperMethods

		#region ReturnMethods


		/// <summary>
		/// Returns string with variable declarations
		/// </summary>
		/// <returns></returns>
		public string GetVariableDeclarations() {
			return _variableDeclarations;
		}
        /// <summary>
        /// Returns string with variables
        /// </summary>
        /// <returns></returns>
        public string GetVariableInitialisations() {
			return _variableInitialisations;
		}

		/// <summary>
		/// Returns contents of method to go in first state
		/// </summary>
		/// <returns></returns>
		public string GetFirstStateEnterMethodContent() {
			return _firstStateEnterMethodContent;
		}

		/// <summary>
		/// Returns contents of method to go in second state
		/// </summary>
		/// <returns></returns>
		public string GetSecondStateEnterMethodContent() {
			return _secondStateEnterMethodContent;
		}

		/// <summary>
		/// Returns contents of method to go in first state
		/// </summary>
		/// <returns></returns>
		public string GetFirstStateLeaveMethodContent() {
			return _firstStateLeaveMethodContent;
		}

		/// <summary>
		/// Returns contents of method to go in second state
		/// </summary>
		/// <returns></returns>
		public string GetSecondStateLeaveMethodContent() {
			return _secondStateLeaveMethodContent;
		}

		/// <summary>
		/// Returns contents of method to go in first state
		/// </summary>
		/// <returns></returns>
		public string GetFirstStateDoStateActionMethodContent() {
			return _firstStateDoStateActionMethodContent;
		}

		/// <summary>
		/// Returns contents of method to go in second state
		/// </summary>
		/// <returns></returns>
		public string GetSecondStateDoStateActionMethodContent() {
			return _secondStateDoStateActionMethodContent;
		}

		/// <summary>
		/// Returns contents of transition from first to second state
		/// </summary>
		/// <returns></returns>
		public string GetFirstToSecondStateTransitionContent() {
			return _firstToSecondStateTransitionContent;
		}

		/// <summary>
		/// Returns contents of transition from second to first state
		/// </summary>
		/// <returns></returns>
		public string GetSecondToFirstStateTransitionContent() {
			return _secondToFirstStateTransitionContent;
		}


		#endregion ReturnMethods
	}
}