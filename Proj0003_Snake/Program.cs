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
            Console.SetBufferSize(120, 35);
            Console.WriteLine("\t\t\t\t\t\tHello snake!");

            Point p1 = new Point(1, 3);
            p1.DrawPoint();
            var p2 = new Point(8, 3, '$');
            p2.DrawPoint();

            HorizontalLine lineUp = new HorizontalLine(15, 95, 5, '#');
            lineUp.DrawLine();
            HorizontalLine lineDown = new HorizontalLine(15, 95, 30, '#');
            lineDown.DrawLine();
            VerticalLine lineLeft = new VerticalLine(5, 30, 15, '#');
            lineLeft.DrawLine();
            VerticalLine lineRight = new VerticalLine(5, 30, 95, '#');
            lineRight.DrawLine();

            Console.ReadLine();
        }
    }
}
