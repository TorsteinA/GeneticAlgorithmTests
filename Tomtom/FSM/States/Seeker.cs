using System;
using System.Drawing;
using PG4500_2017_Exam1;

namespace Tomtom.FSM
{
    public class Seeker : State
    {
        public override Hartho_DuelBot Robot { get; set; }

        public override double Relevance()
        {
            return 1;
        }

        public override void EnterState()
        {
            Robot.RadarColor = Color.DarkGreen;
        }

        protected override void ExitState()
        {
            throw new System.NotImplementedException();
        }

        public override void Update()
        {
            Seek();
            Fire();
        }


        public void Seek()
        {
            FaceTarget();
            Approach();
        }

        protected void Approach()
        {
            var distance = Robot.TargetedEnemy.Distance;
            if (distance < Robot.SlowRadius && distance > Robot.StopRadius)
            {
                Robot.MaxVelocity = Hartho_DuelBot.MaxSpeed * (Robot.TargetedEnemy.Distance - Robot.StopRadius / Robot.SlowRadius);
            }
            else if (distance < Robot.StopRadius)
            {
                Robot.MaxVelocity = 0;
            }
            else
            {
                Robot.MaxVelocity = Hartho_DuelBot.MaxSpeed;
            }
            Accelerate();
        }

    }
}