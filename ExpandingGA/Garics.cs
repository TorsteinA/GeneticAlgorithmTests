using System.Collections.Generic;
using Robocode;
using Santom;
using Tomtom;
using Tomtom.Utility;
using SeaSharpBot.FSM;
using static System.Math;
using ExampleSetup.Robocode;

namespace Alvtor_Hartho_15
{
    public abstract class Garics : AdvancedRobot {
		internal EnemyData Enemy { get; set; }
		internal EnemyData OldEnemy;
		internal double OldEnemyHeading;
		internal StateManagerScript StateManager;

        #region Properties

        public Point2D Position => new Point2D(X, Y);

        public Vector2D PositionVector => new Vector2D(X, Y); //Position.PointToVector()? Might create too much overhead

        public const double MaxSpeed = 8;

        public Dictionary<string, EnemyData> EnemyDataDictionary { get; set; }
        public EnemyData TargetedEnemy { get; set; }
        public Direction MoveDirection = Direction.Forward;
        public Battlefield Battlefield { get; set; }

        public int Radius => 20;

        #region BulletAndGunProperties

        private double _firepower;

        public double Firepower
        {
            get { return _firepower; }
            set { _firepower = value.Clamp(0.1, 3); }
        }

        public double BulletSpeed => 20 - 3 * Firepower;

        public double MaxFiringDistance { get; set; }

        public double MaxFiringDistanceSquared { get; set; }

        public double MaxGunTurnOffset { get; set; }

        #endregion

        #region DistanceProperties

        public double SlowRadius { get; set; } = 150;

        public double StopRadius { get; set; } = 100;

        public double ReverseRadius { get; set; } = 50;

        #endregion

        #region UtilityProperties

        public Vector2D Forward => this.ForwardVector(length: 50);

        public Vector2D GunForward => this.DirectionVector(-GunHeadingRadians, length: 100);

        public double TurningRate => (10 - 0.75 * Abs(Velocity)).DegToRad();

        public double TurnRadius => Velocity / Sin(TurningRate);

        #endregion

        #endregion
    }
}