using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj0003_Snake
{
    internal class Figure
    {
        protected List<Point> points;
        public virtual void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }
        internal bool IsHit(Figure figure)
        {
            foreach(var p in points)
            {
                if(figure.IsHit(p))
                    return true;
            }
            return false;
        }
        private bool IsHit(Point point)
        {
            foreach (Point p in points)
            {
                if(p.IsHit(point))
                return true;
            }
            return false;
        }
        public void Exit()
        {
            Console.Clear();
            string centerText = "GAME OVER!!!";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            int centerX = (Console.WindowWidth / 2) - (centerText.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.WriteLine(centerText);
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Environment.Exit(0);
        }
    }
}
