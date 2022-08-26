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
            switch (direction)
            {
                case Direction.LEFT:
                    this.X -= offset;
                    break;
                case Direction.RIGTH:
                    this.X += offset;
                    break;
                case Direction.UP:
                    this.Y -= offset;
                    break;
                default:
                    this.Y += offset;
                    break;
            }
        }
        public void DrawPoint()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(SymbolAnyChar);
        }
        public void Clear()
        {
            this.SymbolAnyChar = ' ';
            DrawPoint();
        }
        public bool IsHit(Point p)
        {
            return p.X == this.X && p.Y == this.Y;
        }
        public override string ToString()
        {
            return X + ", " + Y + ", " + SymbolAnyChar;
        }
    }
}
