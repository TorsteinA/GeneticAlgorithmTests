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
public class Robot_g0001_i0004 : Alvtor_Hartho_15.Garics {
public int V0 { get; set; }
public double V1 { get; set; }
public double V2 { get; set; }
public float V3 { get; set; }
public double V4 { get; set; }
public double V5 { get; set; }
public int V6 { get; set; }
public float V7 { get; set; }
		public override void Run() {
			Enemy = new EnemyData();
			StateManager = new StateManagerScript(new State0(this));
V0 = 9;
V1 = Heading;
V2 = GunHeat;
V3 = 2.718281828459f;
V4 = Velocity;
V5 = GunHeading;
V6 = 4;
V7 = 5.5f;

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