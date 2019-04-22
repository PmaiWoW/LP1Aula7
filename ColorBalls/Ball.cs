using System;
using System.Collections.Generic;
using System.Text;

namespace ColorBalls
{
    class Ball
    {
        private Colour colour;
        private int size;
        private int throwCount;

        public Ball(byte rVal, byte gVal, byte bVal, int size)
        {
            this.colour = new Colour(rVal, gVal, bVal);
            this.size = size;
            this.throwCount = 0;
        }

        public int Pop() => this.size = 0;

        public int Throw()
        {
            if (size > 0) this.throwCount++;
            return this.throwCount;
        }

        public int GetThrowCount() => this.throwCount;
    }
}
