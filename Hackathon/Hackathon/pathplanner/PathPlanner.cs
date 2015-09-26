using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hackathon.interfaces;
using Hackathon.math;

namespace Hackathon.pathplanner {
    class PathPlanner : IPathPlanner {
        public IRobot robot { get; private set; }
        public ILocalisation localisation { get; private set; }

        public PathPlanner(IRobot robot, ILocalisation localisation) {
            this.robot = robot;
            this.localisation = localisation;
        }

        public void MoveTo(Vector2 position) {
            Console.WriteLine("Going To! {0}", position);
        }
    }
}
