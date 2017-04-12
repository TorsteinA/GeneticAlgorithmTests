namespace SeaSharpBot.FSM.States.Bottom
{
    public class EvadeBulletState : State {

        public EvadeBulletState(SeaSharpBot ourRobot) {
            OurRobot = ourRobot;
        }
        
        public override State StateChangeRelevance() 
        {
            return this;
        }

        public override void DoStateAction() 
        {
//            Console.WriteLine("Evading!");
        }

        public override void EnterState()
        {
//            Console.WriteLine("Entering EvadeState");
        }

        public override void ExitState()
        {
//            Console.WriteLine("Leaving EvadeState");
        }
    }
}