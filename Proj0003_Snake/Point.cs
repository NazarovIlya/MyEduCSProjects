using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj0003_Snake
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char SymbolAnyChar { get; set; }

        public Point(int x, int y, char symbol = '*')
        {
            X = x;
            Y = y;
            SymbolAnyChar = symbol;
        }   
        public void DrawPoint()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(SymbolAnyChar);
        }
    }
}
