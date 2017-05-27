using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Mathos.Parser;

namespace GeneticAlgorithmForStrings {
	internal class DnaToCode {
        
        #region Fields

	    private int _numberOfVariables,										    //How many variables the robot gets to play with.
	                _geneIterator;		                                        //always call with ++ when used with genes.GetGene().

		private string _variableDeclarations,                                   //String with variable declarations of robot
					   _variableInitialisations;                                //String with variable declarations of robot

		private readonly Individual _genes;										//The genes to translate

		private const int StatementNumberSpread = 1,                            //1 means max 4 statements + minStatements, 2 means max 16 statements + minStatements, 3 means max 64 statements + minStatements, etc. 
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
//			"KeepRadarLock(OurRobot.HeadingRadians + OurRobot.TargetedEnemy.BearingRadians)",
            "OurRobot.SetFire(500 / OurRobot.TargetedEnemy.Distance)",
            "OurRobot.SetFire(1)",
//            "OurRobot.SetFire(2)",
            "OurRobot.SetFire(3)",
//            "CircularTargetFire()",
//            "Example()"
			"TurnRadar()",
			"SpinRadar()",
			"TurnGun()",
		};

		private readonly List<RoboMethod> _roboMethodList = new List<RoboMethod> {
            new RoboMethod("SetAhead", new List<RoboMethodTypes>() {RoboMethodTypes.Double}),
            new RoboMethod("SetBack", new List<RoboMethodTypes>() {RoboMethodTypes.Double}),
//            new RoboMethod("SetFire", new List<RoboMethodTypes>() {RoboMethodTypes.Double}),
            new RoboMethod("SetTurnGunLeftRadians", new List<RoboMethodTypes>() {RoboMethodTypes.Double}),
            new RoboMethod("SetTurnGunRightRadians", new List<RoboMethodTypes>() {RoboMethodTypes.Double}),
            new RoboMethod("SetTurnRadarLeftRadians", new List<RoboMethodTypes>() {RoboMethodTypes.Double}),
            new RoboMethod("SetTurnRadarRightRadians", new List<RoboMethodTypes>() {RoboMethodTypes.Double}),
            new RoboMethod("SetTurnLeftRadians", new List<RoboMethodTypes>() {RoboMethodTypes.Double}),
            new RoboMethod("SetTurnRightRadians", new List<RoboMethodTypes>() {RoboMethodTypes.Double})
//            new RoboMethod("DoubleFloat", new List<RoboMethodTypes>() {RoboMethodTypes.Double, RoboMethodTypes.Float})
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

            SetVariables();     //Uses max 29 genes
            SetTransitions();
            _geneIterator = 30; //Set geneIterator to specific number to let next gene start at the same place each time and not get messed up by mutations earlier in translation

//            Console.WriteLine("Should have setUp Transitions by now!");
            // Sets content for transitions
            _firstToSecondStateTransitionContent = GetCondition(); //Uses max 18
            _geneIterator = 50;
            _secondToFirstStateTransitionContent = GetCondition(); //Uses max 18
            _geneIterator = 70;

			// Sets content for state Enter                                                           
			_firstStateEnterMethodContent = CreateStateMethodContent(MinEnterLeaveStatements);      //Uses max 232 with MinEnterLeaveStatements = 0
	        _geneIterator = 310;
            _secondStateEnterMethodContent = CreateStateMethodContent(MinEnterLeaveStatements);     //Uses max 232 with MinEnterLeaveStatements = 0
            _geneIterator = 550;
            

			// Sets content for state Leave
			_firstStateLeaveMethodContent = CreateStateMethodContent(MinEnterLeaveStatements);      //Uses max 232 with MinEnterLeaveStatements = 0
            _geneIterator = 790;
            _secondStateLeaveMethodContent = CreateStateMethodContent(MinEnterLeaveStatements);     //Uses max 232 with MinEnterLeaveStatements = 0
            _geneIterator = 1030;
            
		    // Sets content for state doAction
		     _firstStateDoStateActionMethodContent = CreateStateMethodContent(MinActionStatements); //Uses max 386 with MinActionStatements = 2
			_geneIterator = 1420;
            _secondStateDoStateActionMethodContent = CreateStateMethodContent(MinActionStatements); //Uses max 386 with MinActionStatements = 2
            //_geneIterator = 1820              //Just to decide what Gene total length should be. No need to set variable here. 
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
                "HeadingRadians",
                "Height",
                "Width",
				"RadarHeadingRadians",
				"RadarTurnRemainingRadians",
				"TurnRemainingRadians",
				"GunHeat",
                "GunHeadingRadians",
                "GunTurnRemainingRadians",
                "BattleFieldWidth",
                "BattleFieldHeight",
                "TargetedEnemy.Distance",
                "TargetedEnemy.Energy",
                "TargetedEnemy.Position.X",
                "TargetedEnemy.Position.Y",
                "TargetedEnemy.Velocity",
                "TargetedEnemy.Acceleration",
                "TargetedEnemy.BearingRadians",
                "TargetedEnemy.HeadingRadians",
                "TargetedEnemy.TurnRateRadians",
            };

            _intVarList = new List<string>
            {
//                "(-1)",
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
                "69",
                "420",
                "710",
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
            _variableDictionary.Add("double", _doubleVarList);  //Having only 3 lists increases chance of first element (with 4-letter dna), which is preferable here
            _variableDictionary.Add("float", _floatVarList);
            _variableDictionary.Add("int", _intVarList);
        }

	    /// <summary>
	    /// Sets how many variables the robot gets to play with
	    /// </summary>
	    /// <param name="gene"></param>
	    private void SetNumberOfVariables(char gene) {
//	        Console.WriteLine("Setting no of VARS");
//	        Console.WriteLine("Algorithm.AllowedLetters.Length: " + Algorithm.AllowedLetters.Length);
	        for (var i = 0; i < Algorithm.AllowedLetters.Length; i++) {
//	            Console.WriteLine("VAR-Setting iteration: " + i);
	            if (gene != Algorithm.AllowedLetters[i]) continue;
	            _numberOfVariables = i + MinVariables;
//	            Console.WriteLine("Sat no of VARS");
	        }
	    }

	    /// <summary>
	    /// Initialises transitionslist and fills it with transitions based on number of variables this bot has. 
	    /// </summary>
	    private void SetTransitions() {
	        _transitionsList = new List<string>();
//	        Console.WriteLine("Setting up Transitions, NumberOfVars = " + _numberOfVariables);
	        for (var i = 0; i < _numberOfVariables; i++) {
//	            Console.WriteLine("In I Loop");
	            for (var j = 0; j < _numberOfVariables; j++) {
//	                Console.WriteLine("In J loop");
	                if (i == j) continue;   //Comparing a variable with itself is not going to be the best solution, so we skip those.

	                _transitionsList.Add("OurRobot.V" + i + "<" + "OurRobot.V" + j);
	                _transitionsList.Add("OurRobot.V" + i + ">" + "OurRobot.V" + j);
	                _transitionsList.Add("OurRobot.V" + i + "<=" + "OurRobot.V" + j);
	                _transitionsList.Add("OurRobot.V" + i + ">=" + "OurRobot.V" + j);
	                _transitionsList.Add("OurRobot.V" + i + "==" + "OurRobot.V" + j);
	                _transitionsList.Add("OurRobot.V" + i + "!=" + "OurRobot.V" + j);
//	                Console.WriteLine("Added transitions");
	            }
	        }
	        //Max transitions in _transitionsList with 6 comparators and 8 variables is 432 transitions
//	        Console.WriteLine(_transitionsList.Count);
	    }
        
	    /// <summary>
		/// Sets content of variables.
		/// </summary>
		private void SetVariables()                                     //Worst case gene use: 1 + 7*(1+necessaryGenes( 3 )) = 29
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
		/// Creates a string with the contents of a method
		/// </summary>
		/// <param name="minStatements"></param>
		/// <returns></returns>
		private string CreateStateMethodContent(int minStatements)      //Worst case gene use: StatementNumSpread(1) + (minStatements (2) + 3)* GetStatement ( 77 ) = 1+5*77 = 386
        {
			var contents = "";
			var statements = GenesToNumber(StatementNumberSpread, minStatements);
			for (var i = 0; i < statements; i++) {
				contents += "\n" + GetStatement();
			}
			return contents;
		}

	    #endregion CreateCodeContent

	    #region HelperMethods

	    #region GeneHelpers

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

	    #endregion

        /// <summary>
	    /// Returns condition from block with index based on genes. 
	    /// </summary>
	    /// <param name="depth"></param>
	    /// <returns></returns>
	    private string GetCondition(int depth = 0)                      //Worst case gene use: (1 + necessaryGenes ( 5 ))*MaxDepth ( 3 ) = 18
	    {
	        var gene1 = GetNextGene();
	        var index = GenesToNumber(GetNecessaryNumberOfGenes(_transitionsList.Count));
//	        Console.WriteLine("TransitionListLength: " + _transitionsList.Count);
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

	    /// <summary>
		/// Returns string with a method call, if-statement, or a loop.
		/// </summary>
		/// <param name="depth">Call with </param>
		/// <returns></returns>
		private string GetStatement(int depth = 0)                      //Worst case gene use: 1 + (ifStatement (18) * MaxDepth (3)) + GetMethodCall ( currently 22) = 77
		{
			var statement = "";
			var gene1 = GetNextGene();
			
			switch (gene1) {
				case 'a':
					if (depth < 3) statement += GetIfStatement(depth);
					else statement += GetMethodCall();
					break;
				case 't':
					//if (depth < 2) statement += GetLoop(depth);                               //removed to prevent infinite loops
					//else statement += GetMethodCall();
					//break;
				case 'c':
				case 'g':
					statement += GetMethodCall();
					break;
			}
			return statement;
		}
        
	    /// <summary>
		/// Returns an if-statement with condition and statements inside.
		/// </summary>
		/// <param name="depth"></param>
		/// <returns></returns>
		private string GetIfStatement(int depth)                        //Worst case gene use: GetCondition ( currently 18 ) 
        {
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
		/// <returns></returns>
		private string GetMethodCall()                                  //Worst case gene use: 1 + neccessaryGenes(currently 2) + parameters.length(current method with the most parameters has 1) * FetchDouble(currently 19) = 22
		{
			if (GeneToNumber(GetNextGene()) >= 2)
				return _finishedMethodCalls[GenesToNumber(GetNecessaryNumberOfGenes(_finishedMethodCalls.Count)) % _finishedMethodCalls.Count] + ";";
			
			var geneNum = GetNecessaryNumberOfGenes(_roboMethodList.Count); 
			var returnString = "OurRobot." + _roboMethodList[geneNum].MethodName + "(";

		    var parameters = _roboMethodList[geneNum].TypeRequired.ToArray();
            
			for(var i = 0; i < parameters.Length; i++)
			{
				var rType = parameters[i];

				if (rType.Equals(RoboMethodTypes.Int)) returnString += FetchInt();
				else if (rType.Equals(RoboMethodTypes.Float)) returnString += FetchFloat();
				else if (rType.Equals(RoboMethodTypes.Double)) returnString += FetchDouble();
                else Console.WriteLine("That parameterType isn't supported yet");
				//TODO add more types to support

				if (i < parameters.Length -1) returnString += ",";	//If there's no params left to fill, don't put comma.
			}
			
			returnString += ");";
			return returnString;
		}

	    /// <summary>
		/// returns an int either from list of ints or created from genes. This choice is made by the genes.
		/// </summary>
		/// <returns></returns>
	    private string FetchInt()                                       //Worst case gene use: 1 + 1 + 4*GeneAccuracyInt(currently 3) + 2*1 = 16
	    {
            if (GeneToNumber(GetNextGene()) >= 2)  //Used to decide to fetch or create int
            {
                var operators = "+-*".ToCharArray();
	            var geneNum = GeneToNumber(GetNextGene())+1;    //+1 to make sure it doesn't parse 0 numbers and -1 operators. 
	            var a = new string[geneNum];       //Number of ints to put together
	            for (var i = 0; i < geneNum; i++)
	            {
	                a[i] = GenesToNumber(GeneAccuracyInt, GeneAccuracyInt / 2 * -1).ToString();
	            }
                
	            var b = new char[--geneNum];       //Number of operators to put between ints
                for (var i = 0; i < geneNum; i++)
                {
                    b[i] = operators[GeneToNumber(GetNextGene()) % operators.Length];
                }
                return GetParseExpression(a, b);    //Returns a string that's something like "1+3*2"
            }
            List<string> list;
			_variableDictionary.TryGetValue("int", out list);
			return list != null ? list[GenesToNumber(GeneAccuracyInt) % list.Count] : "(-1)";
	    }
        
		/// <summary>
		/// Returns a float from a list of floats with index chosen by genes.
		/// </summary>
		/// <returns></returns>
	    private string FetchFloat()                                     //Worst case gene use: GeneAccuracyFloat (currently 3) = 3
		{
            //Parse tree expression not setup because floats not in use in any methods
			List<string> list;
			_variableDictionary.TryGetValue("float", out list);
			return list != null ? list[GenesToNumber(GeneAccuracyFloat) % list.Count] + "f" : "-1.0f";
        }
        
		/// <summary>
		/// Returns a double from a list of doubles with index chosen by genes.
		/// </summary>
		/// <returns></returns>
		private string FetchDouble()                                    //Worst case gene use: 1 + 1 + 4*(1 + GeneAccuracyDouble(currently 3)) + 1 = 19
	    {
	        List<string> list;
	        var geneNum = GeneToNumber(GetNextGene()); 
            if (geneNum == 0)            //25% chance of choosing a number from the float list
	        {
	            _variableDictionary.TryGetValue("float", out list);
	            var floatString = list != null ? list[GenesToNumber(GeneAccuracyFloat) % list.Count] : "(-1.0)0";
                return floatString.Substring(0,floatString.Length-1);    //Convert float to double
            }

	        if (geneNum == 1)            //25% chance of choosing a number from the double list
	        {
	            _variableDictionary.TryGetValue("double", out list);
	            return list != null ? "OurRobot." + list[GenesToNumber(GeneAccuracyDouble) % list.Count] : "(-1.0)";
	        }

	        var operators = "+-*/".ToCharArray();
	        var geneNum2 = GeneToNumber(GetNextGene())+1;    //+1 to make sure it doesn't parse 0 numbers and -1 operators.
            var a = new string[geneNum2];       //Decides number of variables in expression
	        for (var i = 0; i < geneNum2; i++)
	        {
	            var geneNum3 = GeneToNumber(GetNextGene());
	            if (geneNum3 < 1)                       //25% chance of generating int number
	                a[i] = GenesToNumber(GeneAccuracyDouble, GeneAccuracyDouble / 2 * -1).ToString();
	            else if (geneNum3 < 2)                  //50% chance of fetching variable from float list
	            {
	                _variableDictionary.TryGetValue("float", out list);
	                var floatString = list != null ? list[GenesToNumber(GeneAccuracyFloat) % list.Count] : "(-1.0)0";
	                a[i] = floatString.Substring(0, floatString.Length - 1);    //Convert float to double
	            }
	            else
	            {                                       //50% chance of fetching variable from double list
	                _variableDictionary.TryGetValue("double", out list);
	                a[i] = list != null ? "OurRobot." + list[GenesToNumber(GeneAccuracyDouble) % list.Count] : "(-1.0)";
	            }
	        }

	        var b = new char[--geneNum2];       //Number of operators to put between variables
	        for (var i = 0; i < geneNum2; i++) {
	            b[i] = operators[GeneToNumber(GetNextGene()) % operators.Length];
	        }
	        return GetParseExpression(a, b);    //Returns a string that's something like "1.0+3.2*20"
	    }
        
	    /// <summary>
	    /// Returns variableArray string with an expression that can be parsed by the Mathos MathParser.
	    /// </summary>
	    /// <param name="variableArray">variables to add together</param>
	    /// <param name="operatorsInOrder">operators to put between variables. Length should always be variableArray.length -1 </param>
	    /// <returns></returns>
	    private string GetParseExpression(string[] variableArray, char[] operatorsInOrder) {
	        var returnstring = variableArray[0];
	        for (var i = 1; i < variableArray.Length; i++) {
	            if (operatorsInOrder[i - 1] == '/' && variableArray[i] == "0")      //We do not want to divide by zero
	                variableArray[i] = "1";

	            if (char.IsNumber(variableArray[i][0]) || variableArray[i][0] == 'O')   //The strings should always start with a number or "OurRobot" if it's a double variableName.                     
	                returnstring +=
	                    $"{operatorsInOrder[i - 1]}{variableArray[i]}";             //operatorsInOrder[i-1] is because operatorsInOrder.Length should always be variableArray.length - 1
	            else
	                returnstring += $"{operatorsInOrder[i - 1]}{variableArray[i].Substring(1, variableArray[i].Length-1)}"; //Negative numbers has caused some issues, so here's a hack to make negative numbers positive. Would make a better solution given more time. 
                
            }
	        return returnstring;
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