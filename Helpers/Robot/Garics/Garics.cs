using System;
using System.Collections.Generic;
using Robocode;
using Santom;
using Tomtom;
using Tomtom.Utility;
using ExampleSetup.Robocode;
using Alvtor_Hartho_15.FSM;
//using static System.Math;

namespace Alvtor_Hartho_15
{
    public abstract class Garics : AdvancedRobot {
		public EnemyData Enemy { get; set; }
        public EnemyData OldEnemy;
        public double OldEnemyHeading;
        public StateManagerScript StateManager;

        #region Properties

        //        public Point2D Position => new Point2D(X, Y);
        public Point2D Position {
            get { return new Point2D(X, Y); }
        }

//        public Vector2D PositionVector => new Vector2D(X, Y); //Position.PointToVector()? Might create too much overhead
        public Vector2D PositionVector {
            get { return new Vector2D(X, Y); }
        }

        public const double MaxSpeed = 8;

        public Dictionary<string, EnemyData> EnemyDataDictionary { get; set; }
        public EnemyData TargetedEnemy { get; set; }
        public Direction MoveDirection = Direction.Forward;
        public Battlefield Battlefield { get; set; }

//        public int Radius => 20;
        public int Radius {
            get { return 20; }
        }

        #region BulletAndGunProperties

        private double _firepower;

        public double Firepower
        {
            get { return _firepower; }
            set { _firepower = value.Clamp(0.1, 3); }
        }

//        public double BulletSpeed => 20 - 3 * Firepower;
        public double BulletSpeed {
            get { return 20 - 3 * Firepower; }
        }

        public double MaxFiringDistance { get; set; }

        public double MaxFiringDistanceSquared { get; set; }

        public double MaxGunTurnOffset { get; set; }

        #endregion

        #region DistanceProperties

        public double SlowRadius { get; set; }

        public double StopRadius { get; set; }

        public double ReverseRadius { get; set; }

        #endregion

        #region UtilityProperties

//        public Vector2D Forward => this.ForwardVector(length: 50);
        public Vector2D Forward
        {
            get { return this.ForwardVector(length: 50); }
        }

//        public Vector2D GunForward => this.DirectionVector(-GunHeadingRadians, length: 100);
        public Vector2D GunForward
        {
            get { return this.DirectionVector(-GunHeadingRadians, length: 100); }
        }

//        public double TurningRate => (10 - 0.75 * Math.Abs(Velocity)).DegToRad();
        public double TurningRate {
            get { return (10 - 0.75 * Math.Abs(Velocity)).DegToRad(); }
        }

//        public double TurnRadius => Velocity / Math.Sin(TurningRate);
        public double TurnRadius {
            get { return Velocity / Math.Sin(TurningRate); }
        }

        #endregion

        #endregion

        protected Garics()
        {
            SlowRadius = 150;
            StopRadius = 100;
            ReverseRadius = 50;
        }


    }
}