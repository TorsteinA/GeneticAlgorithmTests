using PG4500_2017_Exam1;
using Robocode;

namespace Tomtom.FSM {
    public class Idle : State
    {
        public override Hartho_DuelBot Robot { get; set; }

        public override void Update()
        {
            throw new System.NotImplementedException();
        }

        public override void EnterState()
        {
            throw new System.NotImplementedException();
        }

        protected override void ExitState()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "Idle state.";
        }
    }
}