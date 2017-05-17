using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Robocode;
using Santom;
using Alvtor_Hartho_15;
using Alvtor_Hartho_15.FSM;
using ExampleSetup.Robocode;

namespace Alvtor_Hartho_15 {    //GARICS: Genetic Algorithm Robot in C Sharp
public class Robot_g0001_i0008 : Alvtor_Hartho_15.Garics {
public double V0 { get; set; }
public float V1 { get; set; }
public float V2 { get; set; }
public double V3 { get; set; }
public int V4 { get; set; }
public float V5 { get; set; }
public float V6 { get; set; }
		public override void Run() {
			Enemy = new EnemyData();
			StateManager = new StateManagerScript(new State0(this));
V0 = Heading;
V1 = 2.718281828459f;
V2 = 1.618f;
V3 = Heading;
V4 = 1;
V5 = 0.001f;
V6 = 1.618f;

			while (true) {
				StateManager.FrameCheck();
				Execute();
				OldEnemy = Enemy;
			}
		}

		public override void OnScannedRobot(ScannedRobotEvent e) {
			var angleToEnemy = HeadingRadians + e.BearingRadians;
			var enemyX = (int)(X + Math.Sin(angleToEnemy) * e.Distance);
			var enemyY = (int)(Y + Math.Cos(angleToEnemy) * e.Distance);
			Enemy.SetEnemyData(e, new Point2D(enemyX, enemyY));
		}
	}
}