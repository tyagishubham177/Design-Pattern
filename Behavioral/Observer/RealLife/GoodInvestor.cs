using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Behavioral.Observer.RealLife
{
    internal class GoodInvestor : IInvestor
    {
        public void Action(Stock stock)
        {
            Console.WriteLine(typeof(GoodInvestor).Name + " : " + stock.Symbol + (stock.Price <= 100 ? " is low , BUY!" : " is high , SELL!"));
        }
    }
}
