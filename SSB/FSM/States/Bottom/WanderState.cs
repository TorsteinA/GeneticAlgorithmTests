using System.Drawing;

namespace SeaSharpBot.FSM.States.Bottom {
    internal class WanderState : State {

        public WanderState(SeaSharpBot seaSharpBot) {
            this.OurRobot = seaSharpBot;
        }

        public override State StateChangeRelevance()
        {

            if (OurRobot.Enemy.Position.X > 0.01 && OurRobot.Enemy.Position.Y > 0.01)
                return new ChargeState(OurRobot);
            else 
                return this;
        }

        public override void EnterState()
        {
//            Console.WriteLine("Entered WanderState");
            OurRobot.BodyColor = Color.Aqua;
        }

        public override void ExitState()
        {
//            Console.WriteLine("Left WanderState");
        }

        public override void DoStateAction()
        {
//            Console.WriteLine("Wandering");
            
            //Intentionally left blank for now. 
            //Downprioritized due to time constraints
        }
    }
}