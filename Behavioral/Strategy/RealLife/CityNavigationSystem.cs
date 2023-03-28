using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Behavioral.Strategy.RealLife
{
    internal class CityNavigationSystem
    {
        private IRouteStrategy _routeStrategy;

        public CityNavigationSystem() { }

        public CityNavigationSystem(IRouteStrategy routeStrategy)
        {
            _routeStrategy = routeStrategy;
        }

        public void SetRouteStrategy(IRouteStrategy routeStrategy)
        {
            this._routeStrategy = routeStrategy;
        }

        public string GetRoute(string startPoint, string endPoint)
        {
            return _routeStrategy.CalculateRoute(startPoint, endPoint);
        }
    }
}
