using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Creational.Prototype.RealLife
{
    internal class Color : ColorPrototype
    {
        int red;
        int green;
        int blue;


        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }


        public override ColorPrototype Clone()
        {
            return this.MemberwiseClone() as ColorPrototype;
        }

        public override string ToString()
        {
            return String.Format(" Red:{0}, Blue:{1}, Green:{2} ", red, blue, green);
        }
    }
}
