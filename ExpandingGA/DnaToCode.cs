using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmForStrings {
	internal class DnaToCode {
		
		private int numberOfVariables,		//How many variables the robot gets to play with.
					geneIterator = 0,		//always call with ++ when used with genes.GetGene().
					minStatements = 2,		//Minimum number of statements in each state 
					minVariables = 5;		//Minimum number of variables for numberOfVariables.
		
		private string variables = "",								//String with variables of robot
					   firstStateMethodContent = "",				//String with contents of first state
					   secondStateMethodContent = "",				//String with contents of second state
					   firstToSecondStateTransitionContent = "",	//String with contents of transition from first to second
					   secondToFirstStateTransitionContent = "";    //String with contents of transition from second to first

		private string[] AllowedMethods = { "ourRobot.Ahead",			// Fill in more later
											"ourRobot.Fire",				// Turn cannon
											"KeepRadarLock",				// Turn cannon
											"CircularTargetingFire",				// Turn cannon
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
											"ourRobot.Enemy.Position.Y"};       		//Acceleration
																						//...
																					//Velocity
																					//Position
																					//...
																					//Other functions that return types, or set variables
																				//Functions in state class
																				
																				
			
	// Create Code Content

	/// <summary>
	/// Constructor of DnaToCode class
	/// </summary>
	/// <param name="genes"></param>
	public DnaToCode(Individual genes) {
			// Sets content for variables
			SetNumberOfVariables(genes.GetGene(geneIterator++));
			SetVariables(genes);
			
					//Set geneIterator to specific number here to let method contents start at the same place each time and not get messed up by mutations in variables (Need to calculate how many we need/max it can use first though)
						//Can also be placed between each method call to separate genes further

			// Sets content for states
			firstStateMethodContent = CreateStateMethodContent(genes);
			secondStateMethodContent = CreateStateMethodContent(genes);

					//Set geneIterator to specific number here as well to let transition contents start at the same place each time and not get messed up by mutations in state content

			// Sets content for transitions
			firstToSecondStateTransitionContent = GetCondition(genes);
			secondToFirstStateTransitionContent = GetCondition(genes);
		}
		
		/// <summary>
		/// Sets content of variables.
		/// </summary>
		/// <param name="genes"></param>
		private void SetVariables(Individual genes) {
			for (int i = geneIterator; i < numberOfVariables; i++) {
				variables += "\nvar v" + i + " = ";
				variables += GetVariableName(genes.GetGene(geneIterator++), genes.GetGene(geneIterator++)).ToString();
				variables += ";";
			}
		}
		
		/// <summary>
		/// Creates a string with the contents of a method
		/// </summary>
		/// <param name="genes"></param>
		/// <returns></returns>
		private string CreateStateMethodContent(Individual genes) {
			string contents = "";
			int statements = GetNumberOfStatements(genes.GetGene(geneIterator++));
			for (int i = 0; i < statements; i++) {
				contents += "\n" + GetStatement(genes);
			}
			return contents;
		}
		


		// Helper methods for code creation

		/// <summary>
		/// Returns name of variable robot has access to based on genes.
		/// </summary>
		/// <param name="gene1"></param>
		/// <param name="gene2"></param>
		/// <returns></returns>
		private string GetVariableName(char gene1, char gene2) {

			string varName = "";

			string geneChars = Algorithm.AllowedLetters;
			
			for (int i = 0; i <= geneChars.Length; i++) {
				for (int j = 0; j < geneChars.Length; i++) {
					if (gene1 == geneChars[i] && gene2 == geneChars[j]) {

						if ((geneChars.Length * i + j) > numberOfVariables) {
							varName = AllowedVariables[(geneChars.Length * i + j)];
						}
						else {
							varName = "";
						}
					}
				}
			}
			return varName;
		}

		/// <summary>
		/// Returns name of variable robot has stored based on genes.
		/// </summary>
		/// <param name="gene1"></param>
		/// <param name="gene2"></param>
		/// <returns></returns>
		private string GetVariable(char gene1, char gene2) {
			string geneChars = Algorithm.AllowedLetters, 
				   variableName = "v";
			
			for (int i = 0; i <= geneChars.Length; i++) {
				for (int j = 0; j < geneChars.Length; i++) {
					if (gene1 == geneChars[i] && gene2 == geneChars[j]) {

						if ((geneChars.Length * i + j) > numberOfVariables) {
							variableName += (geneChars.Length * i + j);
						}
						else {
							variableName = "";
						}
					}
				}
			}
			return variableName;
		}


		/// <summary>
		/// Returns the contents of a method call the robot has access to
		/// </summary>
		/// <param name="genes"></param>
		/// <returns></returns>
		private string GetRobotMethod(Individual genes) {

			//Returns string with a call based on something I've yet to decide
			char gene1 = genes.GetGene(geneIterator++);
			char gene2 = genes.GetGene(geneIterator++);

			string methodName = "";
			int num = -1;

			//Uses genes to find index
			for (int i = 0; i < Algorithm.AllowedLetters.Length; i++) {
				for (int j = 0; j < Algorithm.AllowedLetters.Length; j++) {
					if (gene1 == Algorithm.AllowedLetters[i] && gene2 == Algorithm.AllowedLetters[j]) {
						num = (Algorithm.AllowedLetters.Length * i + j) % AllowedMethods.Length;
					}
				}
			}

			//Uses index to choose method call
			methodName += AllowedMethods[num];

			//Adds parameters
			methodName += "(";
			methodName += GetVariable(genes.GetGene(geneIterator++), genes.GetGene(geneIterator++));
			methodName += ");";

			return methodName;
		}


		/// <summary>
		/// Returns condition that can be used with statements
		/// </summary>
		/// <param name="genes"></param>
		/// <returns></returns>
		private string GetCondition(Individual genes) {

			//TODO Introduce chance of && or ||, allowing for more specific conditions
			return GetVariable(genes.GetGene(geneIterator++), genes.GetGene(geneIterator++)) + GetComparator(genes.GetGene(geneIterator++)) + GetVariable(genes.GetGene(geneIterator++), genes.GetGene(geneIterator++));
		}

		/// <summary>
		/// Returns string with a method call, if-statement, or a loop.
		/// </summary>
		/// <param name="genes"></param>
		/// <returns></returns>
		private string GetStatement(Individual genes) {

			string statement = "\n";

			//Statements:
			// "for (int i = 0; i " + GetComparator() + GetVariable() + "; i++) {\n" + GetStatement() + "\n}"

			// "if (" + GetVariable() + GetComparator() + GetVariable() + ") {\n" + GetStatement() + "\n}"

			// "else if (" + GetVariable() + GetComparator() + GetVariable() + ") {\n" + GetStatement() + "\n}"		//Can only be added if previous was an if

			// "else {\n" + GetStatement() + "\n}"																	//Can only be added if previous was an if or else if

			// "while (" + GetVariable() + GetComparator() + GetVariable() +  ") {\n" + GetStatement() + "\n}"

			// "do {\n" + GetStatement() + "} while(" + GetVariable() + GetComparator() + GetVariable() +  ");"		

			// GetRobotMethod();																					//Should probably have a higher chance than the others

			return statement;
		}


		/// <summary>
		/// Returns a comparator as a string, based on gene
		/// </summary>
		/// <param name="gene"></param>
		/// <returns></returns>
		private string GetComparator(char gene) {

			// Returning only '<' instead of '< and >'. reduces choice to single gene. (A > B can be written like B < A, so most logic should still be doable, although slightly harder)

			// Alternative is to use two genes for each comparator
			
			if (gene == 'a')
				return "<";
			if (gene == 'c')
				return "<=";
			if (gene == 'g')
				return "==";
			if (gene == 't')
				return "!=";

			return "==";
		}

		/// <summary>
		/// Returns an operator as a string, based on gene
		/// </summary>
		/// <param name="gene"></param>
		/// <returns></returns>
		private string GetOperator(char gene) {
			//Return +, -, /, or * based on genes s

			//TODO Make compatible with cos/sin/tan/atan/asin/acos/atan2 (might need to use two genes for this)

			if (gene == 'a')
				return "+";
			if (gene == 'c')
				return "-";
			if (gene == 'g')
				return "/";
			if (gene == 't')
				return "*";
			
			return "+";
		}


		/// <summary>
		/// Sets how many variables the robot gets to play with
		/// </summary>
		/// <param name="gene"></param>
		private void SetNumberOfVariables(char gene) {

			for (int i = 0; i < Algorithm.AllowedLetters.Length; i++) {
				if (gene == Algorithm.AllowedLetters[i]){
					numberOfVariables = i + minVariables;
				}
			}

		}

		/// <summary>
		/// Returns a number based on minStatements and genes.
		/// </summary>
		/// <param name="gene"></param>
		/// <returns></returns>
		private int GetNumberOfStatements(char gene) {
			for (int i = 0; i < Algorithm.AllowedLetters.Length; i++) {
				if (gene == Algorithm.AllowedLetters[i]) {
					return i + minStatements;
				}
			}
			return 0;
		}



		// Returns Code Content

		/// <summary>
		/// Returns string with variables
		/// </summary>
		/// <returns></returns>
		public string GetVariables() {
			return variables;
		}

		/// <summary>
		/// Returns contents of method to go in first state
		/// </summary>
		/// <returns></returns>
		public string GetFirstStateMethodContent() {
			return firstStateMethodContent;
		}

		/// <summary>
		/// Returns contents of method to go in second state
		/// </summary>
		/// <returns></returns>
		public string GetSecondStateMethodContent() {
			return secondStateMethodContent;
		}

		/// <summary>
		/// Returns contents of transition from first to second state
		/// </summary>
		/// <returns></returns>
		public string GetFirstToSecondStateTransitionContent() {
			return firstToSecondStateTransitionContent;
		}

		/// <summary>
		/// Returns contents of transition from second to first state
		/// </summary>
		/// <returns></returns>
		public string GetSecondToFirstStateTransitionContent() {
			return secondToFirstStateTransitionContent;
		}

	}
}