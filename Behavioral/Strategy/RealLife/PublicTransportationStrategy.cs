using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Behavioral.Strategy.RealLife
{
    internal class PublicTransportationStrategy : IRouteStrategy
    {
        public string CalculateRoute(string startPoint, string endPoint)
        {
            return String.Format("Shortest path from {0} to {1} from this strategy is via 'subway' or 'bus'", startPoint, endPoint);
        }
    }
}
