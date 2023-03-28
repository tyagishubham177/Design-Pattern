using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.AbstractFactory.RealLife2
{
    internal class OpenGL : IGamingPlatform
    {
        public IInputDevice CreateInputDevice()
        {
            return new OpenGLKeyboard();
        }

        public IRenderEngine CreateRenderEngine()
        {
            return new OpenGLProcessor();
        }
    }
}
