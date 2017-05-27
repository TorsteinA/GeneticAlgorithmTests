using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Permissions;
using System.Text;
using Robocode;
using Santom;
using Tomtom;
using Tomtom.Utility;
using ExampleSetup.Robocode;
using Alvtor_Hartho_15.FSM;

//using static System.Math;

namespace Alvtor_Hartho_15
{
    public abstract class Garics : AdvancedRobot
    {
        #region Properties

        public EnemyData OldEnemy;
        public double OldEnemyHeading;
        public StateManagerScript StateManager;

        //        public Point2D Position => new Point2D(X, Y);
        public Point2D Position
        {
            get { return new Point2D(X, Y); }
        }

//        public Vector2D PositionVector => new Vector2D(X, Y); //Position.PointToVector()? Might create too much overhead
        public Vector2D PositionVector
        {
            get { return new Vector2D(X, Y); }
        }

        public const double MaxSpeed = 8;

        public Dictionary<string, EnemyData> EnemyDataDictionary { get; set; }
        public EnemyData TargetedEnemy { get; set; }
        public Direction MoveDirection = Direction.Forward;
        public Battlefield Battlefield { get; set; }

//        public int Radius => 20;
        public int Radius
        {
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
        public double BulletSpeed
        {
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
        public double TurningRate
        {
            get { return (10 - 0.75 * Math.Abs(Velocity)).DegToRad(); }
        }

//        public double TurnRadius => Velocity / Math.Sin(TurningRate);
        public double TurnRadius
        {
            get { return Velocity / Math.Sin(TurningRate); }
        }

        #endregion

        #endregion

        protected Garics()
        {
            InitializeValues();
        }

        private void InitializeValues()
        {
            SlowRadius = 150;
            StopRadius = 100;
            ReverseRadius = 50;
        }

        /// <summary>
        /// Write match and performance data to file on battle ended
        /// </summary>
        /// <param name="evnt">The BattleEndedEvent to get data from</param>
        public override void OnBattleEnded(BattleEndedEvent evnt)
        {
            Console.WriteLine("-- Battle has completed --");
            var fileName = GetType().Name + ".results";

            var totalScore = evnt.Results.Score; // NOTE: this will be modified further
            var battleCount = 1; // this battle has completed

            try // grab data from file
            {
                using (var file = GetDataFile(fileName))
                {
                    if (file.Length != 0)
                    {
                        using (var reader = new StreamReader(file))
                        {
                            totalScore += int.Parse(reader.ReadLine());
                            battleCount += int.Parse(reader.ReadLine());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File reading failed. It might not have any data yet. Exception message: " + e);
            }

            var avgScore = (double)totalScore / battleCount; // get a double value

            try
            {
                using (var file = GetDataFile(fileName))
                {
                    file.SetLength(0);
                    using (var writer = new StreamWriter(file))
                    {
                        writer.WriteLine(totalScore); // total score from all battles
                        writer.WriteLine(battleCount); // number of battles
                        writer.WriteLine(avgScore); // avg battle score
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("could not write data to file: " + e);
            }

            Console.WriteLine("My average battle score is " + avgScore);
        }

        public Point2D FindTargetPosition(ScannedRobotEvent e)
        {
            var angle = HeadingRadians + e.BearingRadians;
            return new Point2D(PositionVector - Vector2DHelpers.VectorFromAngle(-angle - Math.PI/2, e.Distance));
        }

        /// <summary>
        /// Update the enemy data by adding it to or retrieving it from the dictionary, then update its position.
        /// </summary>
        /// <param name="e">The ScannedRobotEvent to use</param>
        protected void UpdateEnemyData(ScannedRobotEvent e)
        {
            var targetPosition = FindTargetPosition(e);
            TargetedEnemy = AddDataToDictionary(e);
            TargetedEnemy.Position = targetPosition;
        }

        /// <summary>
        /// Checks if data dictionary contains the scanned robot, adds it if it doesn't, then updates the
        /// data of the robot.
        /// </summary>
        /// <param name="e">The ScannedRobotEvent from which we get the data</param>
        /// <returns>The updated enemy data</returns>
        private EnemyData AddDataToDictionary(ScannedRobotEvent e)
        {
            var robotName = e.Name;
            if (!EnemyDataDictionary.ContainsKey(robotName))
            {
                var newData = new EnemyData();
                EnemyDataDictionary.Add(robotName, newData);
            }
            var robotData = EnemyDataDictionary[robotName];
            robotData.PopulateData(e);
            return robotData;
        }
    }
}