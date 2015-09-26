using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hackathon.interfaces;
using Hackathon.robot;
using Hackathon.math;
using Hackathon.localisation;
using Hackathon.odometry;
using Hackathon.pathplanner;

namespace Hackathon {
    class Rover {
        private IRobot robot;
        private ILocalisation localisation;
        private IOdometry odometry;
        private IPathPlanner pathPlanner;

        public Rover() {
            //robot = new Robot();
            robot = new FakeRobot();
            odometry = new Odometry(robot);
            localisation = new Localisation();
            pathPlanner = new PathPlanner(robot, localisation);
        }

        private void Run() {
            pathPlanner.MoveTo(new Vector2(0, 1));
        }

        static void Main(string[] args) {
            var rover = new Rover();
            rover.Run();
        }
    }
}
