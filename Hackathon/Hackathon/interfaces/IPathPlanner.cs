using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hackathon.math;

namespace Hackathon.interfaces {
    interface IPathPlanner {
        void MoveTo(Vector2 position);
    }
}
