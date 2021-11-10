using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Lab5_1
{
    class SquareTransformer
    {
        public PointF[] squareVertexes;

        public void ReadParameters()
        {
            Console.Write("X: ");
            float x = float.Parse(Console.ReadLine());

            Console.Write("Y: ");
            float y = float.Parse(Console.ReadLine());

            Console.Write("Сторона: ");
            float side = float.Parse(Console.ReadLine());

            squareVertexes = new PointF[]
            {
                new PointF(x,y),
                new PointF(x + side, y),
                new PointF(x + side, y - side),
                new PointF(x,y - side)
            };
        }

        public virtual void LeftArrow()
        {
            Move(new SizeF(-1f, 0f));
        }

        public virtual void RightArrow()
        {
            Move(new SizeF(1f, 0f));
        }

        public void PrintParameters()
        {

            Console.WriteLine("Координаты вершин квадрата:");

            int i;
            for (i = 0; i < squareVertexes.Length - 1; i++)
                Console.Write(
                    $"({squareVertexes[i].X};" +
                    $"{squareVertexes[i].Y}), "
                );

            Console.WriteLine(squareVertexes[i]);
        }

        protected void Move(SizeF offset)
        {
            for (int i = 0; i < squareVertexes.Length; i++)
                squareVertexes[i] += offset;
        }


      
    }
}

