using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Behavioral.Observer.RealLife
{
    internal class IBMStock : Stock
    {
        public IBMStock(string symbol, double price) : base(symbol, price)
        {
        }
    }
}
