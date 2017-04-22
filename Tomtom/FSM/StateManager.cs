using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using PG4500_2017_Exam1;
using Robocode;
using Tomtom.Utility;

namespace Tomtom.FSM
{
    public class StateManager
    {
        private State _currentState;
        private HashSet<State> _states;
        private Queue<State> _stateQueue;

        #region Initialization

        public StateManager(Hartho_DuelBot robot)
        {
            InitializeStates(robot);
            _stateQueue = new Queue<State>();
        }

        private void InitializeStates(Hartho_DuelBot robot)
        {
            _states = FindStatesByReflection();
            foreach (var state in _states)
            {
                state.Initialize(robot);
            }
        }

        private static HashSet<State> FindStatesByReflection()
        {
            return ReflectionHelpers.GetStates().ToHashSet();
        }

        #endregion

        public void Run()
        {
            UpdateCurrentState();
            while (true)
            {
                Update();
            }
        }

        public void Update()
        {
            _currentState.Update();
            _currentState.Robot.DrawBattlefieldEffectiveBounds(Color.GreenYellow);
            _currentState.ExecuteTurn();
            UpdateCurrentState();
        }

        private void UpdateCurrentState()
        {
            var nextState = _currentState;
            double highestRelevanceScore = 0;
            foreach (var state in _states)
            {
                var stateRelevance = state.Relevance();
                if (!(stateRelevance > highestRelevanceScore)) continue;
                highestRelevanceScore = stateRelevance;
                nextState = state;
            }

            _currentState = nextState;
            _currentState.EnterState();
        }
    }
}