using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Behavioral.Observer.RealLife
{
    internal class BadInvestor : IInvestor
    {
        public void Action(Stock stock)
        {
            Console.WriteLine(typeof(BadInvestor).Name + " : " + stock.Symbol + (stock.Price <= 100 ? " is low , SELL!" : " is high , BUY!"));
        }
    }
}
