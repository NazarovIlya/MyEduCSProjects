using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj0003_Snake
{
    internal class HorizontalLine : Figure 
    {
        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            points = new List<Point>();
            for(int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, symbol);
                points.Add(p);
            }
        }
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Point p in points)
            {
                p.Draw();
            }
            base.Draw();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
