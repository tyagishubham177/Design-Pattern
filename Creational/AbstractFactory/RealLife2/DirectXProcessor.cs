namespace DesignPatternsApp.AbstractFactory.RealLife2
{
    internal class DirectXProcessor : IRenderEngine
    {
        public string Render(IInputDevice inputDevice)
        {
            return "This is " + typeof(DirectXProcessor).Name + " which uses : " + inputDevice.Name;
        }
    }
}