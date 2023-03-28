using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.AbstractFactory.RealLife2
{
    internal class DirectX : IGamingPlatform
    {
        public IInputDevice CreateInputDevice()
        {
            return new DirectXKeyboard();
        }

        public IRenderEngine CreateRenderEngine()
        {
            return new DirectXProcessor();
        }
    }
}
