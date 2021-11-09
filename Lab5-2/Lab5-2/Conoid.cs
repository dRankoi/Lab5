using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    class Conoid : Cone 
    {
        public float UpperRadius { get; protected set; }

        public override void ReadFromConsole()
        {
            base.ReadFromConsole();

            Console.Write("Радиус верхнего основания: ");
            UpperRadius = float.Parse(Console.ReadLine());
        }

        public override void PrintToConsole()
        {
            base.PrintToConsole();

            Console.WriteLine(
                $"Радиус верхнего основания: {UpperRadius}"
            );
        }

        public override double CalculateV()
        {
            double Sqr(double a)
            {
                return a * a;
            }

            return
                1d / 3d * Math.PI * Height * (Sqr(UpperRadius) +UpperRadius * Radius +Sqr(Radius));
        }
    }
}

