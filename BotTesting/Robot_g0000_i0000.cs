using System;
using System.Drawing;
using Robocode;
using Santom;
using Alvtor_Hartho_15.FSM;
using ExampleSetup.Robocode;

namespace Alvtor_Hartho_15
{ //GARICS: Genetic Algorithm Robot in C Sharp
    public class Robot_g0000_i0000 : Garics
    {
        public float V0 { get; set; }
        public double V1 { get; set; }
        public int V2 { get; set; }
        public double V3 { get; set; }
        public int V4 { get; set; }
        public double V5 { get; set; }
        public double V6 { get; set; }
        public int V7 { get; set; }

        public override void Run()
        {
            Console.WriteLine("Entered run method");
            BodyColor = Color.Pink;
            Enemy = new EnemyData();
            StateManager = new StateManagerScript(new State0(this));
            V0 = 9.9f;
            V1 = Enemy.Distance;
            V2 = 420;
            V3 = Enemy.Distance;
            V4 = 1;
            V5 = Enemy.Distance;
            V6 = X;
            V7 = 9999999;

            while (true)
            {
                StateManager.FrameCheck();
                SetFire(3);
                Execute();
                OldEnemy = Enemy;
            }
        }

        public override void OnScannedRobot(ScannedRobotEvent e)
        {
            var angleToEnemy = HeadingRadians + e.BearingRadians;
            var enemyX = (int) (X + Math.Sin(angleToEnemy) * e.Distance);
            var enemyY = (int) (Y + Math.Cos(angleToEnemy) * e.Distance);
            Enemy.SetEnemyData(e, new Point2D(enemyX, enemyY));
        }
    }
}