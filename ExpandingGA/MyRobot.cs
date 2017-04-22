using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Robocode;
using Santom;
using Alvtor_Hartho_15;
using ExampleSetup.Robocode;

namespace Alvtor_Hartho_15
{    //GARICS: Genetic Algorithm Robot in C Sharp
    class Robot_g0000_i0000 : Alvtor_Hartho_15.Garics
    {
        double v0;
        double v1;
        double v2;
        float v3;
        double v4;
        double v5;
        float v6;
        public override void Run()
        {
            Enemy = new EnemyData();
            _stateManager = new StateManagerScript(new State0(this));
            v0 = ourRobot.X;
            v1 = ourRobot.Enemy.Position.Y;
            v2 = ourRobot.BattleFieldHeight;
            v3 = 1.1;
            v4 = ourRobot.Energy;
            v5 = ourRobot.X;
            v6 = 1.1;

            while (true)
            {
                _stateManager.FrameCheck();
                Execute();
                OldEnemy = Enemy;
            }
        }

        public override void OnScannedRobot(ScannedRobotEvent e)
        {
            var angleToEnemy = HeadingRadians + e.BearingRadians;
            var enemyX = (int)(X + Math.Sin(angleToEnemy) * e.Distance);
            var enemyY = (int)(Y + Math.Cos(angleToEnemy) * e.Distance);
            Enemy.SetEnemyData(e, new Point2D(enemyX, enemyY));
        }
    }
}