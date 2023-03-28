using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.AbstractFactory.RealLife2
{
    internal class OpenGLKeyboard : IInputDevice
    {
        public string Name { get; set; } = typeof(OpenGLKeyboard).Name;

        public string TakeInput()
        {
            return "This is " + typeof(OpenGLKeyboard).Name;
        }
    }
}
