using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hackathon.interfaces;
using Hackathon.fakehardware.sensors;

namespace Hackathon {
    class Rover {
        private IDistance[] sensors;

        public Rover() {
            sensors = new IDistance[] {
                new Infrared(),
                new Sonar(),
                new Sonar(),
                new Sonar()
            };

            Run();
        }

        private void Run() {
            Console.WriteLine("Sensors {0}", sensors.Length);
        }

        static void Main(string[] args) {
            new Rover();
        }
    }
}
