using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hackathon.interfaces;

namespace Hackathon.odometry {
    class Odometry : IOdometry {
        public IRobot robot { get; private set; }

        public Odometry(IRobot robot) {
            this.robot = robot;
        }
    }
}
