using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Behavioral.Strategy.RealLife
{
    internal interface IRouteStrategy
    {
        string CalculateRoute(string startPoint, string endPoint);
    }
}
