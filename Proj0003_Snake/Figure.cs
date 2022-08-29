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
    }
}
