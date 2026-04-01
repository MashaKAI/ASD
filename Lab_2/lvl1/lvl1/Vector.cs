using System;

namespace lvl1
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

        public double GetRadius()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public double GetAngle()
        {
            return Math.Atan2(Y, X);
        }

        public void Display()
        {
            Console.WriteLine($"Вектор({X}; {Y}) | Радіус: {GetRadius():F2} | Кут OX: {GetAngle():F2} рад");
        }
    }
}