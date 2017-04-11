namespace SeaSharpBot.FSM.States
{
    public class FleeState : State {

        public FleeState(ref SeaSharpBot ourRobot) {
            OurRobot = ourRobot;
        }

        public override float Relevance() 
        {
            var returnValue = 0.0f;
            if (!OurRobot.HasLockOnEnemy) returnValue++;
            if (!OurRobot.IsInPosition) returnValue++;
            if (OurRobot.UnderSiege) returnValue++;
            if (OurRobot.EnemyBulletInTheAir) returnValue++;

            return returnValue;
        }

        public override void Execute() {
            OurRobot.Flee();
        }
    }
}