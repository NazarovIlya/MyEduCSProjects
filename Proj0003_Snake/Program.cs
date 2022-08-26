using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj0003_Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\tHello snake!");
            Console.SetWindowSize(96, 35);
            Console.SetBufferSize(96, 35);

            //

            HorizontalLine lineUp = new HorizontalLine(5, 95, 5, '#');
            lineUp.DrawLine();
            HorizontalLine lineDown = new HorizontalLine(5, 95, 30, '#');
            lineDown.DrawLine();
            VerticalLine lineLeft = new VerticalLine(5, 30, 5, '#');
            lineLeft.DrawLine();
            VerticalLine lineRight = new VerticalLine(5, 30, 95, '#');
            lineRight.DrawLine();

            //

            Point p = new Point(20, 10);
            Snake snake = new Snake(p, 4, Direction.RIGTH);
            snake.DrawLine();
            snake.Move();

            Console.ReadLine();
        }
    }
}
