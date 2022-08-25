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
        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            SymbolAnyChar = p.SymbolAnyChar;
        }
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.LEFT)
                X -= offset;
            else if (direction == Direction.RIGTH)
                X += offset;
            else if (direction == Direction.UP)
                Y += offset;
            else Y -= offset;
        }
        public void DrawPoint()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(SymbolAnyChar);
        }
        public override string ToString()
        {
            return X + ", " + Y + ", " +SymbolAnyChar;
        }
    }
}
