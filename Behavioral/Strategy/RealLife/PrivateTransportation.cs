using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Behavioral.Strategy.RealLife
{
    internal class PrivateTransportation : IRouteStrategy
    {
        public string CalculateRoute(string startPoint, string endPoint)
        {
            return String.Format("Shortest path from {0} to {1} from this strategy is via 'private' or 'shared taxi service'", startPoint, endPoint);
        }
    }
}
