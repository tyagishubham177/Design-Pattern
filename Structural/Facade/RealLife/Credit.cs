using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Structural.Facade.RealLife
{
    internal class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return true;
        }
    }
}
