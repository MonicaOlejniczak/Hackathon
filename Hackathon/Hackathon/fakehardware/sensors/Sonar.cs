using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hackathon.interfaces;
using Hackathon.hardware.sensors;

namespace Hackathon.fakehardware.sensors {
    class Sonar : IDistance {
        public double Distance { get { return 0; } }
    }
}
