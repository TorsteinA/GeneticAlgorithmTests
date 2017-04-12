using System.Drawing;
using SeaSharpBot.FSM.States.Top;

namespace SeaSharpBot.FSM.States.Bottom
{
    public class FleeState : State {

        public FleeState(SeaSharpBot ourRobot) {
            OurRobot = ourRobot;
        }
        
        public override State StateChangeRelevance() 
        {
            if (OurRobot.Enemy.Distance > 400)
                return new SeekState(OurRobot);
            
            return this;
        }

        public override void DoStateAction() {
//            Console.WriteLine("Fleeing");
//            OurRobot.TurnLeftRadians(3);
//            OurRobot.SetAhead(-100);

            //Pretty much the opposite of Charge state
        }

        public override void EnterState()
        {
//            Console.WriteLine("Entering FleeState");
            OurRobot.BodyColor = Color.DimGray;
        }

        public override void ExitState()
        {
//            Console.WriteLine("Leaving FleeState");
        }
    }
}