﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj0003_Snake
{
    internal class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char symbol)
        {
            points = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, symbol);
                points.Add(p);
            }
        }
    }
}

