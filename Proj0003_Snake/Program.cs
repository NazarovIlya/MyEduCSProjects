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

            //

            HorizontalLine lineUp = new HorizontalLine(15, 95, 5, '#');
            lineUp.DrawLine();
            HorizontalLine lineDown = new HorizontalLine(15, 95, 30, '#');
            lineDown.DrawLine();
            VerticalLine lineLeft = new VerticalLine(5, 30, 15, '#');
            lineLeft.DrawLine();
            VerticalLine lineRight = new VerticalLine(5, 30, 95, '#');
            lineRight.DrawLine();

            //


            var p1 = new Point(20, 10);
            p1.DrawPoint();
            var p2 = new Point(30, 10, '$');
            p2.DrawPoint();

            Console.ReadLine();
        }
    }
}
