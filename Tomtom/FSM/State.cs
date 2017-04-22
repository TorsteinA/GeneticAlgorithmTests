using System;
using System.Collections.Generic;
using System.Drawing;
using ExampleSetup.Robocode;
using PG4500_2017_Exam1;
using Robocode;
using Robocode.Util;
using Santom;
using Tomtom.Utility;

namespace Tomtom.FSM {
    public abstract class State
    {

        #region Constants

        protected const double Pi = Math.PI;

        protected const double HalfPi = Pi / 2;

        protected const double QuarterPi = Pi / 4;

        #endregion

        protected WallAvoidance WallAvoidance;
        public abstract Hartho_DuelBot Robot { get; set; }

        public virtual double Relevance()
        {
            return 0;
        }

        public abstract void EnterState();
        protected abstract void ExitState();
        public abstract void Update();

        /// <summary>
        /// Initializes the robot's fields.
        /// </summary>
        private void InitializeFields()
        {
//            TODO make singleton? Do I need X instances of this?
            WallAvoidance = new WallAvoidance(Robot);

            //Events
            Robot.SendScannedRobotEvent += UpdateEnemyData;
        }


        public void Initialize(Hartho_DuelBot robot)
        {
            Robot = robot;
            InitializeFields();
            SpinRadar();
        }

        public void ExecuteTurn()
        {
            //Keep gun and radar locked on enemy
            TurnGun();
            TurnRadar();

            //EXECUTION
            Robot.Scan();
        }

        protected bool Fire()
        {
            if (!EvaluateFiringConditions()) return false;
            Robot.SetFire(Robot.Firepower);
            return true;
        }

        private bool EvaluateFiringConditions()
        {
            var expectedDistanceSquared = new Vector2D(Robot.Position, EnemyExpectedPosition(Robot.BulletSpeed)).LengthSq();

            return Robot.GunTurnRemainingRadians.IsCloseToZero(Robot.MaxGunTurnOffset) &&
                   expectedDistanceSquared < Robot.MaxFiringDistanceSquared;
        }

        private void TurnRadar()
        {
            if (Robot.Others == 1 && Robot.EnemyDataDictionary.Count == 1)
            {
                var radarAngle = Robot.HeadingRadians + Robot.TargetedEnemy.BearingRadians - Robot.RadarHeadingRadians;
                TurnRadarRadians(radarAngle);
            }
            else
            {
                SpinRadar();
            }
        }

        private void SpinRadar()
        {
            Robot.SetTurnRadarRightRadians(double.PositiveInfinity);
        }

        private void TurnGun()
        {
            var angleToEnemy = PredictedAngleStraightLine();

            TurnGunRadians(angleToEnemy);
        }

        private double PredictedAngleStraightLine()
        {
            var expectedVector = new Vector2D(Robot.Position, EnemyExpectedPosition(Robot.BulletSpeed));
            var vectorToTarget = new Vector2D(Robot.Position, Robot.TargetedEnemy.Position);
            var angleActualToExpected = expectedVector.Angle(vectorToTarget);
            var angleToEnemy = Robot.HeadingRadians + angleActualToExpected + Robot.TargetedEnemy.BearingRadians -
                               Robot.GunHeadingRadians;

            //DEBUG
            Robot.DrawLineAndTarget(Color.Coral, Robot.Position, new Point2D(EnemyExpectedPosition(Robot.BulletSpeed)));
            return angleToEnemy;
        }

        protected void Accelerate(double velocity = 1000)
        {
            Robot.SetAhead(velocity * (int) Robot.MoveDirection);
        }

        #region Events

/*        // Robot event handler, when the robot sees another robot
        public void OnScannedRobot(ScannedRobotEvent e)
        {
            UpdateEnemyData(e);
        }*/

        #endregion

        /// <summary>
        /// Calculates the expected position the enemy would be at when impacted by a projectile travelling at
        /// the specified velocity. Note: this assumes the enemy keeps the same velocity and goes in a straight line.
        /// </summary>
        /// <param name="velocity">The velocity to use in the calculation</param>
        /// <returns>The vector from this robot to the expected position</returns>
        private Point2D EnemyExpectedPosition(double velocity)
        {
            return Robot.TargetedEnemy.ForwardVector(Robot.TargetedEnemy.Velocity * (Robot.TargetedEnemy.Distance / velocity))
                .VectorToPoint();
        }

        /// <summary>
        /// Update the enemy data by adding it to or retrieving it from the dictionary, then update its position.
        /// </summary>
        /// <param name="e">The ScannedRobotEvent to use</param>
        /// <param name="sender">here the call came from</param>
        private void UpdateEnemyData(object sender, ScannedRobotEvent e)
        {
            var targetPosition = Robot.FindTargetPosition(e);
            Robot.TargetedEnemy = AddDataToDictionary(e);
            Robot.TargetedEnemy.Position = targetPosition;

            //DEBUG
            Robot.DrawRobotIndicator(Color.Cyan, new Point2D(Robot.GunForward));
            Robot.DrawLineAndTarget(Color.GreenYellow, Robot.Position, Robot.TargetedEnemy.Position);
        }

        public void FaceTarget(double angleOffset = 0)
        {
            var angle = WallAvoidance.AvoidWalls();
            TurnRadians(angle.IsCloseToZero()
                ? Robot.TargetedEnemy.BearingRadians + angleOffset
                : angle.Clamp(0, Robot.TurningRate));
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
            if (!Robot.EnemyDataDictionary.ContainsKey(robotName))
            {
                var newData = new EnemyData();
                Robot.EnemyDataDictionary.Add(robotName, newData);
            }
            var robotData = Robot.EnemyDataDictionary[robotName];
            robotData.PopulateData(e);
            return robotData;
        }

        #region TurnElements

        /// <summary>
        /// Turns the robot a specified amount of radians. Normalises the supplied angle to between negative and positive
        /// pi.
        /// </summary>
        /// <param name="angle">The number of radians to turn</param>
        private void TurnRadians(double angle)
        {
            Robot.SetTurnRightRadians(Utils.NormalRelativeAngle(angle));
        }

        /// <summary>
        /// Turns the radar a specified amount of radians. Normalises the supplied angle to between negative and positive
        /// pi.
        /// </summary>
        /// <param name="angle">The number of radians to turn the radar</param>
        private void TurnRadarRadians(double angle)
        {
            Robot.SetTurnRadarRightRadians(Utils.NormalRelativeAngle(angle));
        }

        /// <summary>
        /// Turns the gun a specified amount of radians. Normalises the supplied angle to between negative and positive
        /// pi.
        /// </summary>
        /// <param name="gunAngle">The number of radians to turn the gun</param>
        private void TurnGunRadians(double gunAngle)
        {
            Robot.SetTurnGunRightRadians(Utils.NormalRelativeAngle(gunAngle));
        }

        #endregion

        /// <summary>
        /// Changes the move direction from forwards to backwards or vice versa.
        /// Feels like a very roundabout way to do things rather than just working with ints, and is probably less efficient,
        /// but the idea was that it might render the code easier to understand. Would love to get some feedback on the best
        /// way to accomplish this while maintaining (near) optimal performance.
        /// </summary>
        private void ChangeDirection()
        {
            Robot.MoveDirection = (Direction) ((int) Robot.MoveDirection * -1);
//            _moveDirection = _moveDirection = Direction.Forward ? Direction.Backward : Direction.Forward;
        }
    }
}