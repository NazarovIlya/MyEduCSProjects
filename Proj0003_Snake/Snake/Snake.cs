using System.Drawing;

namespace Snake
{
    internal class Figure
    {
        protected List<Point> points;
        public void DrawLine()
        {
            foreach (Point p in points)
            {
                p.DrawPoint();
            }
        }
    }
}