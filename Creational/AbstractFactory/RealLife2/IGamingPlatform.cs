using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.AbstractFactory.RealLife2
{
    internal interface IGamingPlatform
    {
        IInputDevice CreateInputDevice();
        IRenderEngine CreateRenderEngine();
    }
}
