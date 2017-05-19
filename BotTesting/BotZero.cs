using System;
using System.Drawing;
using Robocode;
using Santom;
using Alvtor_Hartho_15.FSM;
using ExampleSetup.Robocode;

namespace Alvtor_Hartho_15
{ //GARICS: Genetic Algorithm Robot in C Sharp
    public class BotZero : Garics
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
            #region Necessary properties

            Enemy = new EnemyData();
            V0 = 9.9f;
            V1 = Enemy.Distance;
            V2 = 420;
            V3 = Enemy.Distance;
            V4 = 1;
            V5 = Enemy.Distance;
            V6 = X;
            V7 = 9999999;

            #endregion

            #region My First Robot

            TurnLeft(Heading - 90);
            TurnGunRight(90);

            #endregion

            #region GARICS

            Console.WriteLine("Entered run method");
            BodyColor = Color.Pink;
            StateManager = new StateManagerScript(new State0(this));

            #endregion

            while (true)
            {
                #region My first robot

                // Move our robot 5000 pixels ahead
                Ahead(5000);

                // Turn the robot 90 degrees
                TurnRight(90);

                
                #endregion

                #region GARICS

                StateManager.FrameCheck();
                SetFire(3);
                Execute ();
                OldEnemy = Enemy;

                #endregion
            }
        }

        public override void OnScannedRobot(ScannedRobotEvent e)
        {
            #region My First Robot
            Fire(1);
            #endregion

            #region GARICS

            var angleToEnemy = HeadingRadians + e.BearingRadians;
            var enemyX = (int) (X + Math.Sin(angleToEnemy) * e.Distance);
            var enemyY = (int) (Y + Math.Cos(angleToEnemy) * e.Distance);
            Enemy.SetEnemyData(e, new Point2D(enemyX, enemyY));

            #endregion
        }
    }
}