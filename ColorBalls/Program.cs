using System;

namespace ColorBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int numBalls = 3;
            int maxThrows = 20;
            Ball[] balls;

            Colour Red = new Colour(255, 0, 0);
            
            // Initialize array with the number of balls given
            balls = new Ball[numBalls];

            // Creates 3 different balls to throw and pop, using different
            // overload os the Ball constructor
            balls[0] = new Ball(255, 255, 255, 10.0f);
            balls[1] = new Ball(140, 50, 200, 5.2f);
            balls[2] = new Ball(Red, 20.9f);

            // int i is set as 1 as to make checking/changing the throws
            // at which the balls are popped more direct, being that it will
            // print the same values as are shown in the code
            for(int i = 1; i <= maxThrows; i++)
            {
                balls[0].Throw();
                balls[1].Throw();
                balls[2].Throw();
                if (i == 1) balls[0].Pop();
                else if (i == 15) balls[2].Pop();
            }

            // Check balls[0] status
            Console.WriteLine($"1st ball's throw count: " +
                $"{balls[0].GetThrowCount()}");

            // Check balls[1] status
            Console.WriteLine($"2nd ball's throw count: " +
                $"{balls[1].GetThrowCount()}");

            // Check balls[2] status
            Console.WriteLine($"3rd ball's throw count: " +
                $"{balls[2].GetThrowCount()}");


            // Test colour creation and colour value gettin
            /*
            Colour colour = new Colour(129, 5, 240);

            Console.WriteLine($"Red: {colour.GetRedValue()}\nGreen: " +
                $"{colour.GetGreenValue()}\nBlue: {colour.GetBlueValue()}\n" +
                $"Grayscale: {colour.GetGrayscaleValue()}");
            */

            // Test colour value setting
            /*
            colour.SetRedValue(255);
            colour.SetGreenValue(100);
            colour.SetBlueValue(210);

            Console.WriteLine($"Red: {colour.GetRedValue()}\nGreen: " +
                $"{colour.GetGreenValue()}\nBlue: {colour.GetBlueValue()}\n" +
                $"Grayscale: {colour.GetGrayscaleValue()}");
               */
        }
    }
}
