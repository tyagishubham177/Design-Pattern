using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.AbstractFactory.RealLife2
{
    internal interface IRenderEngine
    {
        string Render(IInputDevice inputDevice);
    }
}
