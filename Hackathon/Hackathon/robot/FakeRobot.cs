using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hackathon.interfaces;
using Hackathon.math;
using Hackathon.fakehardware;
using Hackathon.fakehardware.sensors;

namespace Hackathon.robot {
    class FakeRobot : IRobot {

        private IDistance[] sensors;
        private IWheel leftWheel;
        private IWheel rightWheel;

        public FakeRobot() {
            sensors = new IDistance[] {
                new Infrared(),
                new Sonar(),
                new Sonar(),
                new Sonar()
            };

            leftWheel = new Wheel();
            rightWheel = new Wheel();
        }
    }
}
