using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    class Cone
    {
        public float Height { get; protected set; } = 0f;
        public float Radius { get; protected set; } = 0f;

        public virtual void ReadFromConsole()
        {
            Console.Write("Высота: ");
            Height = float.Parse(Console.ReadLine());

            Console.Write("Радиус основания: ");
            Radius = float.Parse(Console.ReadLine());
        }

        public virtual void PrintToConsole()
        {
            Console.WriteLine($"Высота: {Height}");
            Console.WriteLine($"Радиус основания: {Radius}");
        }

        public virtual double CalculateV()
        {
            return 1d / 3d * Math.PI * Radius * Radius * Height;
        }

        public double CalculateLowerSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

