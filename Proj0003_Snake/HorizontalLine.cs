﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj0003_Snake
{
    internal class HorizontalLine
    {
        List<Point> points;
        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            points = new List<Point>();
            for(int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, symbol);
                points.Add(p);
            }
        }
        public void DrawLine()
        {
            foreach(Point p in points)
            {
                p.DrawPoint();
            }
        }
    }
}
