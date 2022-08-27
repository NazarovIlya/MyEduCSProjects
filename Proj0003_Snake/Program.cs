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

            HorizontalLine lineUp = new HorizontalLine(1, 95, 1, '#');
            lineUp.DrawLine();
            HorizontalLine lineDown = new HorizontalLine(1, 95, 33, '#');
            lineDown.DrawLine();
            VerticalLine lineLeft = new VerticalLine(1, 33, 1, '#');
            lineLeft.DrawLine();
            VerticalLine lineRight = new VerticalLine(1, 33, 95, '#');
            lineRight.DrawLine();

            //

            Point p = new Point(20, 10);
            Snake snake = new Snake(p, 3, Direction.RIGTH);
            snake.DrawLine();

            FoodCreator foodCreator = new FoodCreator(95, 34, '@');
            Point food = foodCreator.CreateFood();
            food.DrawPoint();
            
            while(true)
            {
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.DrawPoint();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(250);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Control(key.Key);
                    snake.IsExit(key.Key);
                }
            }
        }
    }
}
