using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmForStrings {
	internal class DnaToCode {
        
        #region Fields

	    private int _numberOfVariables,                     //How many variables the robot gets to play with.
	                _geneIterator = 0;		                //always call with ++ when used with genes.GetGene().

		private const int MinStatements = 2,		        //Minimum number of statements in each states DoStateAction 
                          MinEnterLeaveStatements = 0,      //Minimum nymber of statements in each states EnterState and LeaveState
					      MinVariables = 5;		            //Minimum number of variables for numberOfVariables.

	    private string _variables;		        					            //String with variables of robot
		private readonly string _firstStateEnterMethodContent,					//String with contents of first states enter method
					            _secondStateEnterMethodContent,					//String with contents of second states enter method
 					            _firstStateLeaveMethodContent,					//String with contents of first states leave method
					            _secondStateLeaveMethodContent,					//String with contents of second states leave method
 					            _firstStateDoStateActionMethodContent,			//String with contents of first states action method
					            _secondStateDoStateActionMethodContent,			//String with contents of second states action method
					            _firstToSecondStateTransitionContent,	        //String with contents of transition from first to second
					            _secondToFirstStateTransitionContent;           //String with contents of transition from second to first

		private readonly string[] 
            /**
            AllowedMethods = { "ourRobot.Ahead",			// Fill in more later
											"ourRobot.Fire",				// Turn cannon
											"KeepRadarLock",				// Turn cannon
											"CircularTargetingFire",		// Turn cannon
											"ourRobot.Turn"},   			// CircularTargetingFire
																			// Turn radar 36
																			// Turn radar (variable)
																			// KeepWidthLock
																			// Turn Body
																			// Ahead

						AllowedVariables = {"ourRobot.Energy",				//Variables:
											"ourRobot.HeadingRadians",			//ourRobot.
											"ourRobot.Velocity",					//HeadingRadians	
											"ourRobot.X",							//Energy	
											"ourRobot.Y",							//EnemyData.	
											"ourRobot.Enemy.HeadingRadians",			//HeadingRadians	
											"ourRobot.Enemy.BearingRadians",			//BearingRadians	
											"ourRobot.Enemy.Energy",					//Energy	
											"ourRobot.Enemy.Position.X",				//Position    	
											"ourRobot.Enemy.Position.Y"},               //Acceleration
                                                                                        //...
                                                                                        //Velocity
                                                                                        //Position
                                                                                        //...
                                                                                        //Other functions that return types, or set variables
                                                                                        //Functions in state class

            */
            

                        _blockA = { "",								// Block for state transitions
                                    "",								// Has content for if statements
                                    "",								// Format example: v1 == v2
                                    "" },							// Both states will use this block
            														
                        _blockB = { "",								// Block for EnterState content
                                    "",								// Has method calls and perhaps statements/loops
                                    "",								// Format example: 
                                    "" },							// Both states will use this block
																	
                        _blockC = { "",								// Block for LeaveState content
                                    "",								// Has method calls for when robot leaves a state (Maybe merge with BlockB)
                                    "" },							// Both states will use this block
																	
                        _blockD = { "KeepRadarLock(OurRobot.HeadingRadians + OurRobot.Enemy.BearingRadians);",	// Block for DoStateAction content
                                    "",								                                            // Has method calls and statements/loops
                                    "" },							                                            // Both states will use this block

                        _blockE = { "ourRobot.Energy",				                                            // Block for state variables
                                    "ourRobot.HeadingRadians",		                                            // Has variables method can choose from
                                    "ourRobot.Velocity",			                                            // Both states will use this block
                                    "ourRobot.X",
                                    "ourRobot.Y",
                                    "ourRobot.Enemy.HeadingRadians",
                                    "ourRobot.Enemy.BearingRadians",
                                    "ourRobot.Enemy.Energy",
                                    "ourRobot.Enemy.Position.X",
                                    "ourRobot.Enemy.Position.Y"};

#endregion Fields

        #region CreateCodeContent
            
        /// <summary>
            /// Constructor of DnaToCode class
            /// </summary>
            /// <param name="genes"></param>
        public DnaToCode(Individual genes) {
			    // Sets content for variables
			    SetNumberOfVariables(genes.GetGene(_geneIterator++));
			    SetVariables(genes);

					//Set geneIterator to specific number here to let method contents start at the same place each time and not get messed up by mutations in variables (Need to calculate how many we need/max it can use first though)
					//Can also be placed between each method call below to separate genes further

				// Sets content for transitions
				_firstToSecondStateTransitionContent = GetCondition(genes);
				_secondToFirstStateTransitionContent = GetCondition(genes);

					//Set geneIterator to specific number here as well to let transition contents start at the same place each time and not get messed up by mutations in state content

				// Sets content for state Enter
				_firstStateEnterMethodContent = CreateStateMethodContent(genes, MinEnterLeaveStatements, _blockB);
			    _secondStateEnterMethodContent = CreateStateMethodContent(genes, MinEnterLeaveStatements, _blockB);

					//Set geneIterator to specific number here as well to let transition contents start at the same place each time and not get messed up by mutations in state content	

				// Sets content for state Leave
				_firstStateLeaveMethodContent = CreateStateMethodContent(genes,MinEnterLeaveStatements, _blockC);
			    _secondStateLeaveMethodContent = CreateStateMethodContent(genes,MinEnterLeaveStatements, _blockC);

					    //Set geneIterator to specific number here as well to let transition contents start at the same place each time and not get messed up by mutations in state content

			    // Sets content for state doAction
			     _firstStateDoStateActionMethodContent = CreateStateMethodContent(genes, MinStatements, _blockD);
			    _secondStateDoStateActionMethodContent = CreateStateMethodContent(genes, MinStatements, _blockD);
			}
		
		/// <summary>
		/// Sets content of variables.
		/// </summary>
		/// <param name="genes"></param>
		private void SetVariables(Individual genes)
		{
		    var variables = "";
			for (int i = _geneIterator; i < _numberOfVariables; i++) {
				variables += "\nvar v" + i + " = ";
				variables += GetVariableName(genes.GetGene(_geneIterator++), genes.GetGene(_geneIterator++)).ToString();
				variables += ";";
			}
		    _variables = variables;
		}

		/// <summary>
		/// Creates a string with the contents of a method
		/// </summary>
		/// <param name="genes"></param>
		/// <param name="minStatements"></param>
		/// <param name="block"></param>
		/// <returns></returns>
		private string CreateStateMethodContent(Individual genes, int minStatements, string[] block) {
			var contents = "";
			var statements = GetNumberOfStatements(genes.GetGene(_geneIterator++), minStatements);
			for (var i = 0; i < statements; i++) {
				contents += "\n" + GetStatement(genes, block);
			}
			return contents;
		}
        
        /// <summary>
        /// Returns condition that can be used with statements
        /// </summary>
        /// <param name="genes"></param>
        /// <returns></returns>
        private string GetCondition(Individual genes) {

            //TODO Introduce chance of && or ||, allowing for more specific conditions

            var transitionContent = "";
            var geneChars = Algorithm.AllowedLetters;
            var gene1 = genes.GetGene(_geneIterator++);
            var gene2 = genes.GetGene(_geneIterator++);

            for (var i = 0; i <= geneChars.Length; i++) {
                for (var j = 0; j < geneChars.Length; i++) {
                    if (gene1 != geneChars[i] || gene2 != geneChars[j]) continue;
                    if ((geneChars.Length * i + j) > _numberOfVariables) {
                        transitionContent = _blockA[(geneChars.Length * i + j)];
                    }
                }
            }
            return transitionContent;
        }
        
#endregion CreateCodeContent

        #region HelperMethods
        
        /// <summary>
        /// Sets how many variables the robot gets to play with
        /// </summary>
        /// <param name="gene"></param>
        private void SetNumberOfVariables(char gene) {

            for (int i = 0; i < Algorithm.AllowedLetters.Length; i++) {
                if (gene == Algorithm.AllowedLetters[i]) {
                    _numberOfVariables = i + MinVariables;
                }
            }

        }
        
        /// <summary>
        /// Returns a number based on minStatements and genes.
        /// </summary>
        /// <param name="gene"></param>
        /// <param name="minStatements"></param>
        /// <returns></returns>
        private static int GetNumberOfStatements(char gene, int minStatements) {
            for (var i = 0; i < Algorithm.AllowedLetters.Length; i++) {
                if (gene == Algorithm.AllowedLetters[i]) {
                    return i + minStatements;
                }
            }
            return 0;
        }

        /// <summary>
        /// Returns name of variable robot has access to based on genes.
        /// </summary>
        /// <param name="gene1"></param>
        /// <param name="gene2"></param>
        /// <returns></returns>
        private string GetVariableName(char gene1, char gene2) {
            var varName = "";
            var geneChars = Algorithm.AllowedLetters;

            for (var i = 0; i <= geneChars.Length; i++) {
                for (var j = 0; j < geneChars.Length; i++)
                {
                    if (gene1 != geneChars[i] || gene2 != geneChars[j]) continue;
                    if ((geneChars.Length * i + j) > _numberOfVariables) {
                        varName = _blockE[(geneChars.Length * i + j)];
                    }
                }
            }
            return varName;
        }
        
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
        /// Returns string with variables
        /// </summary>
        /// <returns></returns>
        public string GetVariables() {
			return _variables;
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