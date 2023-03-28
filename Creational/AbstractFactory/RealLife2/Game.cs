using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.AbstractFactory.RealLife2
{
    internal class Game
    {
        IInputDevice inputDevice;
        IRenderEngine renderEngine;

        public Game(IGamingPlatform gamingPlatform)
        {
            inputDevice = gamingPlatform.CreateInputDevice();
            renderEngine = gamingPlatform.CreateRenderEngine();
        }

        public string RenderGame()
        {
            return renderEngine.Render(inputDevice);
        }
    }
}
