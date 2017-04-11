using System;
using System.Collections.Generic;
using System.Linq;
using Robocode;
using SeaSharpBot.FSM.States;

namespace SeaSharpBot.FSM
{
	public class StateManagerScript 
	{
		private readonly HashSet<State> _states;
		private State _activeState;

        /// <summary>
        /// State Manager Constructor
        /// </summary>
        /// <param name="ourRobot">Reference the the robot in need of a state machine</param>
		public StateManagerScript (SeaSharpBot ourRobot) {

		    _states = new HashSet<State>
		    {
		        new WanderState(ourRobot),
		        new ChargeState(ourRobot),
		        new AttackState(ourRobot)
		    };


		    _activeState = _states.ElementAt(0);
		}
	
        /// <summary>
        /// Sets active state and executes that state
        /// </summary>
		public void FrameCheck () {
			_activeState = CheckRelevance();
			_activeState.Execute();
		}

        /// <summary>
        /// Cycles through states and checks how relevant they are
        /// </summary>
        /// <returns></returns>
		public State CheckRelevance() 
		{
			var bestState = _states.ElementAt(0);
			var highestRelevance = 0.0f;

			for (var i = 0; i <= _states.Count -1; i++)
			{
				var stateRelevance = _states.ElementAt(i).Relevance();

				if (!(stateRelevance > highestRelevance)) continue;
				bestState = _states.ElementAt(i);
				highestRelevance = stateRelevance;
			}
			Console.WriteLine("State with highest relevance was " + bestState.ToString());
			return bestState;
		}
	}
}
