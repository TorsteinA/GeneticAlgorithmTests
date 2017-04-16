using System.Collections.Generic;
using System.Linq;

namespace GeneticAlgorithmForStrings {
	internal class DnaToCode {
        
        #region Fields

	    private int _numberOfVariables,                     //How many variables the robot gets to play with.
	                _geneIterator = 0;		                //always call with ++ when used with genes.GetGene().

		private const int MinStatements = 2,		        //Minimum number of statements in each states DoStateAction 
                          MinEnterLeaveStatements = 0,      //Minimum number of statements in each states EnterState and LeaveState
                          MinConditions = 0,                //Minimum number of conditions ( serparated by && or ||) for each call.
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

		private readonly string[] 
                        _blockA = { "ourRobot.v1 == ourRobot.v2",	                                            // Block for state transitions		//TODO Needs rethinking to incorporate variable types correctly.
                                    "ourRobot.v1 != ourRobot.v2",								                // Has content for if statements
                                    "ourRobot.v1 <= ourRobot.v2",	                                            // Format example: v1 == v2
                                    "ourRobot.v1 > ourRobot.v2",	                                            // Both states will use this block
                                    "" },

                        _blockB = { "",								                                            // Block for Enter and Leave State content
                                    "",								                                            // Has method calls and perhaps statements/loops
                                    "",								                                            // Format example: DoMethodCall(param1, param2);
                                    "" },							                                            // Both states will use this block

                        _blockC = { "KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);",	// Block for DoStateAction content
                                    "ourRobot.Fire(500 / ourRobot.Enemy.Distance);",							// Has method calls and statements/loops
                                    "CircularTargetFire()",							                            // Format example: DoMethodCall(param1, param2);
                                    "ourRobot.TurnRight()", //Needs parameters							        // Both states will use this block
                                    "",
                                    "",
                                    "",
                                    "",
                                    "",
                                    "",
                                    "",
                                    "" };

		private readonly Dictionary<string, List<string>> _variableDictionary = new Dictionary<string, List<string>>();		// Block for variable contents. Check helpermethod SetupVariableLists to see/edit values
		//private readonly Dictionary<string, List<string>> _methodDictionary = new Dictionary<string, List<string>>();		// Block for method contents. Check helpermethod SetupMethods to see/edit values


		private List<string> intVarList, floatVarList, doubleVarList, stringVarList, voidMethodList, intMethodList, floatMethodList, doubleMethodList, stringMethodList;
		

#endregion Fields

        #region CreateCodeContent

        /// <summary>
            /// Constructor of DnaToCode class
            /// </summary>
            /// <param name="genes"></param>
        public DnaToCode(Individual genes)
        {
			// Sets content for variables
			SetVariables(genes);    //uses max 9 genes with 4-letter genes and minVariables = 5		//TODO recalculate
			
			//Set geneIterator to specific number to let next gene start at the same place each time and not get messed up by mutations in variables
			_geneIterator = 10;
			/*
			// Sets content for transitions
			_firstToSecondStateTransitionContent = GetCondition(genes, MinConditions); //uses max 8 genes with 4-letter genes and minCondition = 0
			_secondToFirstStateTransitionContent = GetCondition(genes, MinConditions); //uses max 8 genes with 4-letter genes and minCondition = 0

            _geneIterator = 30;

			// Sets content for state Enter
			_firstStateEnterMethodContent = CreateStateMethodContent(genes, MinEnterLeaveStatements, _blockB);  //Uses max 9 genes with 4-letter genes and minEnterLeaveStatements = 0
		    _secondStateEnterMethodContent = CreateStateMethodContent(genes, MinEnterLeaveStatements, _blockB); //Uses max 9 genes with 4-letter genes and minEnterLeaveStatements = 0

            _geneIterator = 50;
            
			// Sets content for state Leave
			_firstStateLeaveMethodContent = CreateStateMethodContent(genes, MinEnterLeaveStatements, _blockB);  //Uses max 9 genes with 4-letter genes and minEnterLeaveStatements = 0
            _secondStateLeaveMethodContent = CreateStateMethodContent(genes, MinEnterLeaveStatements, _blockB); //Uses max 9 genes with 4-letter genes and minEnterLeaveStatements = 0
            
            _geneIterator = 70;

		    // Sets content for state doAction
		     _firstStateDoStateActionMethodContent = CreateStateMethodContent(genes, MinStatements, _blockC);   //Uses max 13 genes with 4-letter genes and minStatements = 2
		    _secondStateDoStateActionMethodContent = CreateStateMethodContent(genes, MinStatements, _blockC);   //Uses max 13 genes with 4-letter genes and minStatements = 2
			*/
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
			
		    for (var i = geneIter; i < _numberOfVariables; i++)
		    {

			    var gene = genes.GetGene(_geneIterator++);

			    var type = _variableDictionary.ElementAt(GetNumberFromSingleGene(gene, 0) % _variableDictionary.Count).Key;
				var valueList = _variableDictionary.ElementAt(GetNumberFromSingleGene(gene, 0) % _variableDictionary.Count).Value;
				var value = valueList[GetNumberFromDoubleGene(genes.GetGene(_geneIterator++), genes.GetGene(_geneIterator++), 0) % valueList.Count];


			    if (i > geneIter)
			    {
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
		private string CreateStateMethodContent(Individual genes, int minStatements, IReadOnlyList<string> block) {
			var contents = "";
			var statements = GetNumberFromSingleGene(genes.GetGene(_geneIterator++), minStatements);
			for (var i = 0; i < statements; i++) {
				contents += "\n" + GetStatement(genes, block);
			}
			return contents;
		}

	    /// <summary>
	    /// Returns condition that can be used with statements
	    /// </summary>
	    /// <param name="genes"></param>
	    /// <param name="depth"></param>
	    /// <returns></returns>
	    private string GetCondition(Individual genes, int depth) {
            
            //If new gene is 0 or 1, do nothing, if it's 2, use &&, if it's 3, use || ?
            
            const int depthLimit = 2;
            var transitionContent = "";
            var geneChars = Algorithm.AllowedLetters;
            var gene1 = genes.GetGene(_geneIterator++);
            var gene2 = genes.GetGene(_geneIterator++);
            
            //Adds condition from block
            for (var i = 0; i <= geneChars.Length; i++) {
                for (var j = 0; j < geneChars.Length; i++) {
                    if (gene1 != geneChars[i] || gene2 != geneChars[j]) continue;
                    if ((geneChars.Length * i + j) > _numberOfVariables) {
                        transitionContent = _blockA[(geneChars.Length * i + j)];
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
                    transitionContent += " && " + GetCondition(genes, ++depth);
                    break;
                case 't':
                    transitionContent += " || " + GetCondition(genes, ++depth);
                    break;
            }

            return transitionContent;
        }

		#endregion CreateCodeContent

		#region HelperMethods
		
		private void SetupVariableLists() {
			
			intVarList = new List<string>();
			floatVarList = new List<string>();
			doubleVarList = new List<string>();

			intVarList.Add("0");
			intVarList.Add("1");
			intVarList.Add("2");
			intVarList.Add("3");
			intVarList.Add("4");
			intVarList.Add("5");
			intVarList.Add("6");
			intVarList.Add("7");
			intVarList.Add("8");
			intVarList.Add("9");
			intVarList.Add("10");
			intVarList.Add("42");
			intVarList.Add("420");
			intVarList.Add("9999999");

			floatVarList.Add("0.001");
			floatVarList.Add("1.1");
			floatVarList.Add("5.5");
			floatVarList.Add("3.2");
			floatVarList.Add("9.9");
			floatVarList.Add("3.1415928");		//Pi
			floatVarList.Add("1.618");			//Phi
			floatVarList.Add("2.718281828459"); //Euler's number
			floatVarList.Add("1.41421");		//Pythagoras' constant

			doubleVarList.Add("ourRobot.RadarHeading");		//RadarHeading only uses degrees. Always using degrees because this isn't the only case.
			doubleVarList.Add("ourRobot.GunHeat");
			doubleVarList.Add("ourRobot.GunHeading");
			doubleVarList.Add("ourRobot.X");
			doubleVarList.Add("ourRobot.Y");
			doubleVarList.Add("ourRobot.BattleFieldWidth");
			doubleVarList.Add("ourRobot.BattleFieldHeight");
			doubleVarList.Add("ourRobot.Heading");
			doubleVarList.Add("ourRobot.Height");
			doubleVarList.Add("ourRobot.Width");
			doubleVarList.Add("ourRobot.Velocity");
			doubleVarList.Add("ourRobot.Energy");
			doubleVarList.Add("ourRobot.Enemy.Distance");
			doubleVarList.Add("ourRobot.Enemy.Energy");
			doubleVarList.Add("ourRobot.Enemy.Position.X");
			doubleVarList.Add("ourRobot.Enemy.Position.Y");
			doubleVarList.Add("ourRobot.Enemy.Velocity");
			doubleVarList.Add("ourRobot.Enemy.Acceleration");
			doubleVarList.Add("ourRobot.Enemy.BearingDegrees"); 
			doubleVarList.Add("ourRobot.Enemy.HeadingDegrees");
			doubleVarList.Add("ourRobot.Enemy.TurnRateDegrees");

//			stringVarList.Add("");

			// Adding lists to dictionary
			_variableDictionary.Add("double", doubleVarList);
			_variableDictionary.Add("float", floatVarList);
			_variableDictionary.Add("int", intVarList);
//			_variableDictionary.Add("string", stringVarList);
		}

		/*
		private void SetupMethods() {

			intMethodList.Add();
			floatMethodList.Add();
			doubleMethodList.Add();
			stringMethodList.Add();

			// Adding lists to dictionary
			_methodDictionary.Add("int", intMethodList);
			_methodDictionary.Add("float", floatMethodList);
			_methodDictionary.Add("double", doubleMethodList);
			_methodDictionary.Add("string", stringMethodList);
		}
		*/
		
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
        /// Returns a number based on minNumber and gene. Will vary from minNumber to minNumber + 4
        /// </summary>
        /// <param name="gene"></param>
        /// <param name="minNumber"></param>
        /// <returns></returns>
        private static int GetNumberFromSingleGene(char gene, int minNumber) {
            for (var i = 0; i < Algorithm.AllowedLetters.Length; i++) {
                if (gene == Algorithm.AllowedLetters[i]) {
                    return i + minNumber;
                }
            }
            return 0;
        }
		
		/// <summary>
		/// Returns a number based on minNumber and two genes. Will vary from minNumber to minNumber + 16
		/// </summary>
		/// <param name="gene1"></param>
		/// <param name="gene2"></param>
		/// <param name="minNumber"></param>
		/// <returns></returns>
		private static int GetNumberFromDoubleGene(char gene1, char gene2, int minNumber) {
			for (var i = 0; i < Algorithm.AllowedLetters.Length; i++) {
				for (var j = 0; j < Algorithm.AllowedLetters.Length; j++) {
					if (gene1 == Algorithm.AllowedLetters[i] && gene2 == Algorithm.AllowedLetters[j]) {
						return Algorithm.AllowedLetters.Length*i + j + minNumber;
					}
				}
			}
			return 0;
		}
		/*
		/// <summary>
		/// Returns name of variable robot has access to based on genes.
		/// </summary>
		/// <param name="gene1"></param>
		/// <param name="gene2"></param>
		/// <returns></returns>
		private string GetVariableName(char gene1, char gene2) {	//Might need parameter for variable type to have all code compile.
            var varName = "";
            var geneChars = Algorithm.AllowedLetters;

            for (var i = 0; i <= geneChars.Length; i++) {
                for (var j = 0; j < geneChars.Length; i++)
                {
                    if (gene1 != geneChars[i] || gene2 != geneChars[j]) continue;
                    if ((geneChars.Length * i + j) > _numberOfVariables) {
                        varName = _variableDictionary[(geneChars.Length * i + j)];
                    }
                }
            }
            return varName;
        }
		*/
        
        /// <summary>
        /// Returns string with a method call, if-statement, or a loop.
        /// </summary>
        /// <param name="genes"></param>
        /// <param name="block"></param>
        /// <returns></returns>
        private string GetStatement(Individual genes, IReadOnlyList<string> block) {

            var statement = "";
            var geneChars = Algorithm.AllowedLetters;
            var gene1 = genes.GetGene(_geneIterator++);
            var gene2 = genes.GetGene(_geneIterator++);

            for (var i = 0; i <= geneChars.Length; i++) {
                for (var j = 0; j < geneChars.Length; i++) {
                    if (gene1 != geneChars[i] || gene2 != geneChars[j]) continue;
                    if ((geneChars.Length * i + j) > _numberOfVariables) {
                        statement = block[(geneChars.Length * i + j)];
                    }
                }
            }
            return statement;
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