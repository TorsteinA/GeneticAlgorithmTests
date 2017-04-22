using System;
using System.Drawing;
using PG4500_2017_Exam1;
using Robocode;
using Santom;

namespace Tomtom.FSM {
    public class Engage : State
    {
        public override Hartho_DuelBot Robot { get; set; }

        public override double Relevance()
        {
            if (Robot.TargetedEnemy == null)
            {
                return 0;
            }
            var distanceToEnemy = Robot.TargetedEnemy.Distance;
            return distanceToEnemy < Robot.MaxFiringDistance ? 1.5 : 0;
        }

        public override void EnterState()
        {
            Robot.RadarColor = Color.DarkRed;
        }

        protected override void ExitState()
        {
            throw new System.NotImplementedException();
        }

        public override void Update()
        {
            Circle();
            Fire();
        }

        public void Circle()
        {
            var sign = Robot.Forward.Angle(new Vector2D(Robot.Position, Robot.TargetedEnemy.Position));

            var turnDirection = sign >= 0 ? -HalfPi : HalfPi;
            FaceTarget(turnDirection);

            Accelerate();
        }

    }
}