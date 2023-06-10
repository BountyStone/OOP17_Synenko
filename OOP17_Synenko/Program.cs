using System;

namespace BodyShapes
{
    abstract class Body
    {
        public abstract double CalculateSurfaceArea();
        public abstract double CalculateVolume();
    }

    class Parallelepiped : Body
    {
        private double length;
        private double width;
        private double height;

        public Parallelepiped(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public override double CalculateSurfaceArea()
        {
            return 2 * (length * width + width * height + height * length);
        }

        public override double CalculateVolume()
        {
            return length * width * height;
        }
    }

    class Ball : Body
    {
        private double radius;

        public Ball(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateSurfaceArea()
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }

        public override double CalculateVolume()
        {
            return (4 / 3) * Math.PI * Math.Pow(radius, 3);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Parallelepiped parallelepiped = new Parallelepiped(3, 4, 5);
            Console.WriteLine("Площа поверхнi паралелепiпеда: " + parallelepiped.CalculateSurfaceArea());
            Console.WriteLine("Об'єм паралелепiпеда: " + parallelepiped.CalculateVolume());

            Ball ball = new Ball(2);
            Console.WriteLine("Площа поверхнi кулi: " + ball.CalculateSurfaceArea());
            Console.WriteLine("Об'єм кулi: " + ball.CalculateVolume());

            Console.ReadLine();
        }
    }
}
