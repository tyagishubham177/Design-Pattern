using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.AbstractFactory.RealLife2
{
    internal class OpenGLProcessor : IRenderEngine
    {
        public string Render(IInputDevice inputDevice)
        {
            return "This is " + typeof(OpenGLProcessor).Name + " which uses : " + inputDevice.Name;
        }
    }
}
