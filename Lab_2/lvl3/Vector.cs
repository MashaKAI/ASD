using System;

namespace lvl3
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double GetAngle() => Math.Atan2(Y, X);

        public double GetLength() => Math.Sqrt(X * X + Y * Y);

        public void Display()
        {
            Console.WriteLine($"Вектор({X}; {Y}) | Кут: {GetAngle():F2} | Довжина: {GetLength():F2}");
        }
    }
}