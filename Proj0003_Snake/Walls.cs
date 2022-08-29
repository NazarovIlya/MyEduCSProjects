using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj0003_Snake
{
    internal class Walls
    {
        List<Figure> wallList;
        public Walls(int mapWidth, int mapHeigth, int upX, char symbol)
        {
            wallList = new List<Figure>();
            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, upX, symbol);
            HorizontalLine upDown = new HorizontalLine(0, mapWidth - 2, mapHeigth - 1, symbol);
            VerticalLine leftLine = new VerticalLine(upX, mapHeigth - 1, 0, symbol);
            VerticalLine rigthLine = new VerticalLine(upX, mapHeigth - 1, mapWidth - 2, symbol);

            wallList.Add(upLine);
            wallList.Add(upDown);
            wallList.Add(leftLine);
            wallList.Add(rigthLine);

        }
        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }

    }
}
