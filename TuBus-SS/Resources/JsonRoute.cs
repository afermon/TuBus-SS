using System.Collections.Generic;

namespace Entities
{
    public class JsonRoute
    {
        public Waypoint Origin { get; set; }
        public Waypoint Destination { get; set; }
        public List<Waypoint> Waypoints { get; set; }
    }
}
