using System;
using System.Collections.Generic;
using System.Text;

namespace ColorBalls
{
    class Colour
    {
        private byte rVal;
        private byte gVal;
        private byte bVal;
        private byte alphaVal;
        private byte gscaleVal;

        public Colour(byte rVal, byte gVal, byte bVal)
        {
            this.rVal = rVal;
            this.gVal = gVal;
            this.bVal = bVal;
            this.alphaVal = 255;
        }

        public Colour(byte rVal, byte gVal, byte bVal, byte alphaVal)
        {
            this.rVal = rVal;
            this.gVal = gVal;
            this.bVal = bVal;
            this.alphaVal = alphaVal;
        }

        public byte GetRedValue()
        {
            return this.rVal;
        }

        public byte GetGreenValue()
        {
            return this.gVal;
        }

        public byte GetBlueValue()
        {
            return this.bVal;
        }

        public byte GetAlphaValue()
        {
            return this.alphaVal;
        }

        public byte GetGrayscaleValue()
        {
            this.gscaleVal = Convert.ToByte((this.rVal + this.gVal + 
                this.bVal) / 3);
            return this.gscaleVal;
        }

        public void SetRedValue(byte rVal)
        {
            this.rVal = rVal;
        }

        public void SetGreenValue(byte gVal)
        {
            this.gVal = gVal;
        }

        public void SetBlueValue(byte bVal)
        {
            this.bVal = bVal;
        }

        public void SetAlphaValue(byte alphaVal)
        {
            this.alphaVal = alphaVal;
        }


    }
}
