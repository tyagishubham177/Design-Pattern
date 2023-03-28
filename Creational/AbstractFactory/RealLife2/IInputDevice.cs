using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.AbstractFactory.RealLife2
{
    internal interface IInputDevice
    {
        string Name { get; set; }
        string TakeInput();
    }
}
