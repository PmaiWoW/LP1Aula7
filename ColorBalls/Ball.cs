using System;
using System.Collections.Generic;
using System.Text;

namespace ColorBalls
{
    class Ball
    {
        private Colour colour;
        private float size;
        private int throwCount;

        public Ball(byte rVal, byte gVal, byte bVal, float size)
        {
            this.colour = new Colour(rVal, gVal, bVal);
            this.size = size;
            this.throwCount = 0;
        }

        public Ball(Colour colour, float size)
        {
            this.colour = colour;
            this.size = size;
            this.throwCount = 0;
        }

        public float Pop() => this.size = 0;

        public int Throw()
        {
            if (size > 0) this.throwCount++;
            return this.throwCount;
        }

        public int GetThrowCount() => this.throwCount;
    }
}
