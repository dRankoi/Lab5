using System;

namespace Lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {


                Console.WriteLine(
                    "Перемещать квадрат на стрелку влево и стрелку вправо или вращать?"
                );
                Console.WriteLine("1 - перемещать");
                Console.WriteLine("2 - вращать");
                Console.Write("Ваш выбор: ");
                int choice = int.Parse(Console.ReadLine());

                SquareTransformer transformer = null;

                if (choice == 1)
                    transformer = new SquareTransformer();
                else if (choice == 2)
                    transformer = new Rotation();
                else
                    throw new Exception("Неизвестный ответ");

                transformer.ReadParameters();

                Console.Clear();
                PrintKeys();
                Console.WriteLine();
                transformer.PrintParameters();

                while (true)
                {
                    var keyInfo = Console.ReadKey();

                    bool exit = false;

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            transformer.LeftArrow();
                            break;
                        case ConsoleKey.RightArrow:
                            transformer.RightArrow();
                            break;
                        case ConsoleKey.Escape:
                            exit = true;
                            break;
                    }

                    if (exit)
                        return;

                    Console.Clear();
                    PrintKeys();
                    Console.WriteLine();
                    transformer.PrintParameters();
                }
           
        }

        private static void PrintKeys()
        {
            Console.WriteLine("Стрелка влево - повернуть/переместить влево");
            Console.WriteLine("Стрелка вправо - повернуть/переместить вправо");
            Console.WriteLine("Escape - выход");
        }
    }
    
}
