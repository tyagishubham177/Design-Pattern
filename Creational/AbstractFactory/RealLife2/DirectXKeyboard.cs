namespace DesignPatternsApp.AbstractFactory.RealLife2
{
    internal class DirectXKeyboard : IInputDevice
    {
        public string Name { get; set; } = typeof(DirectXKeyboard).Name;

        public string TakeInput()
        {
            return "This is " + typeof(DirectXKeyboard).Name;
        }
    }
}