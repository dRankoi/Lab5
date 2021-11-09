using System;

namespace Lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Конус или усеченный конус?");
                Console.WriteLine("1 - Конус");
                Console.WriteLine("2 - Усеченный конус");
                Console.WriteLine();
                Console.Write("Ваш выбор: ");

                int answer = int.Parse(Console.ReadLine());

                Cone cone;
                if (answer == 1)
                    cone = new Cone();
                else if (answer == 2)
                    cone = new Conoid();
                else
                    throw new Exception("Неизвестный выбор");

                Console.WriteLine();
                Console.WriteLine("Введите параметры");
                cone.ReadFromConsole();

                Console.WriteLine();
                Console.WriteLine("Введенные параметры:");
                cone.PrintToConsole();

                Console.WriteLine();
                Console.WriteLine($"Обьем фигуры: {cone.CalculateV()}");
                Console.WriteLine($"Площадь нижнего основания: {cone.CalculateLowerSquare()}");

        }
    }
}
