using PG4500_2017_Exam1;

namespace Tomtom.FSM {
    public class Ram : State
    {
        public override Hartho_DuelBot Robot { get; set; }

        public override void EnterState()
        {
            throw new System.NotImplementedException();
        }

        protected override void ExitState()
        {
            throw new System.NotImplementedException();
        }

        public override void Update()
        {
            this.Ram();
        }
    }
}