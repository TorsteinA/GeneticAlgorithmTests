namespace PG4500_2017_Exam1.FSM.States
{
    public class ChargeState : State
    {
    
        public ChargeState(alvtor_SeaSharpBot ourRobot)
        {
            OurRobot = ourRobot;
        }

        public override float Relevance() 
        {
            var returnValue = 0.0f;
            if (OurRobot.HasLockOnEnemy) returnValue++;
            if (!OurRobot.IsInPosition) returnValue++;
            if (!OurRobot.UnderSiege) returnValue++;
            if (!OurRobot.EnemyBulletInTheAir) returnValue++;

            return returnValue;
        }

        public override void Execute()
        {
            OurRobot.Charge();
        }
    }
}
