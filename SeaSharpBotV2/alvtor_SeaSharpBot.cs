using System;
using PG4500_2017_Exam1.FSM;
using Robocode;
using Robocode.Util;
using SeaSharpBot.Helpers;

namespace PG4500_2017_Exam1
{
	public class alvtor_SeaSharpBot : AdvancedRobot
	{

		#region Fields

		// Properties
		public EnemyData Enemy { get; set; }
		private readonly StateManagerScript _stateManager;

		//State relevancy booleans
		public bool HasLockOnEnemy { get; set; }
		public bool IsInPosition { get; set; }
		public bool UnderSiege { get; set; }
		public bool EnemyBulletInTheAir { get; set; }

		//Helper variables for relevancy checks
		private readonly float _attackZoneDistance = 2f;
		private readonly float _attackZoneLeeway = 0.5f;
		private readonly bool _hasFiredBullet = false;
		private bool _hasLockOnEnemy;

		#endregion Fields

		#region SystemFunctions

		/// <summary>
		///     Constructor for The Awesome Deadly Dupp
		/// </summary>
		public alvtor_SeaSharpBot()
		{
			_stateManager = new StateManagerScript(this);
		}

		/// <summary>
		///     This method is called as soon as the match is loaded
		/// </summary>
		public override void Run()
		{
			Enemy = new EnemyData();


			TurnRadarRightRadians(double.PositiveInfinity);

			while (true)
			{
				_stateManager.FrameCheck();

				HasLockOnEnemy = EnemyLockCheck();
				IsInPosition = InPositionCheck();
				UnderSiege = UnderSiegeCheck();
				EnemyBulletInTheAir = EnemyBulletInTheAirCheck();
			}
		}

		/// <summary>
		///     What happends when our radar find another robot.
		/// </summary>
		/// <param name="e">Scanned Robot</param>
		public override void OnScannedRobot(ScannedRobotEvent e)
		{
			_stateManager.FrameCheck();

			// We need to figure out the enemy cords.
			var angleToEnemy = RadarHeadingRadians + e.BearingRadians;
			var enemyX = (int) (X + Math.Sin(angleToEnemy)*e.Distance);
			var enemyY = (int) (Y + Math.Cos(angleToEnemy)*e.Distance);
			Enemy.SetEnemyData(e, new Point2D(enemyX, enemyY));


			var radarturn = HeadingRadians + e.BearingRadians - RadarHeadingRadians;

			SetTurnRadarRightRadians(Utils.NormalRelativeAngleDegrees(radarturn));

			_hasLockOnEnemy = true;
            //TODO implement set-to-false for when lock slips (Our lock should not slip though, 
            //so it's not top priority)
		}


        public void ScanforEnemies() {
            TurnRadarRightRadians(double.PositiveInfinity);
        }
        
        #endregion SystemFunctions

        #region StateRelevancyChecks

        /// <summary>
        ///     Checks if our robot has lock on enemy
        /// </summary>
        /// <returns>True if locked on</returns>
        private bool EnemyLockCheck()
		{
			//Figure out if _hasLockOnEnemy should be flipped before it returns

			return _hasLockOnEnemy;
		}

		/// <summary>
		///     Checks if our robot is in position to attack (Correct distance from enemy +- variance)
		/// </summary>
		/// <returns>True if in the zone</returns>
		private bool InPositionCheck()
		{
			var ourPos = new Point2D(X, Y);
			return ourPos.Distance(Enemy.Position).IsCloseTo(_attackZoneDistance, _attackZoneLeeway);
		}

		/// <summary>
		///     Checks if hit by enemy bullet
		/// </summary>
		/// <returns>True if hit and has no lock</returns>
		private bool UnderSiegeCheck()
		{
//	        if (_previousFrameHealth <= Energy) return false;

			if (_hasFiredBullet) return false; //TODO Set to true when we fire bullet, and let it be true for a little bit

			//Save health of previous frame
			//If health did not go down since then, return false
			//If we did fire bullet within last X seconds/ticks, return false


//	        _previousFrameHealth = Energy;
			return false;
		}

		/// <summary>
		///     Checks if enemy has fired a bullet
		/// </summary>
		/// <returns>True if locked enemy's energy bar suddenly drops and we didn't just fire a bullet ourselves</returns>
		private bool EnemyBulletInTheAirCheck()
		{
			return false;
		}

		#endregion StateRelevancyChecks

		#region States

		/// <summary>
		///     Moves unpredictably towards center of stage while scanning for Robots
		/// </summary>
		public void Wander()
		{
			Out.Write("I've entered the Wander state");
		    
            //GOTO Center
            ScanforEnemies();

			Execute();
		}

		/// <summary>
		///     Charges towards attackZone
		/// </summary>
		public void Charge()
		{
			Out.Write("I've entered the Charge state");
			SetAhead(20);
			Execute();
		}

		/// <summary>
		///     Moves around in attackZone and fires bullets at enemy
		/// </summary>
		public void Attack()
		{
			Out.Write("I've entered the Attack state");
		}

		/// <summary>
		///     Moves back (away from enemy) and to the side to avoid bullet
		/// </summary>
		public void EvadeBullet()
		{
			Out.Write("I've entered the EvadeBullet state");
		}

		/// <summary>
		///     Runs away while scanning for enemy
		/// </summary>
		public void Flee()
		{
			Out.Write("I've entered the Flee state");
		}

		#endregion States
	}
}