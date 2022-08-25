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

            Point p1 = new Point(1, 3);
            p1.DrawPoint();
            var p2 = new Point(8, 3, '$');
            p2.DrawPoint();

            HorizontalLine line = new HorizontalLine(5, 15, 10, '-');
            line.DrawLine();

            Console.ReadLine();
        }
    }
}
