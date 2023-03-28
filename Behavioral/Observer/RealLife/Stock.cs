using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Behavioral.Observer.RealLife
{
    internal abstract class Stock
    {
        private string symbol;
        private double price;
        private List<IInvestor> investors = new List<IInvestor>();
        // Constructor
        public Stock(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }
        public void Attach(IInvestor investor)
        {
            investors.Add(investor);
        }
        public void Detach(IInvestor investor)
        {
            investors.Remove(investor);
        }
        public void Notify()
        {
            Console.WriteLine(Symbol + "'s stock price changed to : " + Price);
            foreach (IInvestor investor in investors)
            {
                investor.Action(this);
            }
            Console.WriteLine("");
        }
        // Gets or sets the price
        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    Notify();
                }
            }
        }
        // Gets the symbol
        public string Symbol
        {
            get { return symbol; }
        }
    }
}
