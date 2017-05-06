using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Runtime.CompilerServices;

namespace GeneticAlgorithmForStrings {
	internal class DnaToCode {
        
        #region Fields

	    private int _numberOfVariables,										    //How many variables the robot gets to play with.
	                _geneIterator;		                                        //always call with ++ when used with genes.GetGene().

		private string _variableDeclarations,                                   //String with variable declarations of robot
					   _variableInitialisations;                                //String with variable declarations of robot

		private readonly Individual _genes;										//The genes to translate

		private const int StatementNumberSpread = 2,                            //1 means max 4 statements + minStatements, 2 means max 16 statements + minStatements, 3 means max 64 statements + minStatements, etc. 
						  MinActionStatements = 2,								//Minimum number of statements in each states DoStateAction 
                          MinEnterLeaveStatements = 0,						    //Minimum number of statements in each states EnterState and LeaveState
					      MinVariables = 5,									    //Minimum number of variables for numberOfVariables.
					      MaxConditons = 3,									    //Maximum number of conditions bound to same condition
					      GeneAccuracyInt = 3,								    //Number of genes to use when fetching an int
					      GeneAccuracyFloat = 3,							    //Number of genes to use when fetching a float
					      GeneAccuracyDouble = 3;							    //Number of genes to use when fetching a double

		private readonly string _firstStateEnterMethodContent,					//String with contents of first states enter method
					            _secondStateEnterMethodContent,					//String with contents of second states enter method
 					            _firstStateLeaveMethodContent,					//String with contents of first states leave method
					            _secondStateLeaveMethodContent,					//String with contents of second states leave method
 					            _firstStateDoStateActionMethodContent,			//String with contents of first states action method
					            _secondStateDoStateActionMethodContent,			//String with contents of second states action method
					            _firstToSecondStateTransitionContent,	        //String with contents of transition from first to second
					            _secondToFirstStateTransitionContent;           //String with contents of transition from second to first

		private readonly List<string> _finishedMethodCalls = new List<string> {						//String array with method calls robot can use. All calls from this array are called from a state class. 
			"KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians)",
            "OurRobot.Fire(500 / OurRobot.Enemy.Distance)",
            "CircularTargetFire()",
            "Example()"
		};

		private readonly List<RoboMethod> _roboMethodList = new List<RoboMethod> {
            new RoboMethod("None", new List<RoboMethodTypes>()),
            new RoboMethod("OneInt", new List<RoboMethodTypes>() {RoboMethodTypes.Int}),
            new RoboMethod("IntAndFloat", new List<RoboMethodTypes>() {RoboMethodTypes.Int, RoboMethodTypes.Float}),
            new RoboMethod("DoubDoub", new List<RoboMethodTypes>() {RoboMethodTypes.Double, RoboMethodTypes.Double}),
            new RoboMethod("DoubFloat", new List<RoboMethodTypes>() {RoboMethodTypes.Double, RoboMethodTypes.Float})
        };
		
        private readonly Dictionary<string, List<string>> _variableDictionary = new Dictionary<string, List<string>>();		// Block for variable contents. Check helpermethod SetUpVariableLists to see/edit values
		
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
	        _genes = genes;
	        Console.WriteLine("GeneIter:" + _geneIterator);

	        SetVariables();    //uses max 19 genes with 4-letter genes and minVariables = 5
			SetTransitions();

			//Set geneIterator to specific number to let next gene start at the same place each time and not get messed up by mutations in variables
	        Console.WriteLine("GeneIter:" + _geneIterator);
			_geneIterator = 20;
			

			// Sets content for transitions
			_firstToSecondStateTransitionContent = GetCondition(); //uses 5 genes TODO Recalculate max gene use.
			_secondToFirstStateTransitionContent = GetCondition(); //uses 5 genes 

	        Console.WriteLine("GeneIter:" + _geneIterator);
			_geneIterator = 30;
			

			// Sets content for state Enter                                                           //TODO Recalculate gene use      v
			_firstStateEnterMethodContent = CreateStateMethodContent(MinEnterLeaveStatements); //Worst Case use of genes = 1+6((1+5)*3) = 109
			Console.WriteLine("GeneIter:" + _geneIterator);
	        _geneIterator = 140;

			_secondStateEnterMethodContent = CreateStateMethodContent(MinEnterLeaveStatements);
			Console.WriteLine("GeneIter:" + _geneIterator);
			_geneIterator = 250;
            

			// Sets content for state Leave
			_firstStateLeaveMethodContent = CreateStateMethodContent(MinEnterLeaveStatements);
	        Console.WriteLine("GeneIter:" + _geneIterator);
	        _geneIterator = 360;

			_secondStateLeaveMethodContent = CreateStateMethodContent(MinEnterLeaveStatements);
            Console.WriteLine("GeneIter:" + _geneIterator);
            _geneIterator = 470;


		    // Sets content for state doAction
		     _firstStateDoStateActionMethodContent = CreateStateMethodContent(MinActionStatements);
	        Console.WriteLine("GeneIter:" + _geneIterator);
			_geneIterator = 580;

			_secondStateDoStateActionMethodContent = CreateStateMethodContent(MinActionStatements);
			Console.WriteLine("GeneIter:" + _geneIterator);
		}

        /// <summary>
        /// Sets up variable lists. Holds all variables robot can access
        /// </summary>
        private void SetUpVariableLists() {

            _doubleVarList = new List<string>
            {
                "X",
                "Y",
                "Velocity",
                "Energy",
                "Heading",
                "Height",
                "Width",
                "RadarHeading",	//RadarHeading only uses degrees. Always using degrees because this isn't the only case. (Though only using radians would be preferable)
				"GunHeat",
                "GunHeading",
                "BattleFieldWidth",
                "BattleFieldHeight",
                "Enemy.Distance",
                "Enemy.Energy",
                "Enemy.Position.X",
                "Enemy.Position.Y",
                "Enemy.Velocity",
                "Enemy.Acceleration",
                "Enemy.BearingDegrees",
                "Enemy.HeadingDegrees",
                "Enemy.TurnRateDegrees"
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
                "0.001f",
                "1.1f",
                "5.5f",
                "3.2f",
                "9.9f",
                "3.1415928f",		//Pi
				"1.618f",			//Phi
				"2.718281828459f",	//Euler's number
				"1.41421f"			//Pythagoras' constant
			};

            // Adding lists to dictionary
            _variableDictionary.Add("double", _doubleVarList);  //Having only 3 lists doubles chance of first element (with 4-letter dna), which is preferable here
            _variableDictionary.Add("float", _floatVarList);
            _variableDictionary.Add("int", _intVarList);
        }
        
		/// <summary>
		/// Sets content of variables.
		/// </summary>
		/// <param name="genes"></param>
		private void SetVariables()
		{
			SetUpVariableLists();

			var variableDeclarations = "public ";
		    var variableInitialisations = "";
			var geneIter = _geneIterator;

		    SetNumberOfVariables(GetNextGene());
			
		    for (var i = geneIter; i < _numberOfVariables; i++) {
				var gene = GetNextGene();
				var type = _variableDictionary.ElementAt(GeneToNumber(gene) % _variableDictionary.Count).Key;
				var valueList = _variableDictionary.ElementAt(GeneToNumber(gene) % _variableDictionary.Count).Value;
				var value = valueList[GenesToNumber(GetNecessaryNumberOfGenes(valueList.Count)) % valueList.Count];
				
			    if (i > geneIter) {
				    variableDeclarations += "\npublic ";
				    variableInitialisations += "\n";
				}
				
				variableDeclarations += type + " V" + i + " { get; set; }";
			    variableInitialisations += "V" + i + " = " + value + ";";
				
		    }
			_variableDeclarations = variableDeclarations;
			_variableInitialisations = variableInitialisations;
		}

		/// <summary>
		/// Initialises transitionslist and fills it with transitions based on number of variables this bot has. 
		/// </summary>
		private void SetTransitions() {
			_transitionsList = new List<string>();

			for (var i = 0; i < _numberOfVariables; i++) {
				for (var j = 0; j < _numberOfVariables; j++) {
					if (i == j) continue;   //Comparing a variable with itself is not going to be the best solution, so we skip those.

					_transitionsList.Add("OurRobot.V" + i + "<" + "OurRobot.V" + j);
					_transitionsList.Add("OurRobot.V" + i + ">" + "OurRobot.V" + j);
					_transitionsList.Add("OurRobot.V" + i + "<=" + "OurRobot.V" + j);
					_transitionsList.Add("OurRobot.V" + i + ">=" + "OurRobot.V" + j);
					_transitionsList.Add("OurRobot.V" + i + "==" + "OurRobot.V" + j);
					_transitionsList.Add("OurRobot.V" + i + "!=" + "OurRobot.V" + j);
				}
			}
			//Max transitions in _transitionsList with 6 comparators and 8 variables is 432 transitions
		}

		/// <summary>
		/// Creates a string with the contents of a method
		/// </summary>
		/// <param name="genes"></param>
		/// <param name="minStatements"></param>
		/// <param name="block"></param>
		/// <returns></returns>
		private string CreateStateMethodContent(int minStatements) {
			var contents = "";
			var statements = GenesToNumber(StatementNumberSpread, minStatements);
			for (var i = 0; i < statements; i++) {
				contents += "\n" + GetStatement();
			}
			return contents;
		}
		
		/// <summary>
		/// Returns condition from block with index based on genes. 
		/// </summary>
		/// <param name="depth"></param>
		/// <returns></returns>
		private string GetCondition(int depth = 0)
		{
			var gene1 = GetNextGene();
			var index = GenesToNumber(GetNecessaryNumberOfGenes(_transitionsList.Count));
			
			var condition = _transitionsList[index % _transitionsList.Count];
			if (depth >= MaxConditons) return condition;

			switch (GeneToNumber(gene1)) {
				case 0:
					condition += " && " + GetCondition(++depth);
					break;
				case 1:
					condition += " || " + GetCondition(++depth);
					break;
			}
			return condition;
		}
		
#endregion CreateCodeContent

		#region HelperMethods
		
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
		/// Gets the next gene from genes.
		/// </summary>
		/// <returns></returns>
		private char GetNextGene() {
			return _genes.GetGene(_geneIterator++);
		}

		/// <summary>
		/// Returns a number between minNumber and minNumber + 4^numberOfGenes based on genes
		/// </summary>
		/// <param name="genes"></param>
		/// <param name="numberOfGenes"></param>
		/// <param name="minNumber"></param>
		/// <returns></returns>
		private int GenesToNumber(int numberOfGenes, int minNumber = 0)
		{
			var geneL = new List<int>();
			var num = 0;

			for (var i = 0; i < numberOfGenes; i++) {
				geneL.Add(GeneToNumber(GetNextGene()));
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
		private string GetStatement(int depth = 0)
		{
			var statement = "";
			var gene1 = GetNextGene();
			
			switch (gene1) {
				case 'a':
					if (depth < 3) statement += GetIfStatement(depth);
					else statement += GetMethodCall();
					break;
				case 't':
					if (depth < 2) statement += GetLoop(depth);
					else statement += GetMethodCall();
					break;
				case 'c':
				case 'g':
					statement += GetMethodCall();
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
		private string GetLoop(int depth) {
			var statement = "";
			statement += "while(";
			statement += GetCondition();
			statement += "){";
			statement += GetStatement(++depth);
			statement += "}";
			return statement;
		}

		/// <summary>
		/// Returns an if-statement with condition and statements inside.
		/// </summary>
		/// <param name="genes"></param>
		/// <param name="depth"></param>
		/// <returns></returns>
		private string GetIfStatement(int depth) {
			var statement = "";
			statement += "if(";
			statement += GetCondition();
			statement += "){";
			statement += GetStatement(++depth);
			statement += "}";
			return statement;
		}

		/// <summary>
		/// Returns a method call from _methodcalls using 2 genes. If _finishedMethodCalls have more than 16 elements, refactor.
		/// </summary>
		/// <param name="genes"></param>
		/// <returns></returns>
		private string GetMethodCall()
		{
			if (GeneToNumber(GetNextGene()) >= 2)
				return "/*" +_finishedMethodCalls[GenesToNumber(GetNecessaryNumberOfGenes(_finishedMethodCalls.Count)) % _finishedMethodCalls.Count] + ";*/";
			
			var geneNum = GetNecessaryNumberOfGenes(_roboMethodList.Count);
			var returnString ="/*" + _roboMethodList[geneNum].MethodName + "(";
			
			while (_roboMethodList[geneNum].TypeRequired.Count > 0)
			{
				var rType = _roboMethodList[geneNum].TypeRequired.Dequeue();

				if (rType.Equals(RoboMethodTypes.Int)) returnString += FetchInt();
				else if (rType.Equals(RoboMethodTypes.Float)) returnString += FetchFloat();
				else if (rType.Equals(RoboMethodTypes.Double)) returnString += "OurRobot." + FetchDouble();
				//TODO add more types to support

				if (_roboMethodList[geneNum].TypeRequired.Count > 0) returnString += ",";	//If there's no params left to fill, don't put comma.
			}
			
			returnString += ");*/";
			return returnString;
		}

		/// <summary>
		/// Returns the minimum number of genes that can cover the entire list
		/// </summary>
		/// <param name="listLength"></param>
		/// <returns></returns>
		private static int GetNecessaryNumberOfGenes(int listLength)
		{
			for (var i = 0; i < 10; i++)
			{
				if (Math.Pow(Algorithm.AllowedLetters.Length, i) < listLength) continue;
				return i;
			}
			return -1;
		}

		/// <summary>
		/// returns an int either from list of ints or created from genes. This choice is made by the genes.
		/// </summary>
		/// <returns></returns>
	    private string FetchInt()
	    {
	        var gene = GetNextGene();  //Used to decide to fetch or create int

	        if (GeneToNumber(gene) >= 2)
	        {
	            return GenesToNumber(GeneAccuracyInt, -32).ToString();
	        }

		    List<string> list;
			_variableDictionary.TryGetValue("Int", out list);
			return list != null ? list[GenesToNumber(GeneAccuracyInt) % list.Count] : "-1";
	    }

		/// <summary>
		/// Returns a float from a list of floats with index chosen by genes.
		/// </summary>
		/// <returns></returns>
	    private string FetchFloat()
		{
			List<string> list;
			_variableDictionary.TryGetValue("Float", out list);
			return list != null ? list[GenesToNumber(GeneAccuracyFloat) % list.Count] : "-1.0f";
        }

		/// <summary>
		/// Returns a double from a list of doubles with index chosen by genes.
		/// </summary>
		/// <returns></returns>
		private string FetchDouble()
	    {
		    List<string> list;
			_variableDictionary.TryGetValue("Double", out list);
			return list != null ? list[GenesToNumber(GeneAccuracyDouble) % list.Count] : "-1.0";
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