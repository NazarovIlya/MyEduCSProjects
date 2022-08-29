using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Proj0003_Snake
{
    internal class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            points = new List<Point>();
            for(int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                points.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = points.First();
            points.Remove(tail);
            Point head = GetNextPoint();
            points.Add(head);

            tail.Clear();
            head.Draw();
        }
        public Point GetNextPoint()
        {
            Point head = points.Last();
            Point nextPont = new Point(head);
            nextPont.Move(1, direction);
            return nextPont;
        }
        internal bool IsHitTail()
        {
            var head = points.Last();
            for(int i = 0; i < points.Count - 2; i++)
            {
                if (head.IsHit(points[i]))
                    return true;
            }
            return false;
        }

        public void Control(ConsoleKey key)
            {
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        direction = Direction.LEFT;
                        break;
                    case ConsoleKey.RightArrow:
                        direction = Direction.RIGTH;
                        break;
                    case ConsoleKey.UpArrow:
                        direction = Direction.UP;
                        break;
                    default:
                        direction = Direction.DOWN;
                        break;
                }
            }
        public void IsExit(ConsoleKey key)
        {
            if (key == ConsoleKey.Escape)
                Environment.Exit(0);
        }
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if(head.IsHit(food))
            {
                food.Clear();
                food.SymbolAnyChar = head.SymbolAnyChar;
                points.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}
