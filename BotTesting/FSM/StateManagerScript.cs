using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Robocode;

namespace Alvtor_Hartho_15.FSM
{
	public class StateManagerScript 
	{
		private State _activeState, _previousState;

		/// <summary>
		/// State Manager Constructor
		/// </summary>
		/// <param name="startingState"></param>
		public StateManagerScript (State startingState) {
            _activeState = startingState;
            _activeState.EnterState();
		}

        /// <summary>
        /// Sets active state and executes that state
        /// </summary>
		public void FrameCheck () {
            _previousState = _activeState;
            _activeState = _activeState.StateChangeRelevance();
            if (_activeState != _previousState) {
                _previousState.ExitState();
                _activeState.EnterState();
            }
            _activeState.DoStateAction();
        }
	}
}