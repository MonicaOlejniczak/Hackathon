using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hackathon.interfaces;
using Hackathon.hardware.sensors;

namespace Hackathon.robot {
    class Robot {
        private IDistance[] sensors;

        public Robot() {
            sensors = new IDistance[] {
                new Infrared(),
                new Sonar(),
                new Sonar(),
                new Sonar()
            };
        }
    }
}
