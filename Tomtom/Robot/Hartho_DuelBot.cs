using System;
using System.Collections.Generic;
using System.Drawing;
using ExampleSetup.Robocode;
using Robocode;
using Santom;
using Tomtom;
using Tomtom.FSM;
using Tomtom.Utility;

namespace PG4500_2017_Exam1
{
    public class Hartho_DuelBot : AdvancedRobot
    {
        private const double HalfPi = Math.PI / 2;


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
            set { _firepower = value.Clamp(0.1, 3);}
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

        public double TurningRate => (10 - 0.75 * Math.Abs(Velocity)).DegToRad();

        public double TurnRadius => Velocity / Math.Sin(TurningRate);

        #endregion

        #endregion

        public event EventHandler<ScannedRobotEvent> SendScannedRobotEvent;

        #region Methods

        public override void Run()
        {
            Initialize();
            new StateManager(this).Run();
        }

        public override void OnScannedRobot(ScannedRobotEvent evnt)
        {
            SendScannedRobotEvent(this, evnt);
        }

        public void Initialize()
        {
            IsAdjustRadarForGunTurn = true;
            IsAdjustGunForRobotTurn = true;

            MaxFiringDistance = 150;
            MaxFiringDistanceSquared = Math.Pow(MaxFiringDistance, 2);
            MaxGunTurnOffset = 0.5;
            Firepower = 1.5;

            TargetedEnemy = new EnemyData();
            EnemyDataDictionary = new Dictionary<string, EnemyData>();

            Battlefield = new Battlefield(BattleFieldWidth, BattleFieldHeight, Radius);

            //Colors
            BodyColor = Color.SlateGray;
            GunColor = Color.Transparent;
            RadarColor = Color.Black;
        }

        #endregion
    }
}