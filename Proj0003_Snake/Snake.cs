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
        public Direction Direction { get; set; }
        public Snake(Point tail, int length, Direction _direction)
        {
            Direction = _direction;
            points = new List<Point>();
            for(int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, Direction);
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
            head.DrawPoint();
        }
        public Point GetNextPoint()
        {
            Point head = points.Last();
            Point nextPont = new Point(head);
            nextPont.Move(1, Direction);
            return nextPont;
        }

        public void SnakeControl(ConsoleKey key)
            {
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        Direction = Direction.LEFT;
                        break;
                    case ConsoleKey.RightArrow:
                        Direction = Direction.RIGTH;
                        break;
                    case ConsoleKey.UpArrow:
                        Direction = Direction.UP;
                        break;
                    default:
                        Direction = Direction.DOWN;
                        break;
                }
            }
        public void IsExit(ConsoleKey key)
        {
            if (key == ConsoleKey.Escape)
                Environment.Exit(0);
        }
    }
}
