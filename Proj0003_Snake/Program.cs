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

            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.simbol = '*';
            p1.DrawPoint();

            Point p2 = new Point();
            p2.x = 8;
            p2.y = 4;
            p2.simbol = '%';
            p2.DrawPoint();
            Console.ReadLine();
        }
    }
}
