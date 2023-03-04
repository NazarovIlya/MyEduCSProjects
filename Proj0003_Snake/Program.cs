using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proj0003_Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(96, 35);
            Console.SetBufferSize(96, 35);
            Console.WriteLine("\t\t\t\t\t\tHello snake!");

            //

            Walls walls = new Walls(96, 35, 1, '#');
            walls.Draw();

            //

            Point p = new Point(20, 10);
            Snake snake = new Snake(p, 3, Direction.RIGTH);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(95, 34, '@');
            Point food = foodCreator.CreateFood();
            food.Draw();

			int delay = 300;
			int delta = 10;
			while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    snake.Exit();
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    delay -= delta;
				}
                else
                {
                    snake.Move();
				}
				Thread.Sleep(delay);

				if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Control(key.Key);
                    if (key.Key == ConsoleKey.Escape)
                        snake.Exit();
                }
            }
        }
    }
}
