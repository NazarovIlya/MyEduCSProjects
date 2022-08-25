using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj0003_Snake
{
    internal class Program
    {
        static void DrawPoint(int x, int y, char symbolAnyChar)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbolAnyChar);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\tHello snake!");

            int xa = 1;
            int ya = 3;
            char symbolFirst = '*';

            DrawPoint(xa, ya, symbolFirst);

            Console.ReadLine();
        }
    }
}
