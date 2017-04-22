using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleSetup.Robocode;
using PG4500_2017_Exam1;
using Robocode;
using Robocode.Util;
using Santom;
using Tomtom.FSM;

namespace Tomtom
{
    public static class Movement
    {
/*
        public Vector2D Seek(Hartho_DuelBot robot, EnemyData enemy)
        {
            return new Vector2D(robot.Position, enemy.Position);
        }
*/

        public static void Arrive(this State state)
        {
            //state.Approach();
        }

        public static void Ram(this State state)
        {
            state.FaceTarget();
        }
    }
}
