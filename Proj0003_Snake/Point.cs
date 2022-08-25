using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj0003_Snake
{
    internal class Point
    {
        public int x;
        public int y;
        public char symbolAnyChar;

        public void DrawPoint()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbolAnyChar);
        }
    }
}
